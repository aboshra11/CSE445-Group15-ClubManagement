using System;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Xml.Linq;

namespace ClubManagementWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If user is already logged in, redirect to member page
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/MemberPage.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            pnlError.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter both username and password.";
                pnlError.Visible = true;
                return;
            }

            // Try to authenticate against Member.xml first, then Staff.xml
            if (AuthenticateUser(username, password))
            {
                // Store username in session
                Session["Username"] = username;
                Session["LoginTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Handle "Remember Me" cookie
                if (chkRememberMe.Checked)
                {
                    // TODO: Replace plain-text cookie with hashed value 
                    // once ShreyaHashLib.dll is available
                    HttpCookie cookie = new HttpCookie("RememberMe");
                    cookie["Username"] = username;
                    cookie.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    // Clear any existing remember me cookie
                    if (Request.Cookies["RememberMe"] != null)
                    {
                        HttpCookie cookie = new HttpCookie("RememberMe");
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                }

                // Forms Authentication sign in
                FormsAuthentication.SetAuthCookie(username, chkRememberMe.Checked);

                // Redirect to originally requested page or MemberPage
                string returnUrl = Request.QueryString["ReturnUrl"];
                if (!string.IsNullOrEmpty(returnUrl))
                    Response.Redirect(returnUrl);
                else
                    Response.Redirect("~/MemberPage.aspx");
            }
            else
            {
                lblError.Text = "Invalid username or password. Please try again.";
                pnlError.Visible = true;
            }
        }

        // Authenticates user against Member.xml and Staff.xml
        private bool AuthenticateUser(string username, string password)
        {
            string appDataPath = Server.MapPath("~/App_Data/");

            // Check Member.xml
            if (CheckXmlFile(Path.Combine(appDataPath, "Member.xml"),
                "Members", "Member", username, password))
                return true;

            // Check Staff.xml
            if (CheckXmlFile(Path.Combine(appDataPath, "Staff.xml"),
                "Staff", "StaffMember", username, password))
                return true;

            return false;
        }

        // Checks an XML file for matching username/password
        // TODO: Once ShreyaHashLib.dll arrives, replace plain-text comparison
        // with: ShreyaHashLib.Hasher.HashPassword(password) == storedPassword
        private bool CheckXmlFile(string filePath, string rootElement,
            string memberElement, string username, string password)
        {
            if (!File.Exists(filePath)) return false;

            try
            {
                XDocument doc = XDocument.Load(filePath);
                foreach (XElement member in doc.Descendants(memberElement))
                {
                    string storedUsername = member.Element("Username")?.Value;
                    string storedPassword = member.Element("Password")?.Value;

                    // Plain text comparison — TEMPORARY until ShreyaHashLib available
                    if (storedUsername == username && storedPassword == password)
                        return true;
                }
            }
            catch { return false; }

            return false;
        }
    }
}
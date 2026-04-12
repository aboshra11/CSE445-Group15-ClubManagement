using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace ClubManagementWeb
{
    public partial class MemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If not logged in, redirect to login page
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                // Display username from Forms Authentication
                lblUsername.Text = User.Identity.Name;

                // Display session info collected by Global.asax
                string sessionStart = Session["SessionStart"] != null
                    ? Session["SessionStart"].ToString()
                    : "Not recorded";

                string loginTime = Session["LoginTime"] != null
                    ? Session["LoginTime"].ToString()
                    : "Not recorded";

                lblSessionInfo.Text = string.Format(
                    "Session started: {0}<br/>Logged in at: {1}<br/>Total visitors: {2}",
                    sessionStart,
                    loginTime,
                    Application["VisitorCount"] != null
                        ? Application["VisitorCount"].ToString() : "0"
                );

                // Check Remember Me cookie
                HttpCookie cookie = Request.Cookies["RememberMe"];
                if (cookie != null && !string.IsNullOrEmpty(cookie["Username"]))
                {
                    lblCookieInfo.Text = string.Format(
                        "Remember Me cookie is active for user: <strong>{0}</strong><br/>" +
                        "Cookie expires: {1}",
                        cookie["Username"],
                        cookie.Expires == DateTime.MinValue
                            ? "End of session"
                            : cookie.Expires.ToString("yyyy-MM-dd")
                    );
                }
                else
                {
                    lblCookieInfo.Text = "No Remember Me cookie set for this session.";
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Session.Clear();
            Session.Abandon();

            // Clear Remember Me cookie
            HttpCookie cookie = new HttpCookie("RememberMe");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            // Sign out of Forms Authentication
            FormsAuthentication.SignOut();

            // Redirect to login page
            Response.Redirect("~/Login.aspx");
        }
    }
}
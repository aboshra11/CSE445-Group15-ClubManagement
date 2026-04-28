using System;
using System.IO;
using System.Web.UI;
using System.Xml.Linq;
using ShreyaHashLib;

namespace ClubManagementWeb
{
    public partial class MemberSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // CAPTCHA generates itself on first load via its own Page_Load
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            pnlError.Visible = false;
            pnlSuccess.Visible = false;

            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Validate all fields filled
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                DisplayError("Please fill in all fields.");
                return;
            }

            // Validate passwords match
            if (password != confirmPassword)
            {
                DisplayError("Passwords do not match.");
                return;
            }

            // Validate password length
            if (password.Length < 6)
            {
                DisplayError("Password must be at least 6 characters.");
                return;
            }

            // Validate CAPTCHA — IsValid is a property not a method
            if (!captcha.IsValid)
            {
                DisplayError("CAPTCHA verification failed. Please try again.");
                captcha.Reset();
                return;
            }

            // Check if username already exists
            if (UsernameExists(username))
            {
                DisplayError("Username already taken. Please choose another.");
                return;
            }

            // Hash password using ShreyaHashLib
            string hashedPassword = PasswordHasher.HashPassword(password);

            // Save to Member.xml
            SaveMember(username, hashedPassword, email);

            // Show success and redirect to login
            pnlSuccess.Visible = true;
            lblSuccess.Text = "Account created successfully! Redirecting to login...";

            // Redirect after 2 seconds
            Response.AddHeader("Refresh", "2;url=Login.aspx");
        }

        // Checks if username already exists in Member.xml
        private bool UsernameExists(string username)
        {
            string path = Server.MapPath("~/App_Data/Member.xml");
            if (!File.Exists(path)) return false;

            XDocument doc = XDocument.Load(path);
            foreach (XElement member in doc.Descendants("Member"))
            {
                if (member.Element("Username")?.Value == username)
                    return true;
            }
            return false;
        }

        // Saves new member to Member.xml with hashed password
        private void SaveMember(string username, string hashedPassword, string email)
        {
            string path = Server.MapPath("~/App_Data/Member.xml");

            XDocument doc;
            if (File.Exists(path))
                doc = XDocument.Load(path);
            else
                doc = new XDocument(new XElement("Members"));

            doc.Root.Add(
                new XElement("Member",
                    new XElement("Username", username),
                    new XElement("Password", hashedPassword),
                    new XElement("Email", email),
                    new XElement("RegistrationDate", DateTime.Now.ToString("yyyy-MM-dd"))
                )
            );

            doc.Save(path);
        }

        private void DisplayError(string message)
        {
            lblError.Text = message;
            pnlError.Visible = true;
        }
    }
}
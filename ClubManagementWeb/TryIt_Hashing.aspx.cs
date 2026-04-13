using System;
using System.Web.UI;
using ShreyaHashLib;

namespace ClubManagementWeb
{
    public partial class TryIt_Hashing : Page
    {
        protected void btnHash_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                string hash = PasswordHasher.HashPassword(txtPassword.Text);
                lblHashResult.Text = "✅ Hash: " + hash;
                lblHashResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblHashResult.Text = "❌ Please enter a password";
                lblHashResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVerifyPassword.Text) || string.IsNullOrEmpty(txtStoredHash.Text))
            {
                lblVerifyResult.Text = "❌ Please enter both password and hash";
                lblVerifyResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool isValid = PasswordHasher.VerifyPassword(txtVerifyPassword.Text, txtStoredHash.Text);

            if (isValid)
            {
                lblVerifyResult.Text = "✅ Password matches the hash!";
                lblVerifyResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblVerifyResult.Text = "❌ Password does NOT match the hash!";
                lblVerifyResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
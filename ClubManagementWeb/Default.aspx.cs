using System;
using System.Web.UI;
using ShreyaHashLib;

namespace ClubManagementWeb
{
    public partial class _Default : Page
    {
        protected void btnMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberSignup.aspx");
        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffPage.aspx");
        }

        protected void btnHashDemo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTestPassword.Text))
            {
                string hash = PasswordHasher.HashPassword(txtTestPassword.Text);
                lblHashResult.Text = "Hash: " + hash;
                lblHashResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblHashResult.Text = "Please enter a password";
                lblHashResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
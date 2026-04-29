using System;

namespace ClubManagementWeb
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isStaff = Session["IsStaff"] != null && (bool)Session["IsStaff"];

            pnlLogin.Visible = !isStaff;
            pnlStaffContent.Visible = isStaff;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "TA" && password == "Cse445!")
            {
                Session["IsStaff"] = true;
                pnlLogin.Visible = false;
                pnlStaffContent.Visible = true;
                lblMessage.Text = "";
            }
            else
            {
                lblMessage.Text = "Invalid staff credentials. Use TA / Cse445! for testing.";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["IsStaff"] = false;
            pnlLogin.Visible = true;
            pnlStaffContent.Visible = false;
        }
    }
}
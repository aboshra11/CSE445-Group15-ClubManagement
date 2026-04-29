using System;
using System.Data;

namespace ClubManagementWeb
{
    public partial class ValidationInputControl : System.Web.UI.UserControl
    {
        protected void btnValidate_Click(object sender, EventArgs e)
        {
            lblResult.Text = KeenanValidator.GetValidationMessage(txtInput.Text, ddlType.SelectedValue);
        }
    }
}
using System;

namespace ClubManagementWeb
{
    public partial class TryIt_Validation : System.Web.UI.Page
    {
        protected void btnServiceValidate_Click(object sender, EventArgs e)
        {
            ValidationService service = new ValidationService();
            lblServiceResult.Text = service.Validate(txtServiceInput.Text, ddlServiceType.SelectedValue);
        }
    }
}
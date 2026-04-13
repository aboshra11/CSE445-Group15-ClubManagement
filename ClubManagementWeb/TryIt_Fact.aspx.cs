using System;
using System.Net;
using System.Web.UI;
using System.Web.Script.Serialization;

namespace ClubManagementWeb
{
    public partial class TryIt_Fact : Page
    {
        protected void btnGetFact_Click(object sender, EventArgs e)
        {
            string category = ddlCategory.SelectedValue;
            string serviceUrl = $"{Request.Url.GetLeftPart(UriPartial.Authority)}/FactService.svc/getfact?category={category}";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string result = client.DownloadString(serviceUrl);
                    // Remove quotes if JSON string
                    result = result.Trim('"');
                    lblFact.Text = "📌 " + result;
                    lblFact.ForeColor = System.Drawing.Color.DarkBlue;
                }
            }
            catch (Exception ex)
            {
                lblFact.Text = "❌ Error calling service: " + ex.Message;
                lblFact.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
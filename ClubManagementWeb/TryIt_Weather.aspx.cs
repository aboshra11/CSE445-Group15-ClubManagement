using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace ClubManagementWeb
{
    public partial class TryIt_Weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page loads clean — results only show after button click
        }

        protected void btnGetWeather_Click(object sender, EventArgs e)
        {
            // Hide both panels first
            pnlResult.Visible = false;
            pnlError.Visible = false;

            string zipCode = txtZipCode.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(zipCode))
            {
                lblError.Text = "Please enter a zip code.";
                pnlError.Visible = true;
                return;
            }

            try
            {
                // Call WeatherService directly — same project, no proxy needed locally
                WeatherService svc = new WeatherService();
                string result = svc.GetWeather(zipCode);
                lblResult.Text = result;
                pnlResult.Visible = true;
            }
            catch (Exception ex)
            {
                lblError.Text = "Service error: " + ex.Message;
                pnlError.Visible = true;
            }
        }
    }
}
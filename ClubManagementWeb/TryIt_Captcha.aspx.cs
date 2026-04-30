using System;
using System.Web.UI;

namespace ClubManagementWeb
{
    public partial class TryIt_Captcha : Page
    {
        
        // Provides standalone test page for the CAPTCHA User Control
        
        protected void btnTest_Click(object sender, EventArgs e)
        {
            if (captcha.IsValid)
            {
                lblResult.Text = "✓ CAPTCHA verification PASSED! The code you entered is correct.";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "✗ CAPTCHA verification FAILED! Please enter the correct code shown above.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
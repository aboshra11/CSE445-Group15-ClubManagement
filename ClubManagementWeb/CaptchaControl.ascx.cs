using System;
using System.Web.UI;

namespace ClubManagementWeb
{
    public partial class CaptchaControl : UserControl
    {
        private string actualCaptcha;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateCaptcha();
            }
        }

        private void GenerateCaptcha()
        {
            Random rand = new Random();
            actualCaptcha = rand.Next(1000, 9999).ToString();
            lblCaptcha.Text = actualCaptcha;
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
            txtCaptcha.Text = "";
            lblError.Visible = false;
        }

        public bool IsValid
        {
            get
            {
                if (txtCaptcha.Text == actualCaptcha)
                {
                    return true;
                }
                else
                {
                    lblError.Text = "Invalid CAPTCHA code! Please try again.";
                    lblError.Visible = true;
                    GenerateCaptcha();
                    txtCaptcha.Text = "";
                    return false;
                }
            }
        }

        public void Reset()
        {
            GenerateCaptcha();
            txtCaptcha.Text = "";
            lblError.Visible = false;
        }
    }
}
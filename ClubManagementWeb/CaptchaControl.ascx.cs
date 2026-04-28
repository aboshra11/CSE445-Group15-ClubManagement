using System;
using System.Web.UI;

namespace ClubManagementWeb
{
    public partial class CaptchaControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateCaptcha();
            }
            else
            {
                // Restore the displayed captcha from ViewState on postback
                if (ViewState["CaptchaCode"] != null)
                    lblCaptcha.Text = ViewState["CaptchaCode"].ToString();
            }
        }

        private void GenerateCaptcha()
        {
            Random rand = new Random();
            string code = rand.Next(1000, 9999).ToString();
            lblCaptcha.Text = code;
            ViewState["CaptchaCode"] = code;
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
                string stored = ViewState["CaptchaCode"] != null
                    ? ViewState["CaptchaCode"].ToString() : "";

                if (txtCaptcha.Text.Trim() == stored)
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
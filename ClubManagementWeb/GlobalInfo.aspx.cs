using System;
using System.Web.UI;

namespace ClubManagementWeb
{
    public partial class GlobalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read Application_Start data stored by Global.asax
            lblStartTime.Text = Application["StartTime"] != null
                ? Application["StartTime"].ToString()
                : "Not recorded yet.";

            // Read visitor count stored by Session_Start
            lblVisitorCount.Text = Application["VisitorCount"] != null
                ? Application["VisitorCount"].ToString()
                : "0";

            // Read this user's session start time
            lblSessionStart.Text = Session["SessionStart"] != null
                ? Session["SessionStart"].ToString()
                : "Not recorded yet.";

            // Read last error stored by Application_Error
            string lastError = Application["LastError"] != null
                ? Application["LastError"].ToString()
                : "No errors recorded.";

            lblLastError.Text = lastError;

            // Style the error box based on whether there's a real error
            if (lastError == "No errors recorded.")
                pnlError.CssClass = "ok-box";
            else
                pnlError.CssClass = "error-box";
        }
    }
}
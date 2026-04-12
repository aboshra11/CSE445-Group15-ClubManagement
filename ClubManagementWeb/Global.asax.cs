using System;
using System.IO;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Xml.Linq;

namespace ClubManagementWeb
{
    public class Global : HttpApplication
    {
        // ─── Application_Start ───────────────────────────────────────────────
        // Fires ONCE when the web server starts the application.
        // Records start time, initializes visitor counter,
        // and ensures Member.xml and Staff.xml exist in App_Data.
        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Record when the app started
            Application["StartTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Initialize visitor counter
            Application["VisitorCount"] = 0;

            // Initialize last error storage
            Application["LastError"] = "No errors recorded.";

            // Ensure App_Data XML files exist
            string appDataPath = Server.MapPath("~/App_Data/");
            EnsureMemberXml(appDataPath);
            EnsureStaffXml(appDataPath);
        }

        // ─── Session_Start ───────────────────────────────────────────────────
        // Fires every time a NEW user session begins.
        // Increments the global visitor counter.
        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["VisitorCount"] = (int)Application["VisitorCount"] + 1;
            Application.UnLock();

            // Store session start time for this individual user
            Session["SessionStart"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // ─── Application_Error ───────────────────────────────────────────────
        // Fires whenever an unhandled exception occurs anywhere in the app.
        // Captures the error and stores it for Page1 (GlobalInfo.aspx) to display.
        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex != null)
            {
                Application["LastError"] = string.Format(
                    "[{0}] {1}: {2}",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    ex.GetType().Name,
                    ex.Message
                );
            }
        }

        // ─── Helper: EnsureMemberXml ─────────────────────────────────────────
        // Creates Member.xml in App_Data if it does not already exist.
        private void EnsureMemberXml(string appDataPath)
        {
            string path = Path.Combine(appDataPath, "Member.xml");
            if (!File.Exists(path))
            {
                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Members")
                );
                doc.Save(path);
            }
        }

        // ─── Helper: EnsureStaffXml ──────────────────────────────────────────
        // Creates Staff.xml with the required TA account if it does not exist.
        // TODO: Replace plain-text password with SHA256 hash once ShreyaHashLib.dll arrives.
        private void EnsureStaffXml(string appDataPath)
        {
            string path = Path.Combine(appDataPath, "Staff.xml");
            if (!File.Exists(path))
            {
                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Staff",
                        new XElement("StaffMember",
                            new XElement("Username", "TA"),
                            new XElement("Password", "Cse445!"),
                            new XElement("Role", "TA")
                        )
                    )
                );
                doc.Save(path);
            }
        }
    }
}
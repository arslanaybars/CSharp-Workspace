using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace web_02StateManagment
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["onlineZiyaretci"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["onlineZiyaretci"] = (int)Application["onlineZiyaretci"] + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["onlineZiyaretci"] = (int)Application["onlineZiyaretci"] - 1;
            Application.UnLock();

        }

        protected void Application_End(object sender, EventArgs e)
        {
            Session.Abandon(); // Aktif session'ı hafızadan atar.
            Session.RemoveAll(); // Tüm session'ları hafızadan temizler.

            Application.Remove("onlineZiyaretci");
            Application.Clear(); // Tüm applicationları hafızadan atar.
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Ninject;
using System.IO;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            string topicname = "CHAT.DEMO";
            string activemqbrokerurl = "tcp://localhost:61616";

            string strclientid = Server.MachineName;
            //Subscribe first to a topic

            NonDurableTopicSubscriber mysubscriber = new NonDurableTopicSubscriber(topicname, activemqbrokerurl, strclientid);

            mysubscriber.OnMessageReceived += new MessageReceivedDelegate(mysubscriber_OnMessageReceived);
        }

        protected void mysubscriber_OnMessageReceived(string message)
        {
            File.AppendAllText(@"C:\msg.txt", "1");
        }
    }
}
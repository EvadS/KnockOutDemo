using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// package Microsoft ASP.NET Web Optimization
using System.Web.Optimization;

namespace KnockOutDemo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
             "~/Scripts/jquery-{version}.js"));
        }
    }
}
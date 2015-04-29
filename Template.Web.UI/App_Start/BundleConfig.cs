// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Microsoft">
//   Copyright © 2015 Microsoft
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Template.Web.UI
{
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/content/app.css"));

            bundles.Add(new ScriptBundle("~/js/jquery").Include("~/scripts/vendor/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/js/app").Include(
                //"~/scripts/vendor/angular.js",
                
                "~/scripts/vendor/angular-ui-router.js",
                "~/scripts/filters/filters.js",
                "~/scripts/services/services.js",
                "~/scripts/directives/directives.js",
                
                //controllers
                "~/scripts/controllers/homeController.js",
                "~/scripts/controllers/aboutController.js",
                "~/scripts/controllers/addressController.js",


                "~/scripts/app.js"));
        }
    }
}

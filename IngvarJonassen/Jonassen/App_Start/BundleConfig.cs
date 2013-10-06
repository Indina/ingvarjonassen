using System.Web.Optimization;

namespace Jonassen
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Force optimization to be on or off, regardless of web.config setting
            //BundleTable.EnableOptimizations = false;
            bundles.UseCdn = false;

            // .debug.js, -vsdoc.js and .intellisense.js files 
            // are in BundleTable.Bundles.IgnoreList by default.
            // Clear out the list and add back the ones we want to ignore.
            // Don't add back .debug.js.
            bundles.IgnoreList.Clear();
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*intellisense.js");

            // Modernizr goes separate since it loads first
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-{version}.js", "~/Scripts/plugins/retina/js/retina-{version}.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/libs",
                "//ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js")
                .Include("~/Scripts/jquery-{version}.js", "~/Scripts/bootstrap.js")
                .Include("~/Scripts/plugins/flexslider/jquery.flexslider-min.js",
                "~/Scripts/plugins/jPanelMenu/jquery.jpanelmenu.min.js",
                "~/Scripts/plugins/flexslider/jquery.flexslider-min.js",
                "~/Scripts/plugins/jRespond/js/jRespond.js",
                "~/Scripts/plugins/onePageNav/jquery.nav.js",
                "~/Scripts/plugins/parallelslider/jquery.cslider.js",
                "~/Scripts/script.js"



                ));




            // 3rd Party CSS files
            bundles.Add(new StyleBundle("~/Styles/css")
                .Include(
                    "~/Content/bootstrap/bootstrap.css",
                    "~/Content/css/font-awesome.css",
                    "~/Scripts/plugins/flexslider/flexslider.css",
                    "~/Scripts/plugins/parallelslider/parallax-slider.css",
                    "~/Content/css/theme-style.css",
                    "~/Content/css/alternative-colour.css",
                    "~/Content/css/custom-style.css",
                    "~/Content/style.css"));


        }
    }
}
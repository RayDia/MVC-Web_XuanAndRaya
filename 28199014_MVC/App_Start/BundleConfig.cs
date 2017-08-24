using System.Web;
using System.Web.Optimization;

namespace _28199014_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/jQuery_table.js",
                      "~/Scripts/jquery-ui.js",
                      "~/Scripts/datap.js",
                      "~/Scripts/plugins.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/css/animate.min.css",
                      "~/css/bootstrap.min.css",
                      "~/css/bxslider.css",
                      "~/css/contentTable.css",
                      "~/css/et-line-font.css",
                      "~/css/font-awesome.min.css",
                      "~/css/nivo-lightbox.css",
                      "~/css/owl.carousel.css",
                      "~/css/owl.theme.css",
                      "~/css/table_color.css",
                      "~/css/jquery-ui.css",
                      "~/css/style.css"));
        }
    }
}

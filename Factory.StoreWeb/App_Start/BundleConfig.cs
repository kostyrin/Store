using System.Web;
using System.Web.Optimization;

namespace Factory.StoreWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css"
                , "~/Content/bootstrap-theme.css"
                , "~/Content/Theme/css/AdminLTE.css"
                , "~/Content/Theme/css/skins/skin-green.css"
                , "~/Content/Theme/css/font-awesome.css"
                , "~/Content/Theme/css/ionicons.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/bootstrap.js"
                      , "~/Scripts/twitter-bootstrap-hover-dropdown.js"
                      , "~/Scripts/AdminLTE/app.js"
                      
                      ));

            bundles.Add(new StyleBundle("~/Content/Theme/base/css").Include(
                        "~/Content/Theme/base/jquery.ui.core.css",
                        "~/Content/Theme/base/jquery.ui.resizable.css",
                        "~/Content/Theme/base/jquery.ui.selectable.css",
                        "~/Content/Theme/base/jquery.ui.accordion.css",
                        "~/Content/Theme/base/jquery.ui.autocomplete.css",
                        "~/Content/Theme/base/jquery.ui.button.css",
                        "~/Content/Theme/base/jquery.ui.dialog.css",
                        "~/Content/Theme/base/jquery.ui.slider.css",
                        "~/Content/Theme/base/jquery.ui.tabs.css",
                        "~/Content/Theme/base/jquery.ui.datepicker.css",
                        "~/Content/Theme/base/jquery.ui.progressbar.css",
                        "~/Content/Theme/base/jquery.ui.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                  "~/Scripts/jquery-{version}.js"
                , "~/Scripts/jquery-ui-{version}.js"
                , "~/Scripts/bootstrap.js"
                , "~/Content/Theme/vendors/datatables/js/jquery.dataTables.js"
                , "~/Scripts/AdminLTE/app.js"
                , "~/Scripts/AdminLTE/demo.js"
                , "~/Scripts/AdminLTE/pages/dashboard.js"
                , "~/Scripts/AdminLTE/pages/dashboard2.js"
                //, "~/Content/Theme/vendors/metis/metisMenu.js"
                // "~/Content/Theme/vendors/metis/metisMenu.min.js"
                //, "~/Content/Theme/vendors/morris/morris.js"
                //, "~/Content/Theme/vendors/morris/morris-data.js"
                //, "~/Content/Theme/vendors/raphael/raphael.js"
                //, "~/Content/Theme/vendors/raphael/raphael-min.js"
                //, "~/Content/Theme/vendors/datatables/js/dataTables.bootstrap.js"
                
                //, "~/Content/Theme/vendors/datatables/js/jquery.dataTables.min.js"
                //, "~/Content/Theme/vendors/datatables/js/dataTables.responsive.js"
                //, "~/Content/Theme/vendors/datatables/js/dataTables.responsive.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/Vendors").Include(
                "~/Content/Theme/vendors/metis/metisMenu.min.css"
                , "~/Content/Theme/vendors/morris/morris.css"
                , "~/Content/Theme/vendors/datatables/css/jquery.dataTables.css"
                , "~/Content/Theme/vendors/datatables/css/jquery.dataTables_themeroller.css"
                , "~/Content/Theme/vendors/datatables/css/dataTables.responsive.css"
                , "~/Content/Theme/css/AdminLTE.css"
                ));

            
        }
    }
}

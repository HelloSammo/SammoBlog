using System.Web;
using System.Web.Optimization;

namespace Sammo.Blog.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //StyleBundle
            bundles.Add(new StyleBundle("~/bundles/Static/Css/Bootstrap").Include(

                        "~/Static/Css/Shared/Bootstrap/bootstrap.min.css",
                        //"~/Static/Css/Shared/Bootstrap/bootstrap-rtl.css",
                        "~/Static/Css/Shared/Bootstrap/animate.css",
                        "~/Static/Css/Shared/Bootstrap/font-awesome.css",
                        "~/Static/Css/Shared/Bootstrap/style.css"));

            bundles.Add(new StyleBundle("~/bundles/Static/Css/Shared/Plugin/icheck").Include(
                "~/Static/Css/Shared/Plugin/icheck/custom.css"));

            bundles.Add(new StyleBundle("~/bundles/Css/Admin/Layout").Include(
                "~/Static/Css/Shared/Bootstrap/bootstrap.min.css",
                "~/Static/Css/Shared/Bootstrap/font-awesome.css",
                "~/Static/Css/Shared/Plugins/morris/morris-0.4.3.min.css",
                "~/Static/Css/Shared/Plugins/gritter/jquery.gritter.css",
                "~/Static/Css/Shared/Bootstrap/animate.css",
                "~/Static/Css/Shared/Bootstrap/style.css"));

            //ScriptBundle
            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Jquery").Include(
                "~/Static/Js/Shared/Jquery/jquery-2.1.1.min.js",
                //"~/Static/Js/Shared/Jquery/jquery-ui.custom.min.js",
                //"~/Static/Js/Shared/Jquery/jquery-ui-1.10.4.min.js",
                ////"~/Static/Js/Shared/Jquery/hplus.js",
                "~/Static/Js/Shared/Jquery/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Shared/Plugin/icheck").Include(
                "~/Static/Js/Shared/Plugin/icheck/icheck.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/Js/Admin/Layout").Include(
                "~/Static/Js/Shared/Jquery/jquery-2.1.1.min.js",
                "~/Static/Js/Shared/Jquery/bootstrap.min.js",
                "~/Static/Js/Shared/Plugin/metisMenu/jquery.metisMenu.js",
                "~/Static/Js/Shared/Plugin/slimscroll/jquery.slimscroll.min.js",
                "~/Static/Js/Shared/Jquery/hplus.js",
                "~/Static/Js/Shared/Plugin/pace/pace.min.js"));


            
        }
    }
}

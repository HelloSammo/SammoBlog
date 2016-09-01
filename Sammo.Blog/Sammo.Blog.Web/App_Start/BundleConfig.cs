using System.Web;
using System.Web.Optimization;

namespace Sammo.Blog.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Admin/StyleBundle
            bundles.Add(new StyleBundle("~/bundles/Static/Css/Bootstrap").Include(

                        "~/Static/Css/Shared/Bootstrap/bootstrap.min.css",
                        "~/Static/Css/Shared/Bootstrap/animate.css",
                        "~/Static/Css/Shared/Bootstrap/font-awesome.css",
                        "~/Static/Css/Shared/Bootstrap/style.css"));

            bundles.Add(new StyleBundle("~/bundles/Static/Css/Bootstrap/Style").Include(
                "~/Static/Css/Shared/Bootstrap/animate.css",
                "~/Static/Css/Shared/Bootstrap/style.css"));

            bundles.Add(new StyleBundle("~/bundles/Static/Css/Admin/Layout").Include(
                "~/Static/Css/Shared/Bootstrap/bootstrap.min.css",
                "~/Static/Css/Shared/Bootstrap/font-awesome.css",
                "~/Static/Css/Shared/Plugins/morris/morris-0.4.3.min.css",
                "~/Static/Css/Shared/Plugins/gritter/jquery.gritter.css"));

            bundles.Add(new StyleBundle("~/bundles/Static/Css/Shared/Plugin/icheck").Include(
                "~/Static/Css/Shared/Plugins/icheck/custom.css"));

            bundles.Add(new StyleBundle("~/bundles/Static/Css/Shared/Plugin/summernote").Include(
                "~/Static/Css/Shared/Plugins/summernote/summernote.css",
                "~/Static/Css/Shared/Plugins/summernote/summernote-bs3.css"));

            bundles.Add(new StyleBundle("~/bundles/Static/Css/Shared/Plugin/toastr").Include(
                "~/Static/Css/Shared/Plugins/toastr/toastr.min.css"));

            //Portal/StyleBundle
            bundles.Add(new StyleBundle("~/bundles/Static/Css/Portal/Layout").Include(
                        "~/Static/Portal/CSS/Shared/bootstrap.min.css",
                        "~/Static/Portal/CSS/Shared/rewrite-bootstrap.css",
                        "~/Static/Css/Shared/Bootstrap/font-awesome.css",
                        "~/Static/Portal/CSS/Shared/style.css"));








            //Admin/ScriptBundle
            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Jquery").Include(
                "~/Static/Js/Shared/Jquery/jquery-2.1.1.min.js",
                "~/Static/Js/Shared/Jquery/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Vue").Include(
                "~/Static/Js/Shared/Vue/vue.js",
                "~/Static/Js/Shared/Vue/vue-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Shared/Plugin/icheck").Include(
                "~/Static/Js/Shared/Plugins/icheck/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Js/Admin/Layout").Include(
                "~/Static/Js/Shared/Jquery/jquery-2.1.1.min.js",
                "~/Static/Js/Shared/Jquery/bootstrap.min.js",
                "~/Static/Js/Shared/Plugins/metisMenu/jquery.metisMenu.js",
                "~/Static/Js/Shared/Plugins/slimscroll/jquery.slimscroll.min.js",
                "~/Static/Js/Shared/Jquery/hplus.js",
                "~/Static/Js/Shared/Plugins/pace/pace.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Shared/Plugin/summernote").Include(
                "~/Static/Js/Shared/Plugins/summernote/summernote.min.js",
                "~/Static/Js/Shared/Plugins/summernote/summernote-zh-CN.js"));

            bundles.Add(new ScriptBundle("~/bundles/Static/Js/Mark/category").Include(
                "~/Static/Js/Mark/category.js"));


            //Portal/ScriptBundle
            bundles.Add(new ScriptBundle("~/bundles/Js/Portal/Layout").Include(
               "~/Static/Js/Shared/Jquery/jquery.min.js",
               "~/Static/Js/Shared/Jquery/bootstrap.min.js",
               "~/Static/Js/Shared/base.js"));
        }
    }
}

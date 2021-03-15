using System.Web;
using System.Web.Optimization;

namespace SchoolAlumni
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/assets/vendor/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/assets/vendor/jquery.easing/jquery.easing.min.js",
                      "~/Content/assets/vendor/waypoints/jquery.waypoints.min.js",
                      "~/Content/assets/vendor/counterup/counterup.min.js",
                      "~/Content/assets/vendor/owl.carousel/owl.carousel.min.js",
                      "~/Content/assets/vendor/isotope-layout/isotope.pkgd.min.js",
                      "~/Content/assets/vendor/venobox/venobox.min.js",
                      "~/Content/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/assets/vendor/icofont/icofont.min.css",
                      "~/Content/assets/vendor/boxicons/css/boxicons.min.css",
                      "~/Content/assets/vendor/owl.carousel/assets/owl.carousel.min.css",
                      "~/Content/assets/vendor/venobox/venobox.css",
                      "~/Content/assets/css/style.css"));
        }
    }
}

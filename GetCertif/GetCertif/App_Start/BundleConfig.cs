using System.Web;
using System.Web.Optimization;

namespace GetCertif
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region templateIntegrateCss


            bundles.Add(new StyleBundle("~/templateIntegrateCss/Css").Include(
                     "~/Content/css/open-iconic-bootstrap.min.css",
                    "~/Content/css/animate.css",
                    "~/Content/css/owl.carousel.min.css",
                    "~/Content/css/owl.theme.default.min.css",
                    "~/Content/css/magnific-popup.css",
                    "~/Content/css/aos.css",
                     "~/Content/css/ionicons.min.css",
                     "~/Content/css/bootstrap-datepicker.css",
                     "~/Content/css/jquery.timepicker.css",
                     "~/Content/css/flaticon.css",
                    "~/Content/css/icomoon.css",
                    "~/Content/css/style.css"

                ));


            #endregion


            #region templateIntegrateJs
            bundles.Add(new ScriptBundle("~/templateIntegrate/Js").Include(
                    "~/Scripts/js/jquery.min.js",
                    "~/Scripts/js/jquery-migrate-3.0.1.min.js",
                    "~/Scripts/js/popper.min.js",
                    "~/Scripts/js/bootstrap.min.js",
                    "~/Scripts/js/jquery.easing.1.3.js",
                    "~/Scripts/js/jquery.waypoints.min.js",
                    "~/Scripts/js/jquery.stellar.min.js",
                    "~/Scripts/js/owl.carousel.min.js",
                    "~/Scripts/js/jquery.magnific-popup.min.js",
                    "~/Scripts/js/aos.js",
                    "~/Scripts/js/jquery.animateNumber.min.js",
                    "~/Scripts/js/scrollax.min.js",
                    "~/Scripts/js/google-map.js",
                    "~/Scripts/js/main.js"

                ));


            #endregion
        }
    }
}

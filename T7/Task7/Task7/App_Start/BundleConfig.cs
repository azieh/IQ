using System.Web;
using System.Web.Optimization;

namespace Task7
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/lib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/lib/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/lib/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/lib/knockout-3.5.0.js"));
            bundles.Add(new ScriptBundle("~/bundles/exchangeRate").Include(
                "~/Scripts/ExchangeRates/ExchangeRates.js"));
            bundles.Add(new ScriptBundle("~/bundles/exchangeRateVm").Include(
                "~/Scripts/ExchangeRates/ExchangeRateVm.js"));
            


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

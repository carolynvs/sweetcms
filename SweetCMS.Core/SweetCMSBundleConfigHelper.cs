using System.Web.Optimization;

namespace SweetCMS.Core
{
    public class SweetCMSBundles
    {
        public const string Scripts = "~/js";
        public const string Styles = "~/Styles/css";
    }

    public static class SweetCMSBundleConfigHelper
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var styles = new StyleBundle(SweetCMSBundles.Styles)
                .IncludeDirectory("~/Styles", "*.css", true);
            bundles.Add(styles);

            var scripts = new ScriptBundle(SweetCMSBundles.Scripts)
                .IncludeDirectory("~/Scripts/Common", "*.js", true);
            bundles.Add(scripts);
        }
    }
}
using System.Web.Optimization;
using SweetCMS.Core;

namespace SweetCMS
{
    public class Bundles : SweetCMSBundles
    {

    }

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            SweetCMSBundleConfigHelper.RegisterBundles(bundles);
        }
    }
}
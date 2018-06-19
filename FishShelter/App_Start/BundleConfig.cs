using System.Web;
using System.Web.Optimization;

namespace FishShelter
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //強制啟用打包及最佳化
            BundleTable.EnableOptimizations = true;
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/js/jquery.js",
                        "~/js/jquery-ui.min.js",
                        "~/js/bootstrap.min.js",
                        "~/js/ma5slider.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/style.css",
                      "~/font-awesome/css/font-awesome.min.css",
                      
                      "~/css/ma5slider.css"));

        }
    }
}

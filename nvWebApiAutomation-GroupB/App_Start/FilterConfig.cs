using System.Web;
using System.Web.Mvc;

namespace nvWebApiAutomation_GroupB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

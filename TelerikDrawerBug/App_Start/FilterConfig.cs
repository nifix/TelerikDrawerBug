using System.Web;
using System.Web.Mvc;

namespace TelerikDrawerBug
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

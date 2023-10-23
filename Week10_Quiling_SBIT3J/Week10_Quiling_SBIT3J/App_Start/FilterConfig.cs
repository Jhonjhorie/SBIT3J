using System.Web;
using System.Web.Mvc;

namespace Week10_Quiling_SBIT3J
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

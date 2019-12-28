using System.Web;
using System.Web.Mvc;

namespace Web_Api___Angular___Crud_Operation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

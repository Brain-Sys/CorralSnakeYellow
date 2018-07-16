using System.Web;
using System.Web.Mvc;

namespace Aula5.CorralSnakeYellow.OfficialWebsite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

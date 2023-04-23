using System.Web;
using System.Web.Mvc;

namespace Final_Project_SE_Webform
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}

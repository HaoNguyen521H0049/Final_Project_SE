using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Final_Project_SE_WebASPNET.Controllers
{
    public class AgentController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Authenticate(string username, string password)
		{
			if (IsValid(username, password))
			{
				FormsAuthentication.SetAuthCookie(username, false);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ModelState.AddModelError("", "Invalid username or password.");
				return View("Login");
			}
		}

		private bool IsValid(string username, string password)
		{
			SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
			conn.Open();
			string query = "SELECT * FROM Login_Management WHERE username = @un and password = @pw";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@un", username);
			cmd.Parameters.AddWithValue("@pw", password);
			
			object a = cmd.ExecuteScalar();
			conn.Close();
			if (a == null) 
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
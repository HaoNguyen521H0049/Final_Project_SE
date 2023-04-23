using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Final_Project_SE
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public static string strConn="";
		[STAThread]
		static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DB_Select());
		}
	}
}

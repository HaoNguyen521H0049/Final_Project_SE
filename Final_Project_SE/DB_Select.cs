using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace Final_Project_SE
{
	public partial class DB_Select : Form
	{
		public DB_Select()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Program.strConn = ConfigurationManager.ConnectionStrings["anotherConn"].ConnectionString;
			Thread f = new Thread(threadDB);
			f.SetApartmentState(ApartmentState.STA);
			f.Start();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Program.strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
			Thread f = new Thread(threadDB);
			f.SetApartmentState(ApartmentState.STA);
			f.Start();
			this.Close();
		}

		private void threadDB(object arg)
		{
			Application.Run(new frmLogin());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{

		}
	}
}

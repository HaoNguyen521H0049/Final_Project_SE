using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_SE
{
	public partial class FrmUpdateAgentRequest : Form
	{
		public FrmUpdateAgentRequest()
		{
			InitializeComponent();
		}

		private void FrmUpdateAgentRequest_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * FROM Export_Requests", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				DGV_Export_e.DataSource = dt;
			}
			else
			{
				MessageBox.Show("There is no export request at the moment","No Pending Request",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}

		private void loadGrid()
		{

		}
	}
}

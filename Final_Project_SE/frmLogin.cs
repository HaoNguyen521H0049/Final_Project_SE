using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project_SE
{
	
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM Login_Management WHERE username ='"+ tb_un.Text + "'",conn);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				
				adapter.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					for (int i =0;i<dt.Rows.Count;i++)
					{
						if (tb_un.Text == dt.Rows[i][0].ToString() && tb_pw.Text == dt.Rows[i][1].ToString())
						{
							if (dt.Rows[i][2].ToString() != "admin")
							{
								MessageBox.Show("You cannot logging in with agent account, please try again", "Unauthorized Role", MessageBoxButtons.OK, MessageBoxIcon.Stop);
							}
							else
							{
								Program.currentLoggin=tb_un.Text;
								conn.Close();
								Thread f = new Thread(btnLogin);
								f.SetApartmentState(ApartmentState.STA);
								f.Start();
								this.Close();
							}
						}
						else
						{
							MessageBox.Show("Incorrect Username or Password");
						}
					}
				}
				else 
				{
					MessageBox.Show("No Data");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btnLogin(object arg)
		{
			Application.Run(new frmMainControlPage());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

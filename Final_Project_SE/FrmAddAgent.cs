using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project_SE
{
	
	public partial class FrmAddAgent : Form
	{
		
		public FrmAddAgent()
		{
			InitializeComponent();
		}

		public event EventHandler closeFrm;

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (tbUn.Text=="" || tbPw.Text=="" || tbFn.Text=="" || tbLn.Text=="" || tbE.Text=="")
			{
				MessageBox.Show("Please Fill all the data", "Data input missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (checkIfUnExist())
			{
				MessageBox.Show("Username has already been used, please try another one", "Existed Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO Login_Management (username, password, role, Firstname, Lastname, Email) VALUES (@Username, @Password, @Role, @Firstname, @Lastname, @Email)", conn);
				cmd.Parameters.AddWithValue("@Username", tbUn.Text);
				cmd.Parameters.AddWithValue("@Password", tbPw.Text);
				cmd.Parameters.AddWithValue("@Role", cbR.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@Firstname", tbFn.Text);
				cmd.Parameters.AddWithValue("@Lastname", tbLn.Text);
				cmd.Parameters.AddWithValue("@Email", tbE.Text);
				cmd.ExecuteNonQuery();
				closeFrm?.Invoke(this, EventArgs.Empty);
				this.Close();
			}

			
		}

		private CancellationTokenSource delaying = new CancellationTokenSource();
		private const int DelayTime = 1500;

		private async void un_kp(object sender, KeyPressEventArgs e)
		{
			delaying.Cancel();
			delaying = new CancellationTokenSource();
			try
			{
				await Task.Delay(DelayTime, delaying.Token);
				checkIfUnExist();
			}
			catch (TaskCanceledException)
			{ }
		}

		private bool checkIfUnExist()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login_Management WHERE username = @un", conn);
			cmd.Parameters.AddWithValue("@un", tbUn.Text);
			try
			{
				conn.Open();
				int count = (int)cmd.ExecuteScalar();
				if (count > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				return true;
			}
			return false;
		}

		private void frmAddAgent_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT DISTINCT role FROM Login_Management", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					cbR.DisplayMember = "role";
					cbR.ValueMember = "role";
					cbR.DataSource = dt;
				}
			}
			else
			{
				MessageBox.Show("No Data");
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

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
	public partial class FrmAgentManagement : Form
	{
		public FrmAgentManagement()
		{
			InitializeComponent();
		}

		private void frmAddAgent_Load(object sender, EventArgs e)
		{
			showGrid();
		}

		private void showGrid()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT username, role, Firstname, Lastname, Email FROM Login_Management WHERE role = 'agent';", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				DGV_showAcc.DataSource = dt;
			}
			else
			{

			}
		}

		private void btnDelRow_Click(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = DGV_showAcc.SelectedRows[0];
			string username = selectedRow.Cells["username"].Value.ToString();
			string role = selectedRow.Cells["role"].Value.ToString();

			DGV_showAcc.Rows.Remove(selectedRow);

			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("DELETE FROM Login_Management WHERE username = @username AND role = @role", conn);
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@role", role);
			cmd.ExecuteNonQuery();
			conn.Close();
			showGrid();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FrmAddAgent f = new FrmAddAgent();
			f.closeFrm += updateTable;
			f.ShowDialog();
		}

		private void updateTable(object sender, EventArgs e)
		{
			showGrid();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			showGrid();
		}

		private void editCell(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex != 0) 
			{
				DataGridViewRow row = DGV_showAcc.Rows[e.RowIndex];
				row.Cells[0].ReadOnly= true;
				row.Cells[1].ReadOnly= true;
				string username = row.Cells[0].Value.ToString();
				string role = row.Cells[1].Value.ToString();
				string firstname = row.Cells[2].Value.ToString();
				string lastname = row.Cells[3].Value.ToString();
				string email = row.Cells[4].Value.ToString();

				SqlConnection conn = new SqlConnection(Program.strConn);
				string query = "UPDATE Login_Management SET firstname=@firstname, lastname=@lastname, email=@email WHERE username=@username";
				conn.Open();
				
				SqlCommand command = new SqlCommand(query, conn);
				command.Parameters.AddWithValue("@role", role);
				command.Parameters.AddWithValue("@firstname", firstname);
				command.Parameters.AddWithValue("@lastname", lastname);
				command.Parameters.AddWithValue("@email", email);
				command.Parameters.AddWithValue("@username", username);

				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				dataAdapter.UpdateCommand = command;
				dataAdapter.UpdateCommand.ExecuteNonQuery();
				conn.Close();
			}
			else
			{
				MessageBox.Show("Please select valid row","invalid row",MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}
		}
	}
}

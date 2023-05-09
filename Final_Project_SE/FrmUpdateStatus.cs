using System;
using System.Collections;
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
	public partial class FrmUpdateStatus : Form
	{
		public FrmUpdateStatus()
		{
			InitializeComponent();
		}

		private void FrmUpdateStatus_Load(object sender, EventArgs e)
		{
			LoadGrid();
		}

		private void LoadGrid()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * FROM Good_Delivery_Note", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			DGV_showdata.DataSource = dt;
			DGV_showdata.Rows[0].ReadOnly= true;
			DGV_showdata.Rows[1].ReadOnly = true;
			DGV_showdata.Rows[2].ReadOnly = true;
			DGV_showdata.Rows[3].ReadOnly = true;
			DGV_showdata.Rows[4].ReadOnly = true;
			DGV_showdata.Rows[5].ReadOnly = true;
			foreach (DataGridViewRow row in DGV_showdata.Rows)
			{
				DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells["IsPaid"];
				if (chkCell.Value != null && (bool)chkCell.Value)
				{
					row.ReadOnly = true;
				}
			}
		}

		private void CVC_isTick(object sender, DataGridViewCellEventArgs e)
		{
			if (DGV_showdata.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
			{
				DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)DGV_showdata.Rows[e.RowIndex].Cells[e.ColumnIndex];
				bool isChecked = (bool)cell.Value;
				
				string exportReceiptNo = DGV_showdata.Rows[e.RowIndex].Cells["exportReceiptNo"].Value.ToString();


				string query = "UPDATE Good_Delivery_Note SET IsPaid = @isPaid WHERE exportReceiptNo = @exportReceiptNo";
				SqlConnection conn = new SqlConnection(Program.strConn);
				SqlCommand cmd = new SqlCommand(query, conn);

				conn.Open();
				cmd.Parameters.AddWithValue("@isPaid", isChecked);
				cmd.Parameters.AddWithValue("@exportReceiptNo", exportReceiptNo);
				cmd.ExecuteNonQuery();
				LoadGrid();


			}
		}
	}
}

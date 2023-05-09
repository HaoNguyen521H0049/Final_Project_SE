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
	public partial class FrmIncomeOutcomeRep : Form
	{
		public FrmIncomeOutcomeRep()
		{
			InitializeComponent();
		}

		private bool checkIfEmptyCell(DataGridView DGV)
		{
			bool isAnyCellEmpty = false;
			foreach (DataGridViewCell cell in DGV.SelectedCells)
			{
				if (cell.Value == null || cell.Value == DBNull.Value || string.IsNullOrEmpty(cell.Value.ToString()))
				{
					isAnyCellEmpty = true;
					break;
				}
			}

			return isAnyCellEmpty;

		}

		private void cc_chooseCell(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void frmIncomeOutcomeRep_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * FROM Good_Delivery_Note", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			DGV_outcome_receipt.DataSource = dt;

			SqlCommand cmd1 = new SqlCommand("SELECT * FROM Good_Receiver", conn);
			SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
			DataTable dt1 = new DataTable();
			adapter1.Fill(dt1);
			DGV_income_receipt.DataSource = dt1;
		}

		private void cc_outcome_data(object sender, DataGridViewCellEventArgs e)
		{
			if (checkIfEmptyCell(DGV_outcome_receipt))
			{
				MessageBox.Show("Please choose a valid row", "Invalid selected row", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM Receipt_details WHERE OrderID = @ID", conn);
				cmd.Parameters.AddWithValue("@ID", DGV_outcome_receipt.SelectedRows[0].Cells["exportReceiptNo"].Value.ToString());
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				DGV_outcome_data.DataSource = dt;
			}
		}

		private void cc_income_data(object sender, DataGridViewCellEventArgs e)
		{
			if (checkIfEmptyCell(DGV_income_receipt))
			{
				MessageBox.Show("Please choose a valid row", "Invalid selected row", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM Import_details WHERE OrderID = @ID", conn);
				cmd.Parameters.AddWithValue("@ID", DGV_income_receipt.SelectedRows[0].Cells["receiptNo"].Value.ToString());
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				DGV_income_data.DataSource = dt;
			}
		}
	}
}

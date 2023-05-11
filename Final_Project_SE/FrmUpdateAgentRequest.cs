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
			SqlCommand cmd = new SqlCommand("SELECT DISTINCT requestID , request_date FROM Export_Requests", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				DGV_ARequest.DataSource = dt;
			}
			else
			{
				MessageBox.Show("There is no export request at the moment","No Pending Request",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}

			TB_ReceiverName_e.Enabled = false;
			TB_Reason_e.Enabled = false;
			TB_TargetStockName_e.Enabled = false;
			TB_TargetStockLocation_e.Enabled = false;
			TB_ReceiptNo_e.Enabled = false;
			btnCommit.Enabled = false;
		}

		private static int autoCount()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Good_delivery_note", conn);
			int rowCount = (int)countCommand.ExecuteScalar();

			if (rowCount == 0)
			{
				return 1;
			}
			else
			{
				SqlCommand maxCommand = new SqlCommand("SELECT MAX(exportReceiptNo) FROM Good_delivery_note", conn);
				int maxNumber = (int)maxCommand.ExecuteScalar();
				return maxNumber + 1;
			}

		}

		private void loadGrid()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT request_date, DISTINCT requestID FROM Export_Requests", conn);
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
				MessageBox.Show("There is no export request at the moment", "No Pending Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void CC_checkInfo(object sender, DataGridViewCellEventArgs e)
		{
			TB_ReceiptNo_e.Text = "" + autoCount();
			TB_ReceiptNo_e.Enabled = false;

			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT LM.Firstname, LM.Lastname, AID.exportFactory, AID.FactoryLocation FROM Login_Management LM JOIN Agent_Info_details AID ON LM.username = AID.username", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			TB_ReceiverName_e.Text = dt.Rows[0]["Firstname"].ToString() + " " + dt.Rows[0]["Lastname"].ToString();
			TB_Reason_e.Text = "Agent Request";
			TB_TargetStockName_e.Text = dt.Rows[0]["exportFactory"].ToString();
			TB_TargetStockLocation_e.Text = dt.Rows[0]["FactoryLocation"].ToString();

			TB_ReceiverName_e.Enabled = false;
			TB_Reason_e.Enabled = false;
			TB_TargetStockName_e.Enabled = false;
			TB_TargetStockLocation_e.Enabled = false;

			cmd = new SqlCommand("SELECT P.PID, P.PName, ER.Quantity, P.PPrice, (ER.Quantity * P.PPrice) AS total_Price FROM Product P JOIN Export_Requests ER ON P.PID = ER.PID", conn);
			adapter = new SqlDataAdapter(cmd);
			dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				DGV_Export_e.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No request data", "Request empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			cmd = new SqlCommand("SELECT P.PID, P.PName, P.PQuantity FROM Product P INNER JOIN Export_Requests ER ON P.PID = ER.PID ", conn);
			adapter = new SqlDataAdapter(cmd);
			dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				DGV_currentProduct.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No request data", "Request empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			btnCommit.Enabled = true;
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			bool flag = false;
			foreach (DataGridViewRow currentProduct in DGV_currentProduct.Rows)
			{
				string Ppid = currentProduct.Cells["PID"].Value.ToString();
				int Pquantity = Convert.ToInt32(currentProduct.Cells["PQuantity"].Value);

				foreach (DataGridViewRow Export_e in DGV_Export_e.Rows)
				{
					string Rpid = Export_e.Cells["PID"].Value.ToString();
					int quantity = Convert.ToInt32(Export_e.Cells["Quantity"].Value);

					if (Ppid == Rpid && Pquantity <= quantity)
					{
						currentProduct.Cells["PQuantity"].Style.BackColor = Color.Red;
						Export_e.Cells["Quantity"].Style.BackColor = Color.Yellow;
						flag = true;
						break;
					}
				}
			}

			if (flag)
			{
				MessageBox.Show("The Request product has greater unit than those in current stock","Not enough unit in stock",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DateTime dateCreated = dateTimePicker1.Value;
				string exportReceiptNo = TB_ReceiptNo_e.Text;
				string receiverName = TB_ReceiverName_e.Text;
				string issuingReason = TB_Reason_e.Text;
				string exportFactory = TB_TargetStockName_e.Text;
				string factoryLocation = TB_TargetStockLocation_e.Text;

				string insertGoodDeliveryNoteQuery = "INSERT INTO Good_Delivery_Note ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) " +
													 "VALUES (@DateCreated, @ExportReceiptNo, @ReceiverName, @IssuingReason, @ExportFactory, @FactoryLocation, @IsPaid)";

				SqlConnection conn = new SqlConnection(Program.strConn);
				
				conn.Open();
				SqlCommand cmd = new SqlCommand(insertGoodDeliveryNoteQuery, conn);
					
				cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
				cmd.Parameters.AddWithValue("@ExportReceiptNo", exportReceiptNo);
				cmd.Parameters.AddWithValue("@ReceiverName", receiverName);
				cmd.Parameters.AddWithValue("@IssuingReason", issuingReason);
				cmd.Parameters.AddWithValue("@ExportFactory", exportFactory);
				cmd.Parameters.AddWithValue("@FactoryLocation", factoryLocation);
				cmd.Parameters.AddWithValue("@IsPaid", false);

				cmd.ExecuteNonQuery();
					
				

				string insertReceiptDetailsQuery = "INSERT INTO Receipt_Details (OrderID, PID, Quantity, PPrice) " +
												   "SELECT @OrderID, Export_Requests.PID, Export_Requests.Quantity, Product.PPrice " +
												   "FROM Export_Requests " +
												   "INNER JOIN Product ON Export_Requests.PID = Product.PID " +
												   "WHERE Export_Requests.RequestID = @ExportReceiptNo";


				cmd = new SqlCommand(insertReceiptDetailsQuery, conn);
					
				cmd.Parameters.AddWithValue("@OrderID", exportReceiptNo);
				cmd.Parameters.AddWithValue("@ExportReceiptNo", exportReceiptNo);

				cmd.ExecuteNonQuery();

				MessageBox.Show("Successfully", "Success", MessageBoxButtons.OK);
			}

		}
	}
}

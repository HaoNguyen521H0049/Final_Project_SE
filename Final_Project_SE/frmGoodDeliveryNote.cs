using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project_SE
{
	public partial class frmGoodDeliveryNote : Form
	{
		public frmGoodDeliveryNote()
		{
			InitializeComponent();
		}

		bool isFunctionExecuted = false;

		public void reloadForm()
		{
			try
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT DISTINCT PName FROM Product", conn);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				conn.Close();
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						cb_selectGood_e.DisplayMember = "PName";
						cb_selectGood_e.ValueMember = "PName";
						cb_selectGood_e.DataSource = dt;
					}
				}
				else
				{
					MessageBox.Show("No Data");
				}
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
			
		}

		private void frmGoodDeliveryNote_Load(object sender, EventArgs e)
		{
			cb_receiver_e.Enabled = false;
			TB_ReceiverName_e.Enabled = false;
			TB_Reason_e.Enabled = false;
			TB_TargetStockName_e.Enabled = false;
			TB_TargetStockLocation_e.Enabled = false;

			cb_selectGood_e.Enabled = false;
			cb_color_e.Enabled = false;
			cb_memo_e.Enabled = false;
			tb_ProductQuantity_e.Enabled = false;
			btnAdd.Enabled = false;
			btnCommit.Enabled = false;
		}

		private void cb_selectGood_e_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT DISTINCT PColor FROM Product WHERE PName ='"+cb_selectGood_e.SelectedValue.ToString()+"'", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					cb_color_e.DisplayMember = "PColor";
					cb_color_e.ValueMember = "PColor";
					cb_color_e.DataSource = dt;
				}

			}
			else
			{
				MessageBox.Show("No Data");
			}
		}

		private void cb_memo_e_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT PQuantity FROM Product WHERE PMemory ='" + cb_memo_e.SelectedValue.ToString() + "' AND PColor ='" + cb_color_e.SelectedValue.ToString() + "' AND PName ='"+cb_selectGood_e.SelectedValue.ToString()+"'", conn);
			SqlDataReader sr = cmd.ExecuteReader();
			while(sr.Read())
			{
                tb_ProductQuantity_e.Text = sr.GetValue(0).ToString();
				if (sr.GetValue(0).Equals(0))
				{
					btnAdd.Enabled = false;
					btnAdd.BackColor= Color.Gray;
					btnAdd.ForeColor= Color.White;
					btnAdd.Text = "Out Of Stock";
				}
				else
				{
					btnAdd.Enabled = true;
					btnAdd.BackColor= Color.RoyalBlue;
					btnAdd.ForeColor = Color.White;
					btnAdd.Text = "Add";
				}
			}
			conn.Close();
			
	
		}

		private void cb_color_e_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT DISTINCT PMemory FROM Product WHERE PColor ='" + cb_color_e.SelectedValue.ToString() + "' AND PName ='"+cb_selectGood_e.SelectedValue.ToString()+"'", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					cb_memo_e.DisplayMember = "PMemory";
					cb_memo_e.ValueMember = "PMemory";
					cb_memo_e.DataSource = dt;
				}
			}
			else
			{
				MessageBox.Show("No Data");
			}
		}

		private bool IsReceiptNumberExist(int receiptNumber)
		{
			bool isExist = false;
			SqlConnection conn = new SqlConnection(Program.strConn);
			string query = "SELECT COUNT(*) FROM Good_Delivery_Note WHERE exportReceiptNo = @receiptNumber";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@receiptNumber", receiptNumber);
			try
			{
				conn.Open();
				int count = (int)cmd.ExecuteScalar();
				if (count > 0)
				{
					isExist = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return isExist;
		}



		private void btnAdd_Click(object sender, EventArgs e)
		{
			int PPrice=0;
			string PID = "";
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT PPrice FROM Product WHERE PMemory ='" + cb_memo_e.SelectedValue.ToString() + "' AND PColor ='" + cb_color_e.SelectedValue.ToString() + "' AND PName ='" + cb_selectGood_e.SelectedValue.ToString() + "'", conn);
			SqlCommand cmd1 = new SqlCommand("SELECT PID FROM Product WHERE PMemory ='" + cb_memo_e.SelectedValue.ToString() + "' AND PColor ='" + cb_color_e.SelectedValue.ToString() + "' AND PName ='" + cb_selectGood_e.SelectedValue.ToString() + "'", conn);
			
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
			DataTable dt1 = new DataTable();
			adapter1.Fill(dt1);

			
			PPrice = int.Parse(dt.Rows[0]["PPrice"].ToString());

			PID = dt1.Rows[0]["PID"].ToString();
			if (!isFunctionExecuted)
			{
				SqlCommand cmd2 = new SqlCommand("INSERT INTO [Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation]) " + "VALUES (@dateCreated, @exportReceiptNo, @ReceiverName, @issuingReason, @exportFactory, @FactoryLocation)", conn);
				cmd2.Parameters.AddWithValue("@dateCreated", dateTimePicker1.Value);
				cmd2.Parameters.AddWithValue("@exportReceiptNo", TB_ReceiptNo_e.Text);
				cmd2.Parameters.AddWithValue("@ReceiverName", TB_ReceiverName_e.Text);
				cmd2.Parameters.AddWithValue("@issuingReason", TB_Reason_e.Text);
				cmd2.Parameters.AddWithValue("@exportFactory", TB_TargetStockName_e.Text);
				cmd2.Parameters.AddWithValue("@FactoryLocation", TB_TargetStockLocation_e.Text);
				cmd2.ExecuteNonQuery();
				isFunctionExecuted= true;
			}

			SqlCommand cmd3 = new SqlCommand("INSERT INTO Receipt_details (OrderID, PID, Quantity, PPrice) values (@NO, @PID, @Quantity, @PPrice)", conn);
			cmd3.Parameters.Add(new SqlParameter("NO", int.Parse(TB_ReceiptNo_e.Text)));
			cmd3.Parameters.Add(new SqlParameter("PID", PID));
			cmd3.Parameters.Add(new SqlParameter("Quantity", int.Parse(tb_ProductQuantity_e.Text)));
			cmd3.Parameters.Add(new SqlParameter("PPrice", PPrice));
			int rowsAff1 = cmd3.ExecuteNonQuery();
			if (rowsAff1 > 0)
			{
				MessageBox.Show("Add sucessfully");
			}
			else
			{
				MessageBox.Show("Add Failed");
			}
			conn.Close();
			showGrid();
		}

		private void showGrid()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT Product.PName, Receipt_details.Quantity, Product.PPrice FROM Product INNER JOIN Receipt_details ON Product.PID = Receipt_details.PID WHERE Receipt_details.OrderID = "+int.Parse(TB_ReceiptNo_e.Text) +";", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				DGV_Export_e.DataSource= dt;
			}
			else
			{
				
			}
			adapter.Dispose();

			SqlCommand command = new SqlCommand("SELECT SUM(Quantity * PPrice) AS TotalMoney FROM Receipt_details  where OrderId = @OID GROUP BY OrderID", conn);
			command.Parameters.Add(new SqlParameter("OID", int.Parse(TB_ReceiptNo_e.Text)));
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
		}

		private async void tb_RNo_Change(object sender, KeyEventArgs e)
		{
			int delayTime = 2000;
			await Task.Delay(delayTime);
			if (TB_ReceiptNo_e.Text == "")
			{
				cb_receiver_e.Enabled = false;
				TB_ReceiverName_e.Enabled = false;
				TB_Reason_e.Enabled = false;
				TB_TargetStockName_e.Enabled = false;
				TB_TargetStockLocation_e.Enabled = false;

				cb_selectGood_e.Enabled = false;
				cb_color_e.Enabled = false;
				cb_memo_e.Enabled = false;
				tb_ProductQuantity_e.Enabled = false;
				btnAdd.Enabled = false;
				btnCommit.Enabled = false;
				DGV_Export_e.DataSource = null;
				dataGridView1.DataSource = null;
				isFunctionExecuted = false;
			}
			else
			{
				if (IsReceiptNumberExist(int.Parse(TB_ReceiptNo_e.Text)))
				{
					MessageBox.Show("The receipt number is already existed");
					cb_receiver_e.Enabled = false;
					TB_ReceiverName_e.Enabled = false;
					TB_Reason_e.Enabled = false;
					TB_TargetStockName_e.Enabled = false;
					TB_TargetStockLocation_e.Enabled = false;

					cb_selectGood_e.Enabled = false;
					cb_color_e.Enabled = false;
					cb_memo_e.Enabled = false;
					tb_ProductQuantity_e.Enabled = false;
					btnAdd.Enabled = false;
					btnCommit.Enabled = false;
					DGV_Export_e.DataSource = null;
					dataGridView1.DataSource = null;
					isFunctionExecuted = false;
					
				}
				else
				{
					cb_receiver_e.Enabled = true;
					TB_ReceiverName_e.Enabled = true;
					TB_Reason_e.Enabled = true;
					TB_TargetStockName_e.Enabled = true;
					TB_TargetStockLocation_e.Enabled = true;

					cb_selectGood_e.Enabled = true;
					cb_color_e.Enabled = true;
					cb_memo_e.Enabled = true;
					tb_ProductQuantity_e.Enabled = true;
					btnAdd.Enabled = true;
					btnCommit.Enabled = true;

					reloadForm();
				}
			}
		}
	}
}

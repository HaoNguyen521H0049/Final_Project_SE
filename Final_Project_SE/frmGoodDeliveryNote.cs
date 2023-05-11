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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Security.Cryptography;

namespace Final_Project_SE
{
	public partial class FrmGoodDeliveryNote : Form
	{
		public FrmGoodDeliveryNote()
		{
			InitializeComponent();
		}

		bool isFunctionExecuted = false;
		bool isTempTableExist = false;

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

				SqlCommand cmd1 = new SqlCommand("select distinct receiverName from Good_Delivery_Note", conn);
				SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adapter1.Fill(dt1);


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


				if (dt1.Rows.Count > 0)
				{
					
					for (int i = 0; i < dt1.Rows.Count; i++)
					{
						cb_receiver_e.DisplayMember = "receiverName";
						cb_receiver_e.ValueMember = "receiverName";
						cb_receiver_e.DataSource = dt1;
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
			TB_ReceiptNo_e.Text = ""+ autoCount();
			TB_ReceiptNo_e.Enabled = false;
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
			if (true)
			{
				if (!isFunctionExecuted)
				{
					DataTable schema = conn.GetSchema("Tables");
					bool exists = schema.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_receipt_info");
					if (exists)
					{
						SqlCommand deleteTable = new SqlCommand("Drop Table temp_receipt_info", conn);
						deleteTable.ExecuteNonQuery();
					}

					SqlCommand createTempReceipt = new SqlCommand("CREATE TABLE temp_receipt_info (dateCreated date, exportReceiptNo int, ReceiverName nvarchar(50), issuingReason nvarchar(50), exportFactory nvarchar(50), FactoryLocation nvarchar(50), IsPaid BIT);", conn);
					createTempReceipt.ExecuteNonQuery();
					SqlCommand cmd2 = new SqlCommand("INSERT INTO temp_receipt_info (dateCreated, exportReceiptNo, ReceiverName, issuingReason, exportFactory, FactoryLocation, IsPaid) " + "VALUES (@dateCreated, @exportReceiptNo, @ReceiverName, @issuingReason, @exportFactory, @FactoryLocation, 0)", conn);
					cmd2.Parameters.AddWithValue("@dateCreated", dateTimePicker1.Value);
					cmd2.Parameters.AddWithValue("@exportReceiptNo", TB_ReceiptNo_e.Text);
					if (checkIfNew.Checked)
					{
						cmd2.Parameters.AddWithValue("@ReceiverName", TB_ReceiverName_e.Text);
					}
					else
					{
						cmd2.Parameters.AddWithValue("@ReceiverName", cb_receiver_e.SelectedValue.ToString());
					}
					cmd2.Parameters.AddWithValue("@issuingReason", TB_Reason_e.Text);
					cmd2.Parameters.AddWithValue("@exportFactory", TB_TargetStockName_e.Text);
					cmd2.Parameters.AddWithValue("@FactoryLocation", TB_TargetStockLocation_e.Text);
					cmd2.ExecuteNonQuery();
					isFunctionExecuted = true;
					isTempTableExist = true;

					DataTable schemas = conn.GetSchema("Tables");
					bool exist = schemas.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_Receipt_data");
					if (exist)
					{
						SqlCommand deleteTables = new SqlCommand("Drop Table temp_Receipt_data", conn);
						deleteTables.ExecuteNonQuery();
					}

					SqlCommand createTempReceiptData = new SqlCommand("CREATE TABLE temp_Receipt_data (OrderID int NOT NULL,PID nvarchar(20) NULL,Quantity int NULL,PPrice int);", conn);
					createTempReceiptData.ExecuteNonQuery();
				}

				

				SqlCommand cmd3 = new SqlCommand("MERGE temp_Receipt_data AS target\r\nUSING (SELECT @NO AS OrderID, @PID AS PID, @Quantity AS Quantity, @PPrice AS PPrice) AS source\r\nON (target.PID = source.PID)\r\nWHEN MATCHED THEN\r\n    UPDATE SET target.Quantity = target.Quantity + source.Quantity\r\nWHEN NOT MATCHED THEN\r\n    INSERT (OrderID, PID, Quantity, PPrice)\r\n    VALUES (source.OrderID, source.PID, source.Quantity, source.PPrice);", conn);
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
		}

		private void showGrid()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT Product.PID, Product.PName, temp_Receipt_data.Quantity, Product.PPrice, temp_Receipt_data.Quantity * Product.PPrice as TotalPrice FROM Product INNER JOIN temp_Receipt_data ON Product.PID = temp_Receipt_data.PID WHERE temp_Receipt_data.OrderID = " + int.Parse(TB_ReceiptNo_e.Text) +";", conn);
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
			DGV_Export_e.Columns[0].ReadOnly = true; 
			DGV_Export_e.Columns[1].ReadOnly = true;
			DGV_Export_e.Columns[2].ReadOnly = false;
			DGV_Export_e.Columns[3].ReadOnly = true; 
			DGV_Export_e.Columns[4].ReadOnly = true; 

			SqlCommand command = new SqlCommand("SELECT SUM(Quantity * PPrice) AS TotalMoney FROM temp_Receipt_data  where OrderId = @OID GROUP BY OrderID", conn);
			command.Parameters.Add(new SqlParameter("OID", int.Parse(TB_ReceiptNo_e.Text)));
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
		}

		private void disableAll()
		{
			checkIfNew.Enabled = false; checkIfNew.Checked = false;
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

		private void enableAll()
		{
			checkIfNew.Enabled = true;
			cb_receiver_e.Enabled = true;
			TB_ReceiverName_e.Enabled = false;
			TB_Reason_e.Enabled = true;
			TB_TargetStockName_e.Enabled = true;
			TB_TargetStockLocation_e.Enabled = true;

			cb_selectGood_e.Enabled = true;
			cb_color_e.Enabled = true;
			cb_memo_e.Enabled = true;
			tb_ProductQuantity_e.Enabled = true;
			btnAdd.Enabled = true;
			btnCommit.Enabled = true;
		}

		private bool isErrorShown = false;
		private CancellationTokenSource delaying = new CancellationTokenSource();
		private const int DelayTime = 1500; 
		private async void tb_RNo_Change(object sender, KeyEventArgs e)
		{
			delaying.Cancel();
			delaying = new CancellationTokenSource();

			try
			{
				await Task.Delay(DelayTime, delaying.Token);
				int checkIsNum;
				
				if (TB_ReceiptNo_e.Text == "")
				{
					disableAll();
					isErrorShown = false;
				}
				else if (!(int.TryParse(TB_ReceiptNo_e.Text, out checkIsNum)))
				{
					if (isErrorShown == false)
						MessageBox.Show("Please enter numbers only! non-numerical is not allowed");
					disableAll();
					isErrorShown = true;
				}
				else if (int.Parse(TB_ReceiptNo_e.Text) > 999999)
				{
					if (isErrorShown == false)
						MessageBox.Show("The Receipt number is too large, please re-enter with number that is smaller than 999999 and usable");
					disableAll();
					isErrorShown = true;
				}
				else
				{
					if (IsReceiptNumberExist(int.Parse(TB_ReceiptNo_e.Text)))
					{
						if (isErrorShown == false)
							MessageBox.Show("The receipt number is already existed");
						disableAll();
						isErrorShown = true;
					}
					else
					{
						enableAll();
						isErrorShown = false;

						reloadForm();
					}
				}
			}
			catch (TaskCanceledException)
			{ }
		}

		private void checkIfNew_CheckedChanged(object sender, EventArgs e)
		{
			if (checkIfNew.Checked) 
			{
				TB_ReceiverName_e.Enabled = true;
				cb_receiver_e.Enabled = false;
				
			}
			else
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				TB_ReceiverName_e.Enabled = false;
				TB_ReceiverName_e.Text = string.Empty;
				cb_receiver_e.Enabled = true;
				SqlCommand cmd1 = new SqlCommand("select distinct receiverName from Good_Delivery_Note", conn);
				SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adapter1.Fill(dt1);
				conn.Close();
				if (dt1.Rows.Count > 0)
				{

					for (int i = 0; i < dt1.Rows.Count; i++)
					{
						cb_receiver_e.DisplayMember = "receiverName";
						cb_receiver_e.ValueMember = "receiverName";
						cb_receiver_e.DataSource = dt1;
					}
				}
				else
				{
					MessageBox.Show("No Data");
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to cancel this receipt?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
	
			if (result == DialogResult.Yes)
			{
				if (isTempTableExist == false)
				{
					this.Close();
				}
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				DataTable schema1 = conn.GetSchema("Tables");
				bool exist1 = schema1.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_receipt_info");
				if (exist1)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table temp_receipt_info", conn);
					deleteTables.ExecuteNonQuery();
				}
				DataTable schema2 = conn.GetSchema("Tables");
				bool exist2 = schema2.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_Receipt_data");
				if (exist2)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table temp_Receipt_data", conn);
					deleteTables.ExecuteNonQuery();
				}
				
				btnCancel.Enabled= false;
				this.Close();
			}
			else
			{

			}
			
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			if (isTempTableExist)
			{
				int success = 0;
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd1 = new SqlCommand("insert into Receipt_details select * from temp_Receipt_data", conn);
				SqlCommand cmd2 = new SqlCommand("insert into Good_Delivery_Note select * from temp_receipt_info", conn);

				
				int add_receipt = cmd2.ExecuteNonQuery();
				if (add_receipt > 0) { success+= 1; }
				else				 { success+= 0; }

				int add_data = cmd1.ExecuteNonQuery();
				if (add_data > 0) {	success += 1;	}
				else			  { success += 0;	}


				if (success == 2) 
				{
					
					SqlCommand cmd = new SqlCommand("DROP TABLE temp_receipt_info;DROP TABLE temp_Receipt_data;", conn);
					SqlCommand cmdMinus = new SqlCommand("MERGE Product AS p\r\nUSING temp_Receipt_data AS trd\r\nON p.PID = trd.PID\r\nWHEN MATCHED THEN\r\n    UPDATE SET p.PQuantity = p.PQuantity - trd.Quantity;", conn);

					cmdMinus.ExecuteNonQuery();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Successfully", "finished");
					this.Close();
					FrmGoodDeliveryNote f = new FrmGoodDeliveryNote();
					f.Show();
				}
				else
				{
					MessageBox.Show("Failed, please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Cannot commit empty data! please fill in!", "Insufficient data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void tb_ProductQuantity_e_TextChanged(object sender, EventArgs e)
		{
			delaying.Cancel();
			delaying = new CancellationTokenSource();

			try
			{
				await Task.Delay(DelayTime, delaying.Token);
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT PQuantity FROM Product WHERE PMemory ='" + cb_memo_e.SelectedValue.ToString() + "' AND PColor ='" + cb_color_e.SelectedValue.ToString() + "' AND PName ='" + cb_selectGood_e.SelectedValue.ToString() + "'", conn);
				SqlDataReader sr = cmd.ExecuteReader();
				while (sr.Read())
				{
					int quanti = int.Parse(sr.GetValue(0).ToString());
					int inputValue = int.Parse(tb_ProductQuantity_e.Text);
					if (inputValue>quanti || inputValue<0)
					{
						MessageBox.Show("the value you enter is " + inputValue + " Which is greater than current quantitiy: " + quanti, "Input is invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						string toValid = "" + quanti;
						tb_ProductQuantity_e.Text = toValid;
					}
					else 
					{
						
					}
				}
				conn.Close();
			}
			catch (TaskCanceledException)
			{
				
			}
		}

		private void TB_Quant_KP(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
			{
				e.Handled = true;
			}
			if (tb_ProductQuantity_e.Text=="")
			{
				tb_ProductQuantity_e.Text = "0";
			}
		}

		private void btnDelRow_Click(object sender, EventArgs e)
		{
			if (DGV_Export_e.SelectedRows.Count > 0 && !DGV_Export_e.IsCurrentRowDirty) 
			{
				DialogResult r = MessageBox.Show("You want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (r == DialogResult.Yes)
				{
					DataGridViewRow selectedRow = DGV_Export_e.SelectedRows[0];
					string pid = selectedRow.Cells["PID"].Value.ToString();
					int pquantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
					int pprice = Convert.ToInt32(selectedRow.Cells["PPrice"].Value);
					SqlConnection conn = new SqlConnection(Program.strConn);
					conn.Open();
					SqlCommand deleteRow = new SqlCommand("DELETE FROM temp_Receipt_data WHERE PID = '" + pid + "' AND Quantity = " + pquantity + " AND PPrice = " + pprice, conn);
					deleteRow.ExecuteNonQuery();
					conn.Close();
					showGrid();
				}
			}
			else
			{
				MessageBox.Show("Please select a row to delete","Error");
			}
		}

		private async void DGV_Quan_Change(object sender, DataGridViewCellEventArgs e)
		{
			
			delaying.Cancel();
			delaying = new CancellationTokenSource();

			try
			{
				await Task.Delay(DelayTime, delaying.Token);


				if (e.RowIndex >= 0 && e.ColumnIndex == DGV_Export_e.Columns["Quantity"].Index)
				{
					DataGridViewRow row = DGV_Export_e.Rows[e.RowIndex];
					string pid = row.Cells["PID"].Value.ToString();
					int newQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

					bool isNum = int.TryParse(row.Cells["Quantity"].Value.ToString(), out int output);

					if (isNum)
					{
						SqlConnection conn = new SqlConnection(Program.strConn);
						conn.Open();
						SqlCommand changeQuan = new SqlCommand("UPDATE temp_Receipt_data SET Quantity = " + newQuantity + " WHERE PID = '" + pid +"'", conn);
						changeQuan.ExecuteNonQuery();

						showGrid();
					}
					else
					{
						MessageBox.Show("Please enter a number, not non-numerical", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				
				
			}
			catch (TaskCanceledException)
			{

			}
		}
	}
}

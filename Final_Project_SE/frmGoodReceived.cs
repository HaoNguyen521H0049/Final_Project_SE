using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Final_Project_SE
{
	public partial class FrmGoodReceived : Form
	{
		public FrmGoodReceived()
		{
			InitializeComponent();
		}

		private CancellationTokenSource delaying = new CancellationTokenSource();
		private const int DelayTime = 1500;
		bool isTempTableExist = false;
		private bool isErrorShown = false;
		bool isFunctionExecuted = false;

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to cancel this receipt?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				if (isTempTableExist == false)
				{
					this.Close();
				}

				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();

				DataTable schema1 = conn.GetSchema("Tables");
				bool exist1 = schema1.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "newTempProduct");
				if (exist1)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table newTempProduct", conn);
					deleteTables.ExecuteNonQuery();
				}
				DataTable schema2 = conn.GetSchema("Tables");
				bool exist2 = schema2.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_Import_data");
				if (exist2)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table temp_Import_data", conn);
					deleteTables.ExecuteNonQuery();
				}
				DataTable schema3 = conn.GetSchema("Tables");
				bool exist3 = schema3.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_Import_info");
				if (exist3)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table temp_Import_info", conn);
					deleteTables.ExecuteNonQuery();
				}
				btnCancel.Enabled = false;
				this.Close();
			}
			else
			{

			}
		}

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

				SqlCommand cmd1 = new SqlCommand("select distinct DeliverName from Good_Receiver", conn);
				SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adapter1.Fill(dt1);


				conn.Close();
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						cb_selectGood_i.DisplayMember = "PName";
						cb_selectGood_i.ValueMember = "PName";
						cb_selectGood_i.DataSource = dt;
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
						cb_receiver_i.DisplayMember = "DeliverName";
						cb_receiver_i.ValueMember = "DeliverName";
						cb_receiver_i.DataSource = dt1;
					}


				}
				else
				{
					MessageBox.Show("No Data");
				}


			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }

		}

		private bool IsReceiptNumberExist(int receiptNumber)
		{
			bool isExist = false;
			SqlConnection conn = new SqlConnection(Program.strConn);
			string query = "SELECT COUNT(*) FROM Good_Receiver WHERE receiptNo = @receiptNumber";
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

		private void disableAll()
		{
			cb_receiver_i.Enabled = false;
			checkIfNew.Enabled = false;
			TB_ReceiverName_i.Enabled = false;
			TB_AccordingToReceiptNo_i.Enabled = false;
			dateTimePicker2.Enabled = false;
			TB_AccordingToReceiptComp_Name_i.Enabled = false;
			TB_TargetStockName_i.Enabled = false;
			TB_TargetStockLocation_i.Enabled = false;

			Check_neverExist.Enabled = false;
			cb_selectGood_i.Enabled = false;
			tb_addProduct_i.Enabled = false;
			tb_ProductID_i.Enabled = false;
			tb_ProductQuantity_i.Enabled = false;
			tb_ProductColor.Enabled = false;
			tb_ProductMemo.Enabled = false;
			tb_Price_i.Enabled = false;
			btnAdd.Enabled = false;
			cb_color_i.Enabled=false;
			cb_memo_i.Enabled= false;
			tb_Price_i_old.Enabled = false;
			tb_Quant_i_old.Enabled=false;
		}

		private void enableAll()
		{
			cb_receiver_i.Enabled = true;
			checkIfNew.Enabled = true;
			TB_ReceiverName_i.Enabled = false;
			TB_AccordingToReceiptNo_i.Enabled = true;
			dateTimePicker2.Enabled = true;
			TB_AccordingToReceiptComp_Name_i.Enabled = true;
			TB_TargetStockName_i.Enabled = true;
			TB_TargetStockLocation_i.Enabled = true;

			Check_neverExist.Enabled = true;
			cb_selectGood_i.Enabled = true;
			tb_addProduct_i.Enabled = false;
			tb_ProductID_i.Enabled = false;
			tb_ProductQuantity_i.Enabled = false;
			tb_ProductColor.Enabled = false;
			tb_ProductMemo.Enabled = false;
			tb_Price_i.Enabled = false;
			tb_Quant_i_old.Enabled=true;
			cb_memo_i.Enabled= true;
			tb_Price_i_old.Enabled = false;
			cb_color_i.Enabled=true;
			btnAdd.Enabled = false;
		}

		private void showGrid()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT ntp.PID, ntp.PName, ntp.PPrice AS PricePerUnit, tid.Quantity, (ntp.PPrice * tid.Quantity) AS TotalPrice FROM newTempProduct ntp JOIN temp_Import_data tid ON ntp.PID = tid.PID WHERE tid.OrderID = @OrderID", conn);
			cmd.Parameters.AddWithValue("@OrderID", int.Parse(TB_ReceiptNo_i.Text));
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				DGV_Receipt_i.DataSource = dt;
			}
			else
			{
				DGV_Receipt_i.DataSource = null;
			}
			adapter.Dispose();
			DGV_Receipt_i.Refresh();

			SqlCommand command = new SqlCommand("SELECT SUM(Quantity * PPrice) AS TotalMoney FROM temp_Import_data  where OrderId = @OID GROUP BY OrderID", conn);
			command.Parameters.Add(new SqlParameter("OID", int.Parse(TB_ReceiptNo_i.Text)));
			SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
		}

		private void frmGoodReceived_Load(object sender, EventArgs e)
		{
			disableAll();
		}

		private async void TB_ReceiptNo_i_TextChanged(object sender, EventArgs e)
		{
			delaying.Cancel();
			delaying = new CancellationTokenSource();

			try
			{
				await Task.Delay(DelayTime, delaying.Token);
				int checkIsNum;

				if (TB_ReceiptNo_i.Text == "")
				{
					disableAll();
					isErrorShown = false;
				}
				else if (!(int.TryParse(TB_ReceiptNo_i.Text, out checkIsNum)))
				{
					if (isErrorShown == false)
						MessageBox.Show("Please enter numbers only! non-numerical is not allowed");
					disableAll();
					isErrorShown = true;
				}
				else if (int.Parse(TB_ReceiptNo_i.Text) > 999999)
				{
					if (isErrorShown == false)
						MessageBox.Show("The Receipt number is too large, please re-enter with number that is smaller than 999999 and usable");
					disableAll();
					isErrorShown = true;
				}
				else
				{
					if (IsReceiptNumberExist(int.Parse(TB_ReceiptNo_i.Text)))
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

		private void tb_RNo_KP(object sender, KeyPressEventArgs e)
		{
		
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
			if (TB_ReceiptNo_i.Text == "")
			{
					
			}

			
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			if (!isFunctionExecuted)
			{
				DataTable schema1 = conn.GetSchema("Tables");
				bool exist1 = schema1.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_Import_info");
				if (exist1)
				{
					SqlCommand deleteTable = new SqlCommand("Drop Table temp_Import_info", conn);
					deleteTable.ExecuteNonQuery();
				}

				SqlCommand createTempReceipt = new SqlCommand("CREATE TABLE [dbo].[temp_Import_info]([dateCreated] [date] NULL, [receiptNo] [int] NOT NULL, [DeliverName] [nvarchar](50) NULL, [ExportReceiptNo] [int] NULL, [ExportDMY] [date] NULL, [ExportCompanyName] [nvarchar](50) NULL, [exportFactory] [nvarchar](50) NULL, [FactoryLocation] [nvarchar](50) NULL)", conn);
				createTempReceipt.ExecuteNonQuery();
				isTempTableExist = true;
				SqlCommand cmd2 = new SqlCommand("INSERT INTO temp_Import_info (dateCreated, receiptNo, DeliverName, ExportReceiptNo, ExportDMY, ExportCompanyName, exportFactory, FactoryLocation) VALUES (@dateCreated, @receiptNo, @DeliverName, @ExportReceiptNo, @ExportDMY, @ExportCompanyName, @exportFactory, @FactoryLocation)", conn);

				cmd2.Parameters.AddWithValue("@dateCreated", dateTimePicker1.Value);
				cmd2.Parameters.AddWithValue("@receiptNo", int.Parse(TB_ReceiptNo_i.Text));

				if (checkIfNew.Checked)
				{
					cmd2.Parameters.AddWithValue("@DeliverName", TB_ReceiverName_i.Text);
				}
				else
				{
					cmd2.Parameters.AddWithValue("@DeliverName", cb_receiver_i.SelectedValue.ToString());
				}
				
				cmd2.Parameters.AddWithValue("@ExportReceiptNo", int.Parse(TB_AccordingToReceiptNo_i.Text));
				cmd2.Parameters.AddWithValue("@ExportDMY", dateTimePicker2.Value);
				cmd2.Parameters.AddWithValue("@ExportCompanyName", TB_AccordingToReceiptComp_Name_i.Text);
				cmd2.Parameters.AddWithValue("@exportFactory", TB_TargetStockName_i.Text);
				cmd2.Parameters.AddWithValue("@FactoryLocation", TB_TargetStockLocation_i.Text);
				cmd2.ExecuteNonQuery();
				isFunctionExecuted = true;
				isTempTableExist = true;

				DataTable schema2 = conn.GetSchema("Tables");
				bool exist2 = schema2.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "temp_Import_data");
				if (exist2)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table temp_Import_data", conn);
					deleteTables.ExecuteNonQuery();
				}

				SqlCommand createTempReceiptData = new SqlCommand("CREATE TABLE [dbo].[temp_Import_data]( [OrderID] [int] NOT NULL, [PID] [nvarchar](20) NULL, [Quantity] [int] NULL, [PPrice] [int]);", conn);
				createTempReceiptData.ExecuteNonQuery();
				isTempTableExist = true;

				DataTable schema3 = conn.GetSchema("Tables");
				bool exist3 = schema3.Rows.OfType<DataRow>().Any(row => row["TABLE_NAME"].ToString() == "newTempProduct");
				if (exist3)
				{
					SqlCommand deleteTables = new SqlCommand("Drop Table newTempProduct", conn);
					deleteTables.ExecuteNonQuery();
				}
				SqlCommand addNewProduct = new SqlCommand("CREATE TABLE [dbo].[newTempProduct]([PID] [nvarchar](20) NOT NULL, [PName] [nvarchar](50) NULL, [PMemory] [nvarchar](10) NULL, [PColor] [nvarchar](20) NULL, [PQuantity] [int] NULL, [PPrice] [int] NULL)", conn);
				addNewProduct.ExecuteNonQuery();

				isTempTableExist = true;
			}

			

			string Pname = "";
			string PID = "";
			int Quant  = 0;
			string Color = "";
			string Memo = "";
			int Price = 0;


			if (Check_neverExist.Checked)	
			{
				Pname = tb_addProduct_i.Text;
				PID = tb_ProductID_i.Text;
				Quant = Convert.ToInt32(tb_ProductQuantity_i.Text);
				Color = tb_ProductColor.Text;
				Memo = tb_ProductMemo.Text;
				Price = Convert.ToInt32(tb_Price_i.Text);
			}
			else
			{
				
				Pname = cb_selectGood_i.SelectedValue.ToString();
				Color = cb_color_i.SelectedValue.ToString();
				Memo = cb_memo_i.SelectedValue.ToString();
				Price = Convert.ToInt32(tb_Price_i_old.Text);
				Quant = Convert.ToInt32(tb_Quant_i_old.Text);
				SqlCommand getPID = new SqlCommand("SELECT PID FROM Product WHERE PName = @PN AND PColor = @PC AND PMemory = @PM", conn);
				getPID.Parameters.AddWithValue("@PN", Pname);
				getPID.Parameters.AddWithValue("@PC", Color);
				getPID.Parameters.AddWithValue("@PM", Memo);
				object result = getPID.ExecuteScalar();
				PID = result.ToString();
			}

			SqlCommand addToNTP = new SqlCommand("MERGE newTempProduct AS target USING (SELECT @PID AS PID, @PName AS PName, @PMemory AS PMemory, @PColor AS PColor, @PPrice AS PPrice, @PQuantity AS PQuantity) AS source ON (target.PID = source.PID) WHEN MATCHED THEN UPDATE SET target.PName = source.PName, target.PMemory = source.PMemory, target.PColor = source.PColor, target.PPrice = source.PPrice WHEN NOT MATCHED THEN INSERT (PID, PName, PMemory, PColor, PPrice, PQuantity) VALUES (source.PID, source.PName, source.PMemory, source.PColor, source.PPrice, source.PQuantity);", conn);
			addToNTP.Parameters.AddWithValue("@PID", PID);
			addToNTP.Parameters.AddWithValue("@PName", Pname);
			addToNTP.Parameters.AddWithValue("@PMemory", Memo);
			addToNTP.Parameters.AddWithValue("@PColor", Color);
			addToNTP.Parameters.AddWithValue("@PPrice", Price);
			addToNTP.Parameters.AddWithValue("@PQuantity", Quant);

			addToNTP.ExecuteNonQuery();


			SqlCommand cmd3 = new SqlCommand("MERGE temp_Import_data AS target USING (SELECT @OrderID AS OrderID, @PID AS PID, @Quantity AS Quantity, @PPrice AS PPrice) AS source ON (target.PID = source.PID AND target.OrderID = source.OrderID) WHEN MATCHED THEN  UPDATE SET target.Quantity = target.Quantity + source.Quantity, target.PPrice = source.PPrice WHEN NOT MATCHED THEN INSERT (OrderID, PID, Quantity, PPrice) VALUES (source.OrderID, source.PID, source.Quantity, source.PPrice);", conn);
			
			cmd3.Parameters.AddWithValue("@OrderID", Convert.ToInt32(TB_ReceiptNo_i.Text));
			cmd3.Parameters.AddWithValue("@PID", PID);
			cmd3.Parameters.AddWithValue("@Quantity", Quant);
			cmd3.Parameters.AddWithValue("@PPrice", Price);

			cmd3.ExecuteNonQuery();


			showGrid();
		}

		private void enaBtnAdd()
		{
			if ((TB_ReceiverName_i.ToString() == "" && cb_receiver_i.SelectedValue.ToString() == null) ||
				TB_AccordingToReceiptNo_i.Text=="" || TB_AccordingToReceiptComp_Name_i.Text=="" ||
				TB_TargetStockName_i.Text =="" || TB_TargetStockLocation_i.Text=="")
			{
				MessageBox.Show("Insufficient data input!", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (Check_neverExist.Checked)
				{
					if (tb_addProduct_i.Text != "" &&
					tb_ProductID_i.Text != "" &&
					tb_ProductQuantity_i.Text != "" &&
					tb_ProductColor.Text != "" &&
					tb_ProductMemo.Text != "" &&
					tb_Price_i.Text != "")
					{

						btnAdd.BackColor = Color.RoyalBlue;
						btnAdd.ForeColor = Color.White;
						btnAdd.Text = "Add";
						btnAdd.Enabled = true;
					}
					else
					{

						btnAdd.BackColor = Color.Gray;
						btnAdd.ForeColor = Color.White;
						btnAdd.Text = "Invalid";
						btnAdd.Enabled = false;
					}
				}
				else
				{
					if (tb_Quant_i_old.Text == "0" || tb_Quant_i_old == null)
					{
						btnAdd.BackColor = Color.Gray;
						btnAdd.ForeColor = Color.White;
						btnAdd.Text = "Invalid";
						btnAdd.Enabled = false;
					}
					else
					{
						btnAdd.BackColor = Color.RoyalBlue;
						btnAdd.ForeColor = Color.White;
						btnAdd.Text = "Add";
						btnAdd.Enabled = true;
					}
				}
			}
		}

		private void PID_KP(object sender, KeyPressEventArgs e)
		{
			enaBtnAdd();
			tb_ProductID_i.MaxLength = 20;
		}

		private void Quan_KP(object sender, KeyPressEventArgs e)
		{
			
				enaBtnAdd();
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
				{
					e.Handled = true;
				}
				if (tb_ProductQuantity_i.Text == "")
				{
					
				}
			
	
		}

		private void Col_KP(object sender, KeyPressEventArgs e)
		{
			enaBtnAdd();
		}

		private void Memo_KP(object sender, KeyPressEventArgs e)
		{
			enaBtnAdd();
		}

		private void Price_KP(object sender, KeyPressEventArgs e)
		{
			enaBtnAdd();
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
			if (tb_Price_i.Text == "")
			{
				
			}
		}

		private void Check_neverExist_CheckedChanged(object sender, EventArgs e)
		{
			if (Check_neverExist.Checked)
			{
				tb_addProduct_i.Enabled = true;
				tb_ProductID_i.Enabled=true;
				tb_ProductQuantity_i.Enabled = true;
				tb_ProductColor.Enabled= true;
				tb_ProductMemo.Enabled=true;
				tb_Price_i.Enabled= true;

				cb_color_i.Enabled = false;
				cb_memo_i.Enabled=false;

				tb_Price_i_old.Enabled= false;
				tb_Price_i_old.Text = string.Empty;

				tb_Quant_i_old.Enabled= false;
				tb_Quant_i_old.Text= string.Empty;

				cb_selectGood_i.Enabled = false;

			}
			else
			{
				tb_addProduct_i.Enabled = false;
				tb_addProduct_i.Text = string.Empty;

				tb_ProductID_i.Enabled = false;
				tb_ProductID_i.Text = string.Empty;

				tb_ProductQuantity_i.Enabled = false;
				tb_ProductQuantity_i.Text = string.Empty;

				tb_ProductColor.Enabled = false;
				tb_ProductColor.Text = string.Empty;

				tb_ProductMemo.Enabled = false;
				tb_ProductMemo.Text = string.Empty;

				tb_Price_i.Enabled = false;
				tb_Price_i.Text = string.Empty;


				cb_selectGood_i.Enabled = true;
				cb_color_i.Enabled = true;
				cb_memo_i.Enabled= true;
				tb_Price_i_old.Enabled = false;
				tb_Quant_i_old.Enabled= true;
				tb_Quant_i_old.Text = "0";


				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				
				SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT PName FROM Product", conn);
				SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adapter1.Fill(dt1);
				conn.Close();
				if (dt1.Rows.Count > 0)
				{

					for (int i = 0; i < dt1.Rows.Count; i++)
					{
						cb_selectGood_i.DisplayMember = "PName";
						cb_selectGood_i.ValueMember = "PName";
						cb_selectGood_i.DataSource = dt1;
					}
				}
				else
				{
					MessageBox.Show("No Data in Delivery name");
				}
			}
		}

		private void checkIfNew_CheckedChanged(object sender, EventArgs e)
		{
			
			if (checkIfNew.Checked)
			{
				TB_ReceiverName_i.Enabled = true;
				cb_receiver_i.Enabled = false;

			}
			else
			{
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				TB_ReceiverName_i.Enabled = false;
				TB_ReceiverName_i.Text = string.Empty;
				cb_receiver_i.Enabled = true;
				SqlCommand cmd1 = new SqlCommand("select distinct DeliverName from Good_Receiver", conn);
				SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adapter1.Fill(dt1);
				conn.Close();
				if (dt1.Rows.Count > 0)
				{

					for (int i = 0; i < dt1.Rows.Count; i++)
					{
						cb_receiver_i.DisplayMember = "DeliverName";
						cb_receiver_i.ValueMember = "DeliverName";
						cb_receiver_i.DataSource = dt1;
					}
				}
				else
				{
					MessageBox.Show("No Data");
				}
			}
		}

		private  void ATRN_KP(object sender, KeyPressEventArgs e)
		{
			
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
			if (TB_AccordingToReceiptNo_i.Text == "")
			{
					
			}
			
		}

		private void cb_selectGood_i_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT DISTINCT PColor FROM Product WHERE PName ='" + cb_selectGood_i.SelectedValue.ToString() + "'", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					cb_color_i.DisplayMember = "PColor";
					cb_color_i.ValueMember = "PColor";
					cb_color_i.DataSource = dt;
				}

			}
			else
			{
				MessageBox.Show("No Data");
			}
		}

		private void cb_color_i_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT DISTINCT PMemory FROM Product WHERE PColor ='" + cb_color_i.SelectedValue.ToString() + "' AND PName ='" + cb_selectGood_i.SelectedValue.ToString() + "'", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			conn.Close();
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					cb_memo_i.DisplayMember = "PMemory";
					cb_memo_i.ValueMember = "PMemory";
					cb_memo_i.DataSource = dt;
				}
			}
			else
			{
				MessageBox.Show("No Data");
			}
		}

		private void cb_memo_i_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool isValid = int.TryParse(tb_Quant_i_old.ToString(), out int number);
			if (isValid) 
			{
				
			}
			else
			{
				tb_Quant_i_old.Text = "0";
			}

			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			SqlCommand cmd2 = new SqlCommand("SELECT PPrice FROM Product WHERE PMemory ='" + cb_memo_i.SelectedValue.ToString() + "' AND PColor ='" + cb_color_i.SelectedValue.ToString() + "' AND PName ='" + cb_selectGood_i.SelectedValue.ToString() + "'", conn);
			SqlDataReader sr2 = cmd2.ExecuteReader();
			while (sr2.Read())
			{
				tb_Price_i_old.Text = sr2.GetValue(0).ToString();
			}
			conn.Close();

		}

		private void Quant_i_old_KP(object sender, KeyPressEventArgs e)
		{

			
				enaBtnAdd();

				if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
				{
					e.Handled = true;
				}
				if (tb_Quant_i_old.Text == "")
				{
					
				}
			
			
			
		}

		private void Anew_kp(object sender, KeyPressEventArgs e)
		{
			enaBtnAdd();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (DGV_Receipt_i.SelectedRows.Count > 0 && !DGV_Receipt_i.IsCurrentRowDirty)
			{
				DialogResult r = MessageBox.Show("You want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (r == DialogResult.Yes)
				{
					DataGridViewRow selectedRow = DGV_Receipt_i.SelectedRows[0];
					string pid = selectedRow.Cells["PID"].Value.ToString();
					int pquantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
					int pprice = Convert.ToInt32(selectedRow.Cells["PricePerUnit"].Value);
					SqlConnection conn = new SqlConnection(Program.strConn);
					conn.Open();
					SqlCommand deleteRow = new SqlCommand("DELETE FROM temp_Import_data WHERE PID = '" + pid + "' AND Quantity = " + pquantity + " AND PPrice = " + pprice, conn);
					deleteRow.ExecuteNonQuery();
					deleteRow = new SqlCommand("DELETE FROM newTempProduct WHERE PID = '" + pid + "' AND PQuantity = " + pquantity + " AND PPrice = " + pprice, conn);
					deleteRow.ExecuteNonQuery();
					conn.Close();
					showGrid();
					DGV_Receipt_i.Refresh();
				}
			}
			else
			{
				MessageBox.Show("Please select a row to delete", "Error");
			}
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			if (isTempTableExist)
			{
				int success = 0;
				SqlConnection conn = new SqlConnection(Program.strConn);
				conn.Open();
				SqlCommand cmdAdd = new SqlCommand("MERGE INTO Product AS p\r\nUSING newTempProduct AS ntp\r\nON p.PID = ntp.PID\r\nWHEN MATCHED THEN\r\n    UPDATE SET p.PQuantity = p.PQuantity + ntp.PQuantity\r\nWHEN NOT MATCHED THEN\r\n    INSERT (PID, PName, PMemory, PColor, PQuantity, PPrice)\r\n    VALUES (ntp.PID, ntp.PName, ntp.PMemory, ntp.PColor, ntp.PQuantity, ntp.PPrice);", conn);
				
				SqlCommand cmd2 = new SqlCommand("insert into Good_Receiver select * from temp_Import_info", conn);


				int add_receipt = cmd2.ExecuteNonQuery();
				if (add_receipt > 0) { success += 1; }
				else { success += 0; }

				int add_data = cmdAdd.ExecuteNonQuery();
				if (add_data > 0) { success += 1; }
				else { success += 0; }


				if (success == 2)
				{

					SqlCommand cmd = new SqlCommand("DROP TABLE temp_Import_info;DROP TABLE temp_Import_data;", conn);
					SqlCommand cmd1 = new SqlCommand("insert into Import_details select * from temp_Import_data", conn);
					SqlCommand cmdz = new SqlCommand("DROP TABLE newTempProduct;", conn);
					cmd1.ExecuteNonQuery();
					cmd.ExecuteNonQuery();
					cmdz.ExecuteNonQuery();
					MessageBox.Show("Successfully", "finished");
					this.Close();
					FrmGoodReceived f = new FrmGoodReceived();
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

		private async void CVC_changed(object sender, DataGridViewCellEventArgs e)
		{
			delaying.Cancel();
			delaying = new CancellationTokenSource();

			try
			{
				await Task.Delay(DelayTime, delaying.Token);


				if (e.RowIndex >= 0 && e.ColumnIndex == DGV_Receipt_i.Columns["Quantity"].Index)
				{
					DataGridViewRow row = DGV_Receipt_i.Rows[e.RowIndex];
					string pid = row.Cells["PID"].Value.ToString();
					int newQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

					bool isNum = int.TryParse(row.Cells["Quantity"].Value.ToString(), out int output);

					if (isNum)
					{
						SqlConnection conn = new SqlConnection(Program.strConn);
						conn.Open();
						SqlCommand changeQuan = new SqlCommand("UPDATE temp_Import_data SET Quantity = " + newQuantity + " WHERE PID = '" + pid + "'", conn);
						changeQuan.ExecuteNonQuery();
						changeQuan = new SqlCommand("UPDATE newTempProduct SET PQuantity = " + newQuantity + " WHERE PID = '" + pid + "'", conn);
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

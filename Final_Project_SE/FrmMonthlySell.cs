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
	public partial class FrmMonthlySell : Form
	{
		public FrmMonthlySell()
		{
			InitializeComponent();
		}

		private void FrmMonthlySell_Load(object sender, EventArgs e)
		{
			
			string query = "SELECT CONCAT(MONTH(dateCreated), '/', YEAR(dateCreated)) AS 'month/year', SUM(ISNULL(rd.Quantity * rd.PPrice, 0)) AS 'moneyGain' FROM Good_Delivery_Note gdn JOIN Receipt_details rd ON gdn.exportReceiptNo = rd.OrderID GROUP BY YEAR(dateCreated), MONTH(dateCreated)";
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			DGV_ShowData.DataSource = dt;
		}

		private void CC_monthSelected(object sender, DataGridViewCellEventArgs e)
		{
			MonthSelectedUpdate();
			ReceiptSelectedUpdate();
		}

		private void MonthSelectedUpdate()
		{
			string monthYear = DGV_ShowData.CurrentRow.Cells["month/year"].Value.ToString();

			string[] parts = monthYear.Split('/');
			string month = parts[0];
			string year = parts[1];

			string query = $"SELECT * FROM Good_delivery_note WHERE YEAR(dateCreated) = {year} AND MONTH(dateCreated) = {month}";
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			DGV_Receipt.DataSource = dt;
		}

		private void ReceiptSelectedUpdate()
		{
			string query = "SELECT p.*, rd.OrderID FROM Product p INNER JOIN Receipt_Details rd ON p.PID = rd.PID WHERE rd.OrderID = @OrderID";
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@OrderID", DGV_Receipt.CurrentRow.Cells["exportReceiptNo"].Value.ToString());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			DGV_Product.DataSource = dt;
		}

		private void CC_Receipt_selected(object sender, DataGridViewCellEventArgs e)
		{
			ReceiptSelectedUpdate();
		}
	}
}

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
	public partial class FrmProductReport : Form
	{
		public FrmProductReport()
		{
			InitializeComponent();
		}

		private void frmProductReport_Load(object sender, EventArgs e)
		{
			List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();
			items.Add(new KeyValuePair<string, string>("Best Seller", "1"));
			items.Add(new KeyValuePair<string, string>("Least Seller", "2"));
			items.Add(new KeyValuePair<string, string>("In Stock Product", "3"));
			items.Add(new KeyValuePair<string, string>("Out Of Stock Product", "4"));

			Cb_selection.DisplayMember = "Key";
			Cb_selection.ValueMember = "Value";
			Cb_selection.DataSource = items;
		}

		private void Cb_selection_SelectedIndexChanged(object sender, EventArgs e)
		{
			int option = int.Parse(Cb_selection.SelectedValue.ToString());
			string query;
			if (option == 1) { query = "SELECT TOP 10 [Product].*, COUNT(*) AS [DeliveryCount] FROM [Product] JOIN [Receipt_details] ON [Product].[PID] = [Receipt_details].[PID] JOIN [Good_delivery_note] ON [Receipt_details].[OrderID] = [Good_delivery_note].[exportReceiptNo] GROUP BY [Product].[PID], [Product].[PName], [Product].[PMemory], [Product].[PColor], [Product].[PQuantity], [Product].[PPrice], [Product].[img] ORDER BY COUNT(*) DESC"; }
			else if (option == 2) { query = "SELECT TOP 10 [Product].*, COUNT(*) AS [DeliveryCount] FROM [Product] JOIN [Receipt_details] ON [Product].[PID] = [Receipt_details].[PID] JOIN [Good_delivery_note] ON [Receipt_details].[OrderID] = [Good_delivery_note].[exportReceiptNo] GROUP BY [Product].[PID], [Product].[PName], [Product].[PMemory], [Product].[PColor], [Product].[PQuantity], [Product].[PPrice], [Product].[img] ORDER BY COUNT(*) ASC"; }
			else if (option == 3) { query = "SELECT * FROM [Product] WHERE [PQuantity] > 0; "; }
			else { query = "SELECT * FROM [Product] WHERE [PQuantity] = 0"; }

			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			DGV_selected_option.DataSource = dt;
		}
	}
}

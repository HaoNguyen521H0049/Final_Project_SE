using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_SE
{
	public partial class frmMainControlPage : Form
	{
		public frmMainControlPage()
		{
			InitializeComponent();
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmGoodReceived f = new frmGoodReceived();
			f.Show();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmGoodDeliveryNote f = new frmGoodDeliveryNote();
			f.MdiParent = this;
			f.Show();
		}

		private void frmMainControlPage_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
	}
}

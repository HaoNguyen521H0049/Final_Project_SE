using System;
using System.Windows.Forms;

namespace Final_Project_SE
{
	public partial class FrmMainControlPage : Form
	{
		public FrmMainControlPage()
		{
			InitializeComponent();
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGoodReceived f = new FrmGoodReceived();
			f.MdiParent = this;
			f.Show();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGoodDeliveryNote f = new FrmGoodDeliveryNote();
			f.MdiParent = this;
			f.Show();
		}

		private void frmMainControlPage_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void agentAccountManagementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAgentManagement f = new FrmAgentManagement();
			f.MdiParent = this;
			f.Show();
		}

		private void incommingOutcommingStockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmIncomeOutcomeRep f = new FrmIncomeOutcomeRep();
			f.MdiParent = this;
			f.Show();
		}

		private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmProductReport f = new FrmProductReport();
			f.MdiParent = this;
			f.Show();
		}

		private void monthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmMonthlySell f = new FrmMonthlySell();
			f.MdiParent = this;
			f.Show();
		}

		private void updatePaidStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmUpdateStatus f = new FrmUpdateStatus();
			f.MdiParent = this;
			f.Show();
		}
	}
}

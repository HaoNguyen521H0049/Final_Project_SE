namespace Final_Project_SE
{
	partial class FrmMainControlPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainControlPage));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updatePaidStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.managementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.agentAccountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.incommingOutcommingStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateAgentRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem1,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.updatePaidStatusToolStripMenuItem,
            this.updateAgentRequestToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.importToolStripMenuItem.Text = "Import ";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// updatePaidStatusToolStripMenuItem
			// 
			this.updatePaidStatusToolStripMenuItem.Name = "updatePaidStatusToolStripMenuItem";
			this.updatePaidStatusToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.updatePaidStatusToolStripMenuItem.Text = "Update Paid Status";
			this.updatePaidStatusToolStripMenuItem.Click += new System.EventHandler(this.updatePaidStatusToolStripMenuItem_Click);
			// 
			// managementToolStripMenuItem1
			// 
			this.managementToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agentAccountManagementToolStripMenuItem});
			this.managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
			this.managementToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
			this.managementToolStripMenuItem1.Text = "Management";
			// 
			// agentAccountManagementToolStripMenuItem
			// 
			this.agentAccountManagementToolStripMenuItem.Name = "agentAccountManagementToolStripMenuItem";
			this.agentAccountManagementToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.agentAccountManagementToolStripMenuItem.Text = "Agent Account Management";
			this.agentAccountManagementToolStripMenuItem.Click += new System.EventHandler(this.agentAccountManagementToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incommingOutcommingStockToolStripMenuItem,
            this.productReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// incommingOutcommingStockToolStripMenuItem
			// 
			this.incommingOutcommingStockToolStripMenuItem.Name = "incommingOutcommingStockToolStripMenuItem";
			this.incommingOutcommingStockToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.incommingOutcommingStockToolStripMenuItem.Text = "Incomming/Outcomming Stock";
			this.incommingOutcommingStockToolStripMenuItem.Click += new System.EventHandler(this.incommingOutcommingStockToolStripMenuItem_Click);
			// 
			// productReportToolStripMenuItem
			// 
			this.productReportToolStripMenuItem.Name = "productReportToolStripMenuItem";
			this.productReportToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.productReportToolStripMenuItem.Text = "Product Report";
			this.productReportToolStripMenuItem.Click += new System.EventHandler(this.productReportToolStripMenuItem_Click);
			// 
			// monthlyReportToolStripMenuItem
			// 
			this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
			this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
			this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
			this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// managementToolStripMenuItem
			// 
			this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAgentToolStripMenuItem});
			this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
			this.managementToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.managementToolStripMenuItem.Text = "Management";
			// 
			// addAgentToolStripMenuItem
			// 
			this.addAgentToolStripMenuItem.Name = "addAgentToolStripMenuItem";
			this.addAgentToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.addAgentToolStripMenuItem.Text = "Add Agent";
			// 
			// updateAgentRequestToolStripMenuItem
			// 
			this.updateAgentRequestToolStripMenuItem.Name = "updateAgentRequestToolStripMenuItem";
			this.updateAgentRequestToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.updateAgentRequestToolStripMenuItem.Text = "Update Agent Request";
			this.updateAgentRequestToolStripMenuItem.Click += new System.EventHandler(this.updateAgentRequestToolStripMenuItem_Click);
			// 
			// FrmMainControlPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1222, 474);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMainControlPage";
			this.Text = "frmMainControlPage";
			this.Load += new System.EventHandler(this.frmMainControlPage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAgentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem agentAccountManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem incommingOutcommingStockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updatePaidStatusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateAgentRequestToolStripMenuItem;
	}
}
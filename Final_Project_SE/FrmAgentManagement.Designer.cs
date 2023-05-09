namespace Final_Project_SE
{
	partial class FrmAgentManagement
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
			this.DGV_showAcc = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DGV_showAcc)).BeginInit();
			this.SuspendLayout();
			// 
			// DGV_showAcc
			// 
			this.DGV_showAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_showAcc.Location = new System.Drawing.Point(12, 12);
			this.DGV_showAcc.Name = "DGV_showAcc";
			this.DGV_showAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_showAcc.Size = new System.Drawing.Size(776, 352);
			this.DGV_showAcc.TabIndex = 1;
			this.DGV_showAcc.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.editCell);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(115, 381);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(97, 57);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add new";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.IndianRed;
			this.btnDel.Location = new System.Drawing.Point(12, 381);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(97, 57);
			this.btnDel.TabIndex = 15;
			this.btnDel.Text = "Delete Account";
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDelRow_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.LightCoral;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(691, 381);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(97, 57);
			this.btnExit.TabIndex = 16;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmAgentManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.DGV_showAcc);
			this.Name = "frmAgentManagement";
			this.Text = "frmAgentManagement";
			this.Load += new System.EventHandler(this.frmAddAgent_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_showAcc)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView DGV_showAcc;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnExit;
	}
}
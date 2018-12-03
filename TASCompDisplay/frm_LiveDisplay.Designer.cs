namespace TASCompDisplay
{
	partial class frm_LiveDisplay
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lbl_Prefix = new System.Windows.Forms.Label();
			this.lbl_Display = new System.Windows.Forms.Label();
			this.btn_Previous = new System.Windows.Forms.Button();
			this.btn_Next = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(0, 183);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(439, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// lbl_Prefix
			// 
			this.lbl_Prefix.AutoSize = true;
			this.lbl_Prefix.Font = new System.Drawing.Font("Super Mario Odyssey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Prefix.Location = new System.Drawing.Point(80, 24);
			this.lbl_Prefix.Name = "lbl_Prefix";
			this.lbl_Prefix.Size = new System.Drawing.Size(284, 47);
			this.lbl_Prefix.TabIndex = 1;
			this.lbl_Prefix.Text = "Current display:";
			// 
			// lbl_Display
			// 
			this.lbl_Display.AutoSize = true;
			this.lbl_Display.Font = new System.Drawing.Font("Super Mario Odyssey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Display.Location = new System.Drawing.Point(80, 71);
			this.lbl_Display.Name = "lbl_Display";
			this.lbl_Display.Size = new System.Drawing.Size(266, 47);
			this.lbl_Display.TabIndex = 2;
			this.lbl_Display.Text = "Sample Display";
			// 
			// btn_Previous
			// 
			this.btn_Previous.Font = new System.Drawing.Font("Super Mario Odyssey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Previous.Location = new System.Drawing.Point(174, 121);
			this.btn_Previous.Name = "btn_Previous";
			this.btn_Previous.Size = new System.Drawing.Size(43, 55);
			this.btn_Previous.TabIndex = 3;
			this.btn_Previous.Text = "<";
			this.btn_Previous.UseVisualStyleBackColor = true;
			this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
			// 
			// btn_Next
			// 
			this.btn_Next.Font = new System.Drawing.Font("Super Mario Odyssey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Next.Location = new System.Drawing.Point(223, 121);
			this.btn_Next.Name = "btn_Next";
			this.btn_Next.Size = new System.Drawing.Size(43, 55);
			this.btn_Next.TabIndex = 4;
			this.btn_Next.Text = ">";
			this.btn_Next.UseVisualStyleBackColor = true;
			this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(439, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// frm_LiveDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 206);
			this.Controls.Add(this.btn_Next);
			this.Controls.Add(this.btn_Previous);
			this.Controls.Add(this.lbl_Display);
			this.Controls.Add(this.lbl_Prefix);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm_LiveDisplay";
			this.Text = "Live Display";
			this.Load += new System.EventHandler(this.frm_LiveDisplay_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lbl_Prefix;
		private System.Windows.Forms.Label lbl_Display;
		private System.Windows.Forms.Button btn_Previous;
		private System.Windows.Forms.Button btn_Next;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
	}
}
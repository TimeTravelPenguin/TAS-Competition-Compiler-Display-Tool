namespace TASCompDisplay
{
	partial class frm_PlainTextPopup
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Display = new System.Windows.Forms.TextBox();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Super Mario Odyssey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Comp Data:";
			// 
			// txt_Display
			// 
			this.txt_Display.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.txt_Display.Location = new System.Drawing.Point(0, 52);
			this.txt_Display.Multiline = true;
			this.txt_Display.Name = "txt_Display";
			this.txt_Display.Size = new System.Drawing.Size(350, 183);
			this.txt_Display.TabIndex = 1;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Location = new System.Drawing.Point(285, 18);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(53, 23);
			this.btn_Refresh.TabIndex = 2;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// btn_Copy
			// 
			this.btn_Copy.Location = new System.Drawing.Point(226, 18);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.Size = new System.Drawing.Size(53, 23);
			this.btn_Copy.TabIndex = 3;
			this.btn_Copy.Text = "Copy";
			this.btn_Copy.UseVisualStyleBackColor = true;
			this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
			// 
			// frm_PlainTextPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 235);
			this.Controls.Add(this.btn_Copy);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.txt_Display);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_PlainTextPopup";
			this.Text = "Export";
			this.Load += new System.EventHandler(this.PlainTextPopup_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Display;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.Button btn_Copy;
	}
}
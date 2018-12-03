namespace TASCompDisplay
{
	partial class frm_LiveStringSetting
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
			this.chk_Username = new System.Windows.Forms.CheckBox();
			this.chk_Frames = new System.Windows.Forms.CheckBox();
			this.chk_Time = new System.Windows.Forms.CheckBox();
			this.chk_Rerecords = new System.Windows.Forms.CheckBox();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.txt_Format = new System.Windows.Forms.TextBox();
			this.brn_Refresh = new System.Windows.Forms.Button();
			this.btn_Help = new System.Windows.Forms.Button();
			this.btn_default = new System.Windows.Forms.Button();
			this.chk_Rank = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chk_Username
			// 
			this.chk_Username.AutoSize = true;
			this.chk_Username.Location = new System.Drawing.Point(76, 12);
			this.chk_Username.Name = "chk_Username";
			this.chk_Username.Size = new System.Drawing.Size(74, 17);
			this.chk_Username.TabIndex = 0;
			this.chk_Username.Text = "Username";
			this.chk_Username.UseVisualStyleBackColor = true;
			// 
			// chk_Frames
			// 
			this.chk_Frames.AutoSize = true;
			this.chk_Frames.Location = new System.Drawing.Point(156, 12);
			this.chk_Frames.Name = "chk_Frames";
			this.chk_Frames.Size = new System.Drawing.Size(60, 17);
			this.chk_Frames.TabIndex = 1;
			this.chk_Frames.Text = "Frames";
			this.chk_Frames.UseVisualStyleBackColor = true;
			// 
			// chk_Time
			// 
			this.chk_Time.AutoSize = true;
			this.chk_Time.Location = new System.Drawing.Point(215, 12);
			this.chk_Time.Name = "chk_Time";
			this.chk_Time.Size = new System.Drawing.Size(49, 17);
			this.chk_Time.TabIndex = 2;
			this.chk_Time.Text = "Time";
			this.chk_Time.UseVisualStyleBackColor = true;
			// 
			// chk_Rerecords
			// 
			this.chk_Rerecords.AutoSize = true;
			this.chk_Rerecords.Location = new System.Drawing.Point(270, 12);
			this.chk_Rerecords.Name = "chk_Rerecords";
			this.chk_Rerecords.Size = new System.Drawing.Size(75, 17);
			this.chk_Rerecords.TabIndex = 3;
			this.chk_Rerecords.Text = "Rerecords";
			this.chk_Rerecords.UseVisualStyleBackColor = true;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Location = new System.Drawing.Point(30, 61);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(68, 23);
			this.btn_Confirm.TabIndex = 4;
			this.btn_Confirm.Text = "Update";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			this.btn_Confirm.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_Format
			// 
			this.txt_Format.Location = new System.Drawing.Point(12, 35);
			this.txt_Format.Name = "txt_Format";
			this.txt_Format.Size = new System.Drawing.Size(334, 20);
			this.txt_Format.TabIndex = 5;
			// 
			// brn_Refresh
			// 
			this.brn_Refresh.Location = new System.Drawing.Point(104, 61);
			this.brn_Refresh.Name = "brn_Refresh";
			this.brn_Refresh.Size = new System.Drawing.Size(68, 23);
			this.brn_Refresh.TabIndex = 6;
			this.brn_Refresh.Text = "Refresh";
			this.brn_Refresh.UseVisualStyleBackColor = true;
			this.brn_Refresh.Click += new System.EventHandler(this.brn_Refresh_Click);
			// 
			// btn_Help
			// 
			this.btn_Help.Location = new System.Drawing.Point(252, 61);
			this.btn_Help.Name = "btn_Help";
			this.btn_Help.Size = new System.Drawing.Size(68, 23);
			this.btn_Help.TabIndex = 7;
			this.btn_Help.Text = "Help";
			this.btn_Help.UseVisualStyleBackColor = true;
			this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
			// 
			// btn_default
			// 
			this.btn_default.Location = new System.Drawing.Point(178, 61);
			this.btn_default.Name = "btn_default";
			this.btn_default.Size = new System.Drawing.Size(68, 23);
			this.btn_default.TabIndex = 8;
			this.btn_default.Text = "Default";
			this.btn_default.UseVisualStyleBackColor = true;
			this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
			// 
			// chk_Rank
			// 
			this.chk_Rank.AutoSize = true;
			this.chk_Rank.Location = new System.Drawing.Point(18, 12);
			this.chk_Rank.Name = "chk_Rank";
			this.chk_Rank.Size = new System.Drawing.Size(52, 17);
			this.chk_Rank.TabIndex = 9;
			this.chk_Rank.Text = "Rank";
			this.chk_Rank.UseVisualStyleBackColor = true;
			// 
			// frm_LiveStringSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 91);
			this.Controls.Add(this.chk_Rank);
			this.Controls.Add(this.btn_default);
			this.Controls.Add(this.btn_Help);
			this.Controls.Add(this.brn_Refresh);
			this.Controls.Add(this.txt_Format);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.chk_Rerecords);
			this.Controls.Add(this.chk_Time);
			this.Controls.Add(this.chk_Frames);
			this.Controls.Add(this.chk_Username);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frm_LiveStringSetting";
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.frm_LiveStringSetting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chk_Username;
		private System.Windows.Forms.CheckBox chk_Frames;
		private System.Windows.Forms.CheckBox chk_Time;
		private System.Windows.Forms.CheckBox chk_Rerecords;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.TextBox txt_Format;
		private System.Windows.Forms.Button brn_Refresh;
		private System.Windows.Forms.Button btn_Help;
		private System.Windows.Forms.Button btn_default;
		private System.Windows.Forms.CheckBox chk_Rank;
	}
}
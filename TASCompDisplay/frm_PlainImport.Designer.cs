namespace TASCompDisplay
{
	partial class frm_PlainImport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PlainImport));
			this.txt_Input = new System.Windows.Forms.TextBox();
			this.btn_Submit = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_Input
			// 
			this.txt_Input.Location = new System.Drawing.Point(12, 25);
			this.txt_Input.Multiline = true;
			this.txt_Input.Name = "txt_Input";
			this.txt_Input.Size = new System.Drawing.Size(280, 289);
			this.txt_Input.TabIndex = 0;
			this.txt_Input.Text = resources.GetString("txt_Input.Text");
			// 
			// btn_Submit
			// 
			this.btn_Submit.Location = new System.Drawing.Point(12, 320);
			this.btn_Submit.Name = "btn_Submit";
			this.btn_Submit.Size = new System.Drawing.Size(75, 23);
			this.btn_Submit.TabIndex = 1;
			this.btn_Submit.Text = "Submit";
			this.btn_Submit.UseVisualStyleBackColor = true;
			this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
			// 
			// btn_Clear
			// 
			this.btn_Clear.Location = new System.Drawing.Point(217, 320);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(75, 23);
			this.btn_Clear.TabIndex = 2;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "In form: Username Ti\"me. No other spaces!";
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Location = new System.Drawing.Point(114, 320);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
			this.btn_Refresh.TabIndex = 4;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// frm_PlainImport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 355);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Submit);
			this.Controls.Add(this.txt_Input);
			this.Name = "frm_PlainImport";
			this.Text = "Plain Text Importer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Input;
		private System.Windows.Forms.Button btn_Submit;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Refresh;
	}
}
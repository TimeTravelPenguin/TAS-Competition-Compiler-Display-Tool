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
			this.lbl_Prefix = new System.Windows.Forms.Label();
			this.lbl_Display = new System.Windows.Forms.Label();
			this.btn_Previous = new System.Windows.Forms.Button();
			this.btn_Next = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeOutputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gb_CurrentRun = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_Rank = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.lbl_VIs = new System.Windows.Forms.Label();
			this.lbl_Delta = new System.Windows.Forms.Label();
			this.lbl_Time = new System.Windows.Forms.Label();
			this.gb_NextRun = new System.Windows.Forms.GroupBox();
			this.lbl_NextTime = new System.Windows.Forms.Label();
			this.lbl_NextDelta = new System.Windows.Forms.Label();
			this.lbl_NextVIs = new System.Windows.Forms.Label();
			this.lbl_NextName = new System.Windows.Forms.Label();
			this.lbl_NextRank = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.chk_EnableNextRun = new System.Windows.Forms.CheckBox();
			this.menuStrip1.SuspendLayout();
			this.gb_CurrentRun.SuspendLayout();
			this.gb_NextRun.SuspendLayout();
			this.SuspendLayout();
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
			this.lbl_Display.Font = new System.Drawing.Font("Super Mario Odyssey", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Display.Location = new System.Drawing.Point(116, 71);
			this.lbl_Display.Name = "lbl_Display";
			this.lbl_Display.Size = new System.Drawing.Size(209, 37);
			this.lbl_Display.TabIndex = 2;
			this.lbl_Display.Text = "Sample Display";
			// 
			// btn_Previous
			// 
			this.btn_Previous.Font = new System.Drawing.Font("Super Mario Odyssey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Previous.Location = new System.Drawing.Point(174, 111);
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
			this.btn_Next.Location = new System.Drawing.Point(223, 111);
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
            this.settingsToolStripMenuItem,
            this.changeOutputDirectoryToolStripMenuItem});
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
			// changeOutputDirectoryToolStripMenuItem
			// 
			this.changeOutputDirectoryToolStripMenuItem.Name = "changeOutputDirectoryToolStripMenuItem";
			this.changeOutputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
			this.changeOutputDirectoryToolStripMenuItem.Text = "&Change Output Directory";
			this.changeOutputDirectoryToolStripMenuItem.Click += new System.EventHandler(this.changeOutputDirectoryToolStripMenuItem_Click);
			// 
			// gb_CurrentRun
			// 
			this.gb_CurrentRun.Controls.Add(this.lbl_Time);
			this.gb_CurrentRun.Controls.Add(this.lbl_Delta);
			this.gb_CurrentRun.Controls.Add(this.lbl_VIs);
			this.gb_CurrentRun.Controls.Add(this.lbl_Name);
			this.gb_CurrentRun.Controls.Add(this.lbl_Rank);
			this.gb_CurrentRun.Controls.Add(this.label5);
			this.gb_CurrentRun.Controls.Add(this.label4);
			this.gb_CurrentRun.Controls.Add(this.label3);
			this.gb_CurrentRun.Controls.Add(this.label2);
			this.gb_CurrentRun.Controls.Add(this.label1);
			this.gb_CurrentRun.Location = new System.Drawing.Point(12, 172);
			this.gb_CurrentRun.Name = "gb_CurrentRun";
			this.gb_CurrentRun.Size = new System.Drawing.Size(205, 156);
			this.gb_CurrentRun.TabIndex = 6;
			this.gb_CurrentRun.TabStop = false;
			this.gb_CurrentRun.Text = "Run Information";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "VIs:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Delta:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Time:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 27);
			this.label5.TabIndex = 4;
			this.label5.Text = "Rank:";
			// 
			// lbl_Rank
			// 
			this.lbl_Rank.AutoSize = true;
			this.lbl_Rank.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Rank.Location = new System.Drawing.Point(83, 16);
			this.lbl_Rank.Name = "lbl_Rank";
			this.lbl_Rank.Size = new System.Drawing.Size(56, 27);
			this.lbl_Rank.TabIndex = 5;
			this.lbl_Rank.Text = "Rank";
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Name.Location = new System.Drawing.Point(83, 43);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(65, 27);
			this.lbl_Name.TabIndex = 6;
			this.lbl_Name.Text = "Name";
			// 
			// lbl_VIs
			// 
			this.lbl_VIs.AutoSize = true;
			this.lbl_VIs.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_VIs.Location = new System.Drawing.Point(83, 70);
			this.lbl_VIs.Name = "lbl_VIs";
			this.lbl_VIs.Size = new System.Drawing.Size(40, 27);
			this.lbl_VIs.TabIndex = 7;
			this.lbl_VIs.Text = "VIs";
			// 
			// lbl_Delta
			// 
			this.lbl_Delta.AutoSize = true;
			this.lbl_Delta.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Delta.Location = new System.Drawing.Point(83, 97);
			this.lbl_Delta.Name = "lbl_Delta";
			this.lbl_Delta.Size = new System.Drawing.Size(62, 27);
			this.lbl_Delta.TabIndex = 8;
			this.lbl_Delta.Text = "Delta";
			// 
			// lbl_Time
			// 
			this.lbl_Time.AutoSize = true;
			this.lbl_Time.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Time.Location = new System.Drawing.Point(83, 124);
			this.lbl_Time.Name = "lbl_Time";
			this.lbl_Time.Size = new System.Drawing.Size(56, 27);
			this.lbl_Time.TabIndex = 9;
			this.lbl_Time.Text = "Time";
			// 
			// gb_NextRun
			// 
			this.gb_NextRun.Controls.Add(this.lbl_NextTime);
			this.gb_NextRun.Controls.Add(this.lbl_NextDelta);
			this.gb_NextRun.Controls.Add(this.lbl_NextVIs);
			this.gb_NextRun.Controls.Add(this.lbl_NextName);
			this.gb_NextRun.Controls.Add(this.lbl_NextRank);
			this.gb_NextRun.Controls.Add(this.label11);
			this.gb_NextRun.Controls.Add(this.label12);
			this.gb_NextRun.Controls.Add(this.label13);
			this.gb_NextRun.Controls.Add(this.label14);
			this.gb_NextRun.Controls.Add(this.label15);
			this.gb_NextRun.Location = new System.Drawing.Point(222, 172);
			this.gb_NextRun.Name = "gb_NextRun";
			this.gb_NextRun.Size = new System.Drawing.Size(205, 156);
			this.gb_NextRun.TabIndex = 7;
			this.gb_NextRun.TabStop = false;
			this.gb_NextRun.Text = "Next Run Information";
			// 
			// lbl_NextTime
			// 
			this.lbl_NextTime.AutoSize = true;
			this.lbl_NextTime.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_NextTime.Location = new System.Drawing.Point(83, 124);
			this.lbl_NextTime.Name = "lbl_NextTime";
			this.lbl_NextTime.Size = new System.Drawing.Size(56, 27);
			this.lbl_NextTime.TabIndex = 9;
			this.lbl_NextTime.Text = "Time";
			// 
			// lbl_NextDelta
			// 
			this.lbl_NextDelta.AutoSize = true;
			this.lbl_NextDelta.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_NextDelta.Location = new System.Drawing.Point(83, 97);
			this.lbl_NextDelta.Name = "lbl_NextDelta";
			this.lbl_NextDelta.Size = new System.Drawing.Size(62, 27);
			this.lbl_NextDelta.TabIndex = 8;
			this.lbl_NextDelta.Text = "Delta";
			// 
			// lbl_NextVIs
			// 
			this.lbl_NextVIs.AutoSize = true;
			this.lbl_NextVIs.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_NextVIs.Location = new System.Drawing.Point(83, 70);
			this.lbl_NextVIs.Name = "lbl_NextVIs";
			this.lbl_NextVIs.Size = new System.Drawing.Size(40, 27);
			this.lbl_NextVIs.TabIndex = 7;
			this.lbl_NextVIs.Text = "VIs";
			// 
			// lbl_NextName
			// 
			this.lbl_NextName.AutoSize = true;
			this.lbl_NextName.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_NextName.Location = new System.Drawing.Point(83, 43);
			this.lbl_NextName.Name = "lbl_NextName";
			this.lbl_NextName.Size = new System.Drawing.Size(65, 27);
			this.lbl_NextName.TabIndex = 6;
			this.lbl_NextName.Text = "Name";
			// 
			// lbl_NextRank
			// 
			this.lbl_NextRank.AutoSize = true;
			this.lbl_NextRank.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_NextRank.Location = new System.Drawing.Point(83, 16);
			this.lbl_NextRank.Name = "lbl_NextRank";
			this.lbl_NextRank.Size = new System.Drawing.Size(56, 27);
			this.lbl_NextRank.TabIndex = 5;
			this.lbl_NextRank.Text = "Rank";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 27);
			this.label11.TabIndex = 4;
			this.label11.Text = "Rank:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 124);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 27);
			this.label12.TabIndex = 3;
			this.label12.Text = "Time:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 97);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 27);
			this.label13.TabIndex = 2;
			this.label13.Text = "Delta:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 70);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(46, 27);
			this.label14.TabIndex = 1;
			this.label14.Text = "VIs:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Super Mario Odyssey", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 43);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(71, 27);
			this.label15.TabIndex = 0;
			this.label15.Text = "Name:";
			// 
			// chk_EnableNextRun
			// 
			this.chk_EnableNextRun.AutoSize = true;
			this.chk_EnableNextRun.Location = new System.Drawing.Point(368, 158);
			this.chk_EnableNextRun.Name = "chk_EnableNextRun";
			this.chk_EnableNextRun.Size = new System.Drawing.Size(59, 17);
			this.chk_EnableNextRun.TabIndex = 8;
			this.chk_EnableNextRun.Text = "Enable";
			this.chk_EnableNextRun.UseVisualStyleBackColor = true;
			this.chk_EnableNextRun.CheckedChanged += new System.EventHandler(this.chk_EnableNextRun_CheckedChanged);
			// 
			// frm_LiveDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 333);
			this.Controls.Add(this.chk_EnableNextRun);
			this.Controls.Add(this.gb_NextRun);
			this.Controls.Add(this.gb_CurrentRun);
			this.Controls.Add(this.btn_Next);
			this.Controls.Add(this.btn_Previous);
			this.Controls.Add(this.lbl_Display);
			this.Controls.Add(this.lbl_Prefix);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm_LiveDisplay";
			this.Text = "Live Display";
			this.Load += new System.EventHandler(this.frm_LiveDisplay_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gb_CurrentRun.ResumeLayout(false);
			this.gb_CurrentRun.PerformLayout();
			this.gb_NextRun.ResumeLayout(false);
			this.gb_NextRun.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbl_Prefix;
		private System.Windows.Forms.Label lbl_Display;
		private System.Windows.Forms.Button btn_Previous;
		private System.Windows.Forms.Button btn_Next;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeOutputDirectoryToolStripMenuItem;
		private System.Windows.Forms.GroupBox gb_CurrentRun;
		private System.Windows.Forms.Label lbl_Time;
		private System.Windows.Forms.Label lbl_Delta;
		private System.Windows.Forms.Label lbl_VIs;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Label lbl_Rank;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gb_NextRun;
		private System.Windows.Forms.Label lbl_NextTime;
		private System.Windows.Forms.Label lbl_NextDelta;
		private System.Windows.Forms.Label lbl_NextVIs;
		private System.Windows.Forms.Label lbl_NextName;
		private System.Windows.Forms.Label lbl_NextRank;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox chk_EnableNextRun;
	}
}
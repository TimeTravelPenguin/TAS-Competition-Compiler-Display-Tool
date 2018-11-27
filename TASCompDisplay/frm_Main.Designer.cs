namespace TASCompDisplay
{
	partial class fm_Main
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_CurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_OpenedFile = new System.Windows.Forms.ToolStripStatusLabel();
			this.txt_addUsername = new System.Windows.Forms.TextBox();
			this.txt_addStartFrame = new System.Windows.Forms.TextBox();
			this.txt_addEndFrame = new System.Windows.Forms.TextBox();
			this.txt_addRerecords = new System.Windows.Forms.TextBox();
			this.checkBox_DQ = new System.Windows.Forms.CheckBox();
			this.groupBox_DQReasons = new System.Windows.Forms.GroupBox();
			this.lbl_DQ_Other = new System.Windows.Forms.Label();
			this.txt_DQ_Other = new System.Windows.Forms.TextBox();
			this.chk_DQ_Desync = new System.Windows.Forms.CheckBox();
			this.chk_DQ_StratTalk = new System.Windows.Forms.CheckBox();
			this.chk_DQ_Other = new System.Windows.Forms.CheckBox();
			this.chk_DQ_FailedGoal = new System.Windows.Forms.CheckBox();
			this.chk_DQ_M64Early = new System.Windows.Forms.CheckBox();
			this.chk_DQ_IllegalInteraction = new System.Windows.Forms.CheckBox();
			this.lbl_addUsername = new System.Windows.Forms.Label();
			this.lbl_addStarting = new System.Windows.Forms.Label();
			this.lbl_addEnding = new System.Windows.Forms.Label();
			this.lbl_addRerecords = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_TASData = new System.Windows.Forms.DataGridView();
			this.btn_AddCompetitor = new System.Windows.Forms.Button();
			this.rerankBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartingFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndingFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rerecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DQ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DQReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox_DQReasons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TASData)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.rerankBoardToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(868, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_CurrentFile,
            this.toolStripStatusLabel_OpenedFile});
			this.statusStrip1.Location = new System.Drawing.Point(0, 356);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(868, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel_CurrentFile
			// 
			this.toolStripStatusLabel_CurrentFile.Name = "toolStripStatusLabel_CurrentFile";
			this.toolStripStatusLabel_CurrentFile.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel_OpenedFile
			// 
			this.toolStripStatusLabel_OpenedFile.Name = "toolStripStatusLabel_OpenedFile";
			this.toolStripStatusLabel_OpenedFile.Size = new System.Drawing.Size(85, 17);
			this.toolStripStatusLabel_OpenedFile.Text = "No file opened";
			// 
			// txt_addUsername
			// 
			this.txt_addUsername.Location = new System.Drawing.Point(93, 64);
			this.txt_addUsername.Name = "txt_addUsername";
			this.txt_addUsername.Size = new System.Drawing.Size(132, 20);
			this.txt_addUsername.TabIndex = 6;
			// 
			// txt_addStartFrame
			// 
			this.txt_addStartFrame.Location = new System.Drawing.Point(93, 90);
			this.txt_addStartFrame.Name = "txt_addStartFrame";
			this.txt_addStartFrame.Size = new System.Drawing.Size(132, 20);
			this.txt_addStartFrame.TabIndex = 7;
			// 
			// txt_addEndFrame
			// 
			this.txt_addEndFrame.Location = new System.Drawing.Point(93, 116);
			this.txt_addEndFrame.Name = "txt_addEndFrame";
			this.txt_addEndFrame.Size = new System.Drawing.Size(132, 20);
			this.txt_addEndFrame.TabIndex = 8;
			// 
			// txt_addRerecords
			// 
			this.txt_addRerecords.Location = new System.Drawing.Point(93, 142);
			this.txt_addRerecords.Name = "txt_addRerecords";
			this.txt_addRerecords.Size = new System.Drawing.Size(132, 20);
			this.txt_addRerecords.TabIndex = 9;
			// 
			// checkBox_DQ
			// 
			this.checkBox_DQ.AutoSize = true;
			this.checkBox_DQ.Location = new System.Drawing.Point(5, 168);
			this.checkBox_DQ.Name = "checkBox_DQ";
			this.checkBox_DQ.Size = new System.Drawing.Size(56, 17);
			this.checkBox_DQ.TabIndex = 10;
			this.checkBox_DQ.Text = "DQ\'d?";
			this.checkBox_DQ.UseVisualStyleBackColor = true;
			this.checkBox_DQ.CheckedChanged += new System.EventHandler(this.checkBox_DQ_CheckedChanged);
			// 
			// groupBox_DQReasons
			// 
			this.groupBox_DQReasons.Controls.Add(this.lbl_DQ_Other);
			this.groupBox_DQReasons.Controls.Add(this.txt_DQ_Other);
			this.groupBox_DQReasons.Controls.Add(this.chk_DQ_Desync);
			this.groupBox_DQReasons.Controls.Add(this.chk_DQ_StratTalk);
			this.groupBox_DQReasons.Controls.Add(this.chk_DQ_Other);
			this.groupBox_DQReasons.Controls.Add(this.chk_DQ_FailedGoal);
			this.groupBox_DQReasons.Controls.Add(this.chk_DQ_M64Early);
			this.groupBox_DQReasons.Controls.Add(this.chk_DQ_IllegalInteraction);
			this.groupBox_DQReasons.Enabled = false;
			this.groupBox_DQReasons.Location = new System.Drawing.Point(5, 191);
			this.groupBox_DQReasons.Name = "groupBox_DQReasons";
			this.groupBox_DQReasons.Size = new System.Drawing.Size(220, 161);
			this.groupBox_DQReasons.TabIndex = 11;
			this.groupBox_DQReasons.TabStop = false;
			this.groupBox_DQReasons.Text = "DQ Reason";
			// 
			// lbl_DQ_Other
			// 
			this.lbl_DQ_Other.AutoSize = true;
			this.lbl_DQ_Other.Location = new System.Drawing.Point(6, 85);
			this.lbl_DQ_Other.Name = "lbl_DQ_Other";
			this.lbl_DQ_Other.Size = new System.Drawing.Size(47, 13);
			this.lbl_DQ_Other.TabIndex = 7;
			this.lbl_DQ_Other.Text = "Reason:";
			// 
			// txt_DQ_Other
			// 
			this.txt_DQ_Other.Enabled = false;
			this.txt_DQ_Other.Location = new System.Drawing.Point(7, 101);
			this.txt_DQ_Other.Multiline = true;
			this.txt_DQ_Other.Name = "txt_DQ_Other";
			this.txt_DQ_Other.Size = new System.Drawing.Size(207, 54);
			this.txt_DQ_Other.TabIndex = 6;
			// 
			// chk_DQ_Desync
			// 
			this.chk_DQ_Desync.AutoSize = true;
			this.chk_DQ_Desync.Location = new System.Drawing.Point(115, 65);
			this.chk_DQ_Desync.Name = "chk_DQ_Desync";
			this.chk_DQ_Desync.Size = new System.Drawing.Size(62, 17);
			this.chk_DQ_Desync.TabIndex = 5;
			this.chk_DQ_Desync.Text = "Desync";
			this.chk_DQ_Desync.UseVisualStyleBackColor = true;
			// 
			// chk_DQ_StratTalk
			// 
			this.chk_DQ_StratTalk.AutoSize = true;
			this.chk_DQ_StratTalk.Location = new System.Drawing.Point(115, 19);
			this.chk_DQ_StratTalk.Name = "chk_DQ_StratTalk";
			this.chk_DQ_StratTalk.Size = new System.Drawing.Size(68, 17);
			this.chk_DQ_StratTalk.TabIndex = 3;
			this.chk_DQ_StratTalk.Text = "Strat talk";
			this.chk_DQ_StratTalk.UseVisualStyleBackColor = true;
			// 
			// chk_DQ_Other
			// 
			this.chk_DQ_Other.AutoSize = true;
			this.chk_DQ_Other.Location = new System.Drawing.Point(6, 65);
			this.chk_DQ_Other.Name = "chk_DQ_Other";
			this.chk_DQ_Other.Size = new System.Drawing.Size(52, 17);
			this.chk_DQ_Other.TabIndex = 2;
			this.chk_DQ_Other.Text = "Other";
			this.chk_DQ_Other.UseVisualStyleBackColor = true;
			this.chk_DQ_Other.CheckedChanged += new System.EventHandler(this.chk_DQ_Other_CheckedChanged);
			// 
			// chk_DQ_FailedGoal
			// 
			this.chk_DQ_FailedGoal.AutoSize = true;
			this.chk_DQ_FailedGoal.Location = new System.Drawing.Point(6, 42);
			this.chk_DQ_FailedGoal.Name = "chk_DQ_FailedGoal";
			this.chk_DQ_FailedGoal.Size = new System.Drawing.Size(100, 17);
			this.chk_DQ_FailedGoal.TabIndex = 1;
			this.chk_DQ_FailedGoal.Text = "Failed task goal";
			this.chk_DQ_FailedGoal.UseVisualStyleBackColor = true;
			// 
			// chk_DQ_M64Early
			// 
			this.chk_DQ_M64Early.AutoSize = true;
			this.chk_DQ_M64Early.Location = new System.Drawing.Point(115, 42);
			this.chk_DQ_M64Early.Name = "chk_DQ_M64Early";
			this.chk_DQ_M64Early.Size = new System.Drawing.Size(100, 17);
			this.chk_DQ_M64Early.TabIndex = 0;
			this.chk_DQ_M64Early.Text = ".m64 ends early";
			this.chk_DQ_M64Early.UseVisualStyleBackColor = true;
			// 
			// chk_DQ_IllegalInteraction
			// 
			this.chk_DQ_IllegalInteraction.AutoSize = true;
			this.chk_DQ_IllegalInteraction.Location = new System.Drawing.Point(6, 19);
			this.chk_DQ_IllegalInteraction.Name = "chk_DQ_IllegalInteraction";
			this.chk_DQ_IllegalInteraction.Size = new System.Drawing.Size(105, 17);
			this.chk_DQ_IllegalInteraction.TabIndex = 4;
			this.chk_DQ_IllegalInteraction.Text = "Illegal interaction";
			this.chk_DQ_IllegalInteraction.UseVisualStyleBackColor = true;
			// 
			// lbl_addUsername
			// 
			this.lbl_addUsername.AutoSize = true;
			this.lbl_addUsername.Location = new System.Drawing.Point(2, 67);
			this.lbl_addUsername.Name = "lbl_addUsername";
			this.lbl_addUsername.Size = new System.Drawing.Size(58, 13);
			this.lbl_addUsername.TabIndex = 12;
			this.lbl_addUsername.Text = "Username:";
			// 
			// lbl_addStarting
			// 
			this.lbl_addStarting.AutoSize = true;
			this.lbl_addStarting.Location = new System.Drawing.Point(2, 93);
			this.lbl_addStarting.Name = "lbl_addStarting";
			this.lbl_addStarting.Size = new System.Drawing.Size(78, 13);
			this.lbl_addStarting.TabIndex = 13;
			this.lbl_addStarting.Text = "Starting Frame:";
			// 
			// lbl_addEnding
			// 
			this.lbl_addEnding.AutoSize = true;
			this.lbl_addEnding.Location = new System.Drawing.Point(2, 119);
			this.lbl_addEnding.Name = "lbl_addEnding";
			this.lbl_addEnding.Size = new System.Drawing.Size(75, 13);
			this.lbl_addEnding.TabIndex = 14;
			this.lbl_addEnding.Text = "Ending Frame:";
			// 
			// lbl_addRerecords
			// 
			this.lbl_addRerecords.AutoSize = true;
			this.lbl_addRerecords.Location = new System.Drawing.Point(2, 145);
			this.lbl_addRerecords.Name = "lbl_addRerecords";
			this.lbl_addRerecords.Size = new System.Drawing.Size(59, 13);
			this.lbl_addRerecords.TabIndex = 15;
			this.lbl_addRerecords.Text = "Rerecords:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Super Mario Odyssey", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-2, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 37);
			this.label1.TabIndex = 16;
			this.label1.Text = "Add Competitor";
			// 
			// dataGrid_TASData
			// 
			this.dataGrid_TASData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_TASData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Username,
            this.StartingFrame,
            this.EndingFrame,
            this.Rerecords,
            this.DQ,
            this.DQReason});
			this.dataGrid_TASData.Location = new System.Drawing.Point(231, 24);
			this.dataGrid_TASData.Name = "dataGrid_TASData";
			this.dataGrid_TASData.Size = new System.Drawing.Size(634, 328);
			this.dataGrid_TASData.TabIndex = 17;
			// 
			// btn_AddCompetitor
			// 
			this.btn_AddCompetitor.Location = new System.Drawing.Point(93, 168);
			this.btn_AddCompetitor.Name = "btn_AddCompetitor";
			this.btn_AddCompetitor.Size = new System.Drawing.Size(132, 25);
			this.btn_AddCompetitor.TabIndex = 18;
			this.btn_AddCompetitor.Text = "Add";
			this.btn_AddCompetitor.UseVisualStyleBackColor = true;
			this.btn_AddCompetitor.Click += new System.EventHandler(this.btn_AddCompetitor_Click);
			// 
			// rerankBoardToolStripMenuItem
			// 
			this.rerankBoardToolStripMenuItem.Name = "rerankBoardToolStripMenuItem";
			this.rerankBoardToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.rerankBoardToolStripMenuItem.Text = "&Rerank Board";
			this.rerankBoardToolStripMenuItem.Click += new System.EventHandler(this.rerankBoardToolStripMenuItem_Click);
			// 
			// Place
			// 
			this.Place.HeaderText = "Place";
			this.Place.Name = "Place";
			this.Place.ReadOnly = true;
			this.Place.Width = 50;
			// 
			// Username
			// 
			this.Username.HeaderText = "Username";
			this.Username.Name = "Username";
			// 
			// StartingFrame
			// 
			this.StartingFrame.HeaderText = "Starting Frame";
			this.StartingFrame.Name = "StartingFrame";
			// 
			// EndingFrame
			// 
			this.EndingFrame.HeaderText = "Ending Frame";
			this.EndingFrame.Name = "EndingFrame";
			// 
			// Rerecords
			// 
			this.Rerecords.HeaderText = "Rerecords";
			this.Rerecords.Name = "Rerecords";
			this.Rerecords.Width = 80;
			// 
			// DQ
			// 
			this.DQ.HeaderText = "DQ";
			this.DQ.Name = "DQ";
			this.DQ.Width = 50;
			// 
			// DQReason
			// 
			this.DQReason.HeaderText = "DQ Reason";
			this.DQReason.Name = "DQReason";
			this.DQReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DQReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DQReason.Width = 110;
			// 
			// fm_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 378);
			this.Controls.Add(this.btn_AddCompetitor);
			this.Controls.Add(this.dataGrid_TASData);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_addRerecords);
			this.Controls.Add(this.lbl_addEnding);
			this.Controls.Add(this.lbl_addStarting);
			this.Controls.Add(this.lbl_addUsername);
			this.Controls.Add(this.groupBox_DQReasons);
			this.Controls.Add(this.checkBox_DQ);
			this.Controls.Add(this.txt_addRerecords);
			this.Controls.Add(this.txt_addEndFrame);
			this.Controls.Add(this.txt_addStartFrame);
			this.Controls.Add(this.txt_addUsername);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fm_Main";
			this.Text = "TAS Comp Display Tool";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox_DQReasons.ResumeLayout(false);
			this.groupBox_DQReasons.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TASData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CurrentFile;
		private System.Windows.Forms.TextBox txt_addUsername;
		private System.Windows.Forms.TextBox txt_addStartFrame;
		private System.Windows.Forms.TextBox txt_addEndFrame;
		private System.Windows.Forms.TextBox txt_addRerecords;
		private System.Windows.Forms.CheckBox checkBox_DQ;
		private System.Windows.Forms.GroupBox groupBox_DQReasons;
		private System.Windows.Forms.Label lbl_addUsername;
		private System.Windows.Forms.Label lbl_addStarting;
		private System.Windows.Forms.Label lbl_addEnding;
		private System.Windows.Forms.Label lbl_addRerecords;
		private System.Windows.Forms.CheckBox chk_DQ_M64Early;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGrid_TASData;
		private System.Windows.Forms.Label lbl_DQ_Other;
		private System.Windows.Forms.TextBox txt_DQ_Other;
		private System.Windows.Forms.CheckBox chk_DQ_Desync;
		private System.Windows.Forms.CheckBox chk_DQ_IllegalInteraction;
		private System.Windows.Forms.CheckBox chk_DQ_StratTalk;
		private System.Windows.Forms.CheckBox chk_DQ_Other;
		private System.Windows.Forms.CheckBox chk_DQ_FailedGoal;
		private System.Windows.Forms.Button btn_AddCompetitor;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_OpenedFile;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rerankBoardToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Place;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartingFrame;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndingFrame;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rerecords;
		private System.Windows.Forms.DataGridViewCheckBoxColumn DQ;
		private System.Windows.Forms.DataGridViewTextBoxColumn DQReason;
	}
}


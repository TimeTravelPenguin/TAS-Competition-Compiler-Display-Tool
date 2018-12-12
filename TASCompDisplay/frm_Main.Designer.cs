namespace TASCompDisplay
{
	partial class frm_Main
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
			this.competitionLeaderboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pointLeaderboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.competitionLeaderboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointLeaderboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.competitionLeaderboardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.pointLeaderboardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.rerankBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scorePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.liveDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.graphDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.leaderboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointLeaderboardToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
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
			this.lbl_AddCompetitor = new System.Windows.Forms.Label();
			this.dataGrid_TASData = new System.Windows.Forms.DataGridView();
			this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartingFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndingFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Frames = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rerecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DQ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DQReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_AddCompetitor = new System.Windows.Forms.Button();
			this.tab_DataGrids = new System.Windows.Forms.TabControl();
			this.tab_CompLeaderboard = new System.Windows.Forms.TabPage();
			this.tab_PointLeaderboard = new System.Windows.Forms.TabPage();
			this.dataGrid_TASPoints = new System.Windows.Forms.DataGridView();
			this.PointPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PointUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PointScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.plainTextImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox_DQReasons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TASData)).BeginInit();
			this.tab_DataGrids.SuspendLayout();
			this.tab_CompLeaderboard.SuspendLayout();
			this.tab_PointLeaderboard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TASPoints)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exportPlainTextToolStripMenuItem,
            this.plainTextImportToolStripMenuItem,
            this.rerankBoardToolStripMenuItem,
            this.scorePointsToolStripMenuItem,
            this.liveDisplayToolStripMenuItem,
            this.dataAnalysisToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(942, 24);
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
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.competitionLeaderboardToolStripMenuItem1,
            this.pointLeaderboardToolStripMenuItem1});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "&Open";
			// 
			// competitionLeaderboardToolStripMenuItem1
			// 
			this.competitionLeaderboardToolStripMenuItem1.Name = "competitionLeaderboardToolStripMenuItem1";
			this.competitionLeaderboardToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.competitionLeaderboardToolStripMenuItem1.Text = "Competition Leaderboard";
			this.competitionLeaderboardToolStripMenuItem1.Click += new System.EventHandler(this.competitionLeaderboardToolStripMenuItem1_Click);
			// 
			// pointLeaderboardToolStripMenuItem1
			// 
			this.pointLeaderboardToolStripMenuItem1.Name = "pointLeaderboardToolStripMenuItem1";
			this.pointLeaderboardToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
			this.pointLeaderboardToolStripMenuItem1.Text = "Point Leaderboard";
			this.pointLeaderboardToolStripMenuItem1.Click += new System.EventHandler(this.pointLeaderboardToolStripMenuItem1_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.competitionLeaderboardToolStripMenuItem,
            this.pointLeaderboardToolStripMenuItem});
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// competitionLeaderboardToolStripMenuItem
			// 
			this.competitionLeaderboardToolStripMenuItem.Name = "competitionLeaderboardToolStripMenuItem";
			this.competitionLeaderboardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.competitionLeaderboardToolStripMenuItem.Text = "Competition Leaderboard";
			this.competitionLeaderboardToolStripMenuItem.Click += new System.EventHandler(this.competitionLeaderboardToolStripMenuItem_Click);
			// 
			// pointLeaderboardToolStripMenuItem
			// 
			this.pointLeaderboardToolStripMenuItem.Name = "pointLeaderboardToolStripMenuItem";
			this.pointLeaderboardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.pointLeaderboardToolStripMenuItem.Text = "Point Leaderboard";
			this.pointLeaderboardToolStripMenuItem.Click += new System.EventHandler(this.pointLeaderboardToolStripMenuItem_Click);
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
			// exportPlainTextToolStripMenuItem
			// 
			this.exportPlainTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.competitionLeaderboardToolStripMenuItem2,
            this.pointLeaderboardToolStripMenuItem2});
			this.exportPlainTextToolStripMenuItem.Name = "exportPlainTextToolStripMenuItem";
			this.exportPlainTextToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.exportPlainTextToolStripMenuItem.Text = "&Export Plain Text";
			// 
			// competitionLeaderboardToolStripMenuItem2
			// 
			this.competitionLeaderboardToolStripMenuItem2.Name = "competitionLeaderboardToolStripMenuItem2";
			this.competitionLeaderboardToolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
			this.competitionLeaderboardToolStripMenuItem2.Text = "Competition Leaderboard";
			this.competitionLeaderboardToolStripMenuItem2.Click += new System.EventHandler(this.competitionLeaderboardToolStripMenuItem2_Click);
			// 
			// pointLeaderboardToolStripMenuItem2
			// 
			this.pointLeaderboardToolStripMenuItem2.Name = "pointLeaderboardToolStripMenuItem2";
			this.pointLeaderboardToolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
			this.pointLeaderboardToolStripMenuItem2.Text = "Point Leaderboard";
			this.pointLeaderboardToolStripMenuItem2.Click += new System.EventHandler(this.pointLeaderboardToolStripMenuItem2_Click);
			// 
			// rerankBoardToolStripMenuItem
			// 
			this.rerankBoardToolStripMenuItem.Name = "rerankBoardToolStripMenuItem";
			this.rerankBoardToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.rerankBoardToolStripMenuItem.Text = "&Rerank Board";
			this.rerankBoardToolStripMenuItem.Click += new System.EventHandler(this.rerankBoardToolStripMenuItem_Click);
			// 
			// scorePointsToolStripMenuItem
			// 
			this.scorePointsToolStripMenuItem.Name = "scorePointsToolStripMenuItem";
			this.scorePointsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.scorePointsToolStripMenuItem.Text = "&Score Points";
			this.scorePointsToolStripMenuItem.Click += new System.EventHandler(this.scorePointsToolStripMenuItem_Click);
			// 
			// liveDisplayToolStripMenuItem
			// 
			this.liveDisplayToolStripMenuItem.Name = "liveDisplayToolStripMenuItem";
			this.liveDisplayToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.liveDisplayToolStripMenuItem.Text = "&Live Display";
			this.liveDisplayToolStripMenuItem.Click += new System.EventHandler(this.liveDisplayToolStripMenuItem_Click);
			// 
			// dataAnalysisToolStripMenuItem
			// 
			this.dataAnalysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphDisplayToolStripMenuItem});
			this.dataAnalysisToolStripMenuItem.Name = "dataAnalysisToolStripMenuItem";
			this.dataAnalysisToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.dataAnalysisToolStripMenuItem.Text = "&Data Analysis (beta)";
			// 
			// graphDisplayToolStripMenuItem
			// 
			this.graphDisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderboardToolStripMenuItem,
            this.pointLeaderboardToolStripMenuItem3});
			this.graphDisplayToolStripMenuItem.Name = "graphDisplayToolStripMenuItem";
			this.graphDisplayToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.graphDisplayToolStripMenuItem.Text = "Graph Display";
			// 
			// leaderboardToolStripMenuItem
			// 
			this.leaderboardToolStripMenuItem.Name = "leaderboardToolStripMenuItem";
			this.leaderboardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.leaderboardToolStripMenuItem.Text = "Competition Leaderboard";
			this.leaderboardToolStripMenuItem.Click += new System.EventHandler(this.leaderboardToolStripMenuItem_Click);
			// 
			// pointLeaderboardToolStripMenuItem3
			// 
			this.pointLeaderboardToolStripMenuItem3.Name = "pointLeaderboardToolStripMenuItem3";
			this.pointLeaderboardToolStripMenuItem3.Size = new System.Drawing.Size(210, 22);
			this.pointLeaderboardToolStripMenuItem3.Text = "Point Leaderboard";
			this.pointLeaderboardToolStripMenuItem3.Click += new System.EventHandler(this.pointLeaderboardToolStripMenuItem3_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_CurrentFile,
            this.toolStripStatusLabel_OpenedFile});
			this.statusStrip1.Location = new System.Drawing.Point(0, 356);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(942, 22);
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
			this.lbl_addStarting.Size = new System.Drawing.Size(59, 13);
			this.lbl_addStarting.TabIndex = 13;
			this.lbl_addStarting.Text = "Starting VI:";
			// 
			// lbl_addEnding
			// 
			this.lbl_addEnding.AutoSize = true;
			this.lbl_addEnding.Location = new System.Drawing.Point(2, 119);
			this.lbl_addEnding.Name = "lbl_addEnding";
			this.lbl_addEnding.Size = new System.Drawing.Size(56, 13);
			this.lbl_addEnding.TabIndex = 14;
			this.lbl_addEnding.Text = "Ending VI:";
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
			// lbl_AddCompetitor
			// 
			this.lbl_AddCompetitor.AutoSize = true;
			this.lbl_AddCompetitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_AddCompetitor.Location = new System.Drawing.Point(28, 29);
			this.lbl_AddCompetitor.Name = "lbl_AddCompetitor";
			this.lbl_AddCompetitor.Size = new System.Drawing.Size(174, 25);
			this.lbl_AddCompetitor.TabIndex = 16;
			this.lbl_AddCompetitor.Text = "Add Competitor";
			// 
			// dataGrid_TASData
			// 
			this.dataGrid_TASData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_TASData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Username,
            this.StartingFrame,
            this.EndingFrame,
            this.Frames,
            this.Rerecords,
            this.DQ,
            this.DQReason});
			this.dataGrid_TASData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid_TASData.Location = new System.Drawing.Point(3, 3);
			this.dataGrid_TASData.Name = "dataGrid_TASData";
			this.dataGrid_TASData.Size = new System.Drawing.Size(693, 294);
			this.dataGrid_TASData.TabIndex = 17;
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
			this.StartingFrame.HeaderText = "Starting VI";
			this.StartingFrame.Name = "StartingFrame";
			// 
			// EndingFrame
			// 
			this.EndingFrame.HeaderText = "Ending VI";
			this.EndingFrame.Name = "EndingFrame";
			// 
			// Frames
			// 
			this.Frames.HeaderText = "VIs";
			this.Frames.Name = "Frames";
			this.Frames.ReadOnly = true;
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
			this.DQReason.Width = 150;
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
			// tab_DataGrids
			// 
			this.tab_DataGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tab_DataGrids.Controls.Add(this.tab_CompLeaderboard);
			this.tab_DataGrids.Controls.Add(this.tab_PointLeaderboard);
			this.tab_DataGrids.Location = new System.Drawing.Point(231, 27);
			this.tab_DataGrids.Name = "tab_DataGrids";
			this.tab_DataGrids.SelectedIndex = 0;
			this.tab_DataGrids.Size = new System.Drawing.Size(707, 326);
			this.tab_DataGrids.TabIndex = 19;
			// 
			// tab_CompLeaderboard
			// 
			this.tab_CompLeaderboard.Controls.Add(this.dataGrid_TASData);
			this.tab_CompLeaderboard.Location = new System.Drawing.Point(4, 22);
			this.tab_CompLeaderboard.Name = "tab_CompLeaderboard";
			this.tab_CompLeaderboard.Padding = new System.Windows.Forms.Padding(3);
			this.tab_CompLeaderboard.Size = new System.Drawing.Size(699, 300);
			this.tab_CompLeaderboard.TabIndex = 0;
			this.tab_CompLeaderboard.Text = "Competition Leaderboard";
			this.tab_CompLeaderboard.UseVisualStyleBackColor = true;
			// 
			// tab_PointLeaderboard
			// 
			this.tab_PointLeaderboard.Controls.Add(this.dataGrid_TASPoints);
			this.tab_PointLeaderboard.Location = new System.Drawing.Point(4, 22);
			this.tab_PointLeaderboard.Name = "tab_PointLeaderboard";
			this.tab_PointLeaderboard.Padding = new System.Windows.Forms.Padding(3);
			this.tab_PointLeaderboard.Size = new System.Drawing.Size(699, 300);
			this.tab_PointLeaderboard.TabIndex = 1;
			this.tab_PointLeaderboard.Text = "Point Leaderboard";
			this.tab_PointLeaderboard.UseVisualStyleBackColor = true;
			// 
			// dataGrid_TASPoints
			// 
			this.dataGrid_TASPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_TASPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PointPlace,
            this.PointUsername,
            this.PointScore});
			this.dataGrid_TASPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid_TASPoints.Location = new System.Drawing.Point(3, 3);
			this.dataGrid_TASPoints.Name = "dataGrid_TASPoints";
			this.dataGrid_TASPoints.Size = new System.Drawing.Size(693, 294);
			this.dataGrid_TASPoints.TabIndex = 0;
			// 
			// PointPlace
			// 
			this.PointPlace.HeaderText = "Place";
			this.PointPlace.Name = "PointPlace";
			this.PointPlace.Width = 50;
			// 
			// PointUsername
			// 
			this.PointUsername.HeaderText = "Username";
			this.PointUsername.Name = "PointUsername";
			// 
			// PointScore
			// 
			this.PointScore.HeaderText = "Score";
			this.PointScore.Name = "PointScore";
			// 
			// plainTextImportToolStripMenuItem
			// 
			this.plainTextImportToolStripMenuItem.Name = "plainTextImportToolStripMenuItem";
			this.plainTextImportToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.plainTextImportToolStripMenuItem.Text = "&Import Plain Text ";
			this.plainTextImportToolStripMenuItem.Click += new System.EventHandler(this.plainTextImportToolStripMenuItem_Click);
			// 
			// frm_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 378);
			this.Controls.Add(this.tab_DataGrids);
			this.Controls.Add(this.btn_AddCompetitor);
			this.Controls.Add(this.lbl_AddCompetitor);
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
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(958, 417);
			this.Name = "frm_Main";
			this.Text = "TAS Comp Display Tool";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox_DQReasons.ResumeLayout(false);
			this.groupBox_DQReasons.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TASData)).EndInit();
			this.tab_DataGrids.ResumeLayout(false);
			this.tab_CompLeaderboard.ResumeLayout(false);
			this.tab_PointLeaderboard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TASPoints)).EndInit();
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
		private System.Windows.Forms.Label lbl_AddCompetitor;
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
		private System.Windows.Forms.ToolStripMenuItem exportPlainTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scorePointsToolStripMenuItem;
		private System.Windows.Forms.TabControl tab_DataGrids;
		private System.Windows.Forms.TabPage tab_CompLeaderboard;
		private System.Windows.Forms.TabPage tab_PointLeaderboard;
		private System.Windows.Forms.DataGridView dataGrid_TASPoints;
		private System.Windows.Forms.DataGridViewTextBoxColumn PointPlace;
		private System.Windows.Forms.DataGridViewTextBoxColumn PointUsername;
		private System.Windows.Forms.DataGridViewTextBoxColumn PointScore;
		private System.Windows.Forms.ToolStripMenuItem competitionLeaderboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointLeaderboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem competitionLeaderboardToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pointLeaderboardToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem competitionLeaderboardToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem pointLeaderboardToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem liveDisplayToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Place;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartingFrame;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndingFrame;
		private System.Windows.Forms.DataGridViewTextBoxColumn Frames;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rerecords;
		private System.Windows.Forms.DataGridViewCheckBoxColumn DQ;
		private System.Windows.Forms.DataGridViewTextBoxColumn DQReason;
		private System.Windows.Forms.ToolStripMenuItem dataAnalysisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem graphDisplayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leaderboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointLeaderboardToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem plainTextImportToolStripMenuItem;
	}
}


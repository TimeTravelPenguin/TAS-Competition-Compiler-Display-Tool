namespace TASCompDisplay
{
	partial class frm_GraphDisplay
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.InformationGroupBox = new System.Windows.Forms.GroupBox();
			this.lbl_data_population = new System.Windows.Forms.Label();
			this.lbl_data_average = new System.Windows.Forms.Label();
			this.lbl_data_min = new System.Windows.Forms.Label();
			this.lbl_data_standarddiv = new System.Windows.Forms.Label();
			this.lbl_data_max = new System.Windows.Forms.Label();
			this.lbl_data_range = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
			this.InformationGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartGraph
			// 
			chartArea2.Name = "ChartArea1";
			this.chartGraph.ChartAreas.Add(chartArea2);
			this.chartGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.chartGraph.Legends.Add(legend2);
			this.chartGraph.Location = new System.Drawing.Point(0, 0);
			this.chartGraph.Name = "chartGraph";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartGraph.Series.Add(series2);
			this.chartGraph.Size = new System.Drawing.Size(709, 522);
			this.chartGraph.TabIndex = 0;
			this.chartGraph.Text = "chart1";
			// 
			// InformationGroupBox
			// 
			this.InformationGroupBox.Controls.Add(this.lbl_data_range);
			this.InformationGroupBox.Controls.Add(this.lbl_data_max);
			this.InformationGroupBox.Controls.Add(this.lbl_data_standarddiv);
			this.InformationGroupBox.Controls.Add(this.lbl_data_min);
			this.InformationGroupBox.Controls.Add(this.lbl_data_average);
			this.InformationGroupBox.Controls.Add(this.lbl_data_population);
			this.InformationGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.InformationGroupBox.Location = new System.Drawing.Point(709, 0);
			this.InformationGroupBox.Name = "InformationGroupBox";
			this.InformationGroupBox.Size = new System.Drawing.Size(220, 522);
			this.InformationGroupBox.TabIndex = 1;
			this.InformationGroupBox.TabStop = false;
			this.InformationGroupBox.Text = "Data Information";
			// 
			// lbl_data_population
			// 
			this.lbl_data_population.AutoSize = true;
			this.lbl_data_population.Location = new System.Drawing.Point(6, 34);
			this.lbl_data_population.Name = "lbl_data_population";
			this.lbl_data_population.Size = new System.Drawing.Size(35, 13);
			this.lbl_data_population.TabIndex = 0;
			this.lbl_data_population.Text = "label1";
			// 
			// lbl_data_average
			// 
			this.lbl_data_average.AutoSize = true;
			this.lbl_data_average.Location = new System.Drawing.Point(6, 60);
			this.lbl_data_average.Name = "lbl_data_average";
			this.lbl_data_average.Size = new System.Drawing.Size(35, 13);
			this.lbl_data_average.TabIndex = 1;
			this.lbl_data_average.Text = "label2";
			// 
			// lbl_data_min
			// 
			this.lbl_data_min.AutoSize = true;
			this.lbl_data_min.Location = new System.Drawing.Point(6, 86);
			this.lbl_data_min.Name = "lbl_data_min";
			this.lbl_data_min.Size = new System.Drawing.Size(35, 13);
			this.lbl_data_min.TabIndex = 2;
			this.lbl_data_min.Text = "label3";
			// 
			// lbl_data_standarddiv
			// 
			this.lbl_data_standarddiv.AutoSize = true;
			this.lbl_data_standarddiv.Location = new System.Drawing.Point(6, 164);
			this.lbl_data_standarddiv.Name = "lbl_data_standarddiv";
			this.lbl_data_standarddiv.Size = new System.Drawing.Size(35, 13);
			this.lbl_data_standarddiv.TabIndex = 3;
			this.lbl_data_standarddiv.Text = "label5";
			// 
			// lbl_data_max
			// 
			this.lbl_data_max.AutoSize = true;
			this.lbl_data_max.Location = new System.Drawing.Point(6, 112);
			this.lbl_data_max.Name = "lbl_data_max";
			this.lbl_data_max.Size = new System.Drawing.Size(35, 13);
			this.lbl_data_max.TabIndex = 4;
			this.lbl_data_max.Text = "label3";
			// 
			// lbl_data_range
			// 
			this.lbl_data_range.AutoSize = true;
			this.lbl_data_range.Location = new System.Drawing.Point(6, 138);
			this.lbl_data_range.Name = "lbl_data_range";
			this.lbl_data_range.Size = new System.Drawing.Size(35, 13);
			this.lbl_data_range.TabIndex = 5;
			this.lbl_data_range.Text = "label5";
			// 
			// frm_GraphDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(929, 522);
			this.Controls.Add(this.chartGraph);
			this.Controls.Add(this.InformationGroupBox);
			this.Name = "frm_GraphDisplay";
			this.Text = "Graph and Information Display";
			this.Load += new System.EventHandler(this.GraphDisplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
			this.InformationGroupBox.ResumeLayout(false);
			this.InformationGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
		private System.Windows.Forms.GroupBox InformationGroupBox;
		private System.Windows.Forms.Label lbl_data_standarddiv;
		private System.Windows.Forms.Label lbl_data_min;
		private System.Windows.Forms.Label lbl_data_average;
		private System.Windows.Forms.Label lbl_data_population;
		private System.Windows.Forms.Label lbl_data_range;
		private System.Windows.Forms.Label lbl_data_max;
	}
}
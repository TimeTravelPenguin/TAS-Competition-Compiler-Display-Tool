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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// chartGraph
			// 
			chartArea1.Name = "ChartArea1";
			this.chartGraph.ChartAreas.Add(chartArea1);
			this.chartGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chartGraph.Legends.Add(legend1);
			this.chartGraph.Location = new System.Drawing.Point(0, 0);
			this.chartGraph.Name = "chartGraph";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartGraph.Series.Add(series1);
			this.chartGraph.Size = new System.Drawing.Size(719, 522);
			this.chartGraph.TabIndex = 0;
			this.chartGraph.Text = "chart1";
			// 
			// frm_GraphDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 522);
			this.Controls.Add(this.chartGraph);
			this.Name = "frm_GraphDisplay";
			this.Text = "GraphDisplay";
			this.Load += new System.EventHandler(this.GraphDisplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
	}
}
namespace _173311082_KemalKolcuoglu_PSO
{
	partial class pso_main_form
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
			this.gb_Params = new System.Windows.Forms.GroupBox();
			this.nud_pbest = new System.Windows.Forms.NumericUpDown();
			this.nud_gbest = new System.Windows.Forms.NumericUpDown();
			this.cb_function = new System.Windows.Forms.ComboBox();
			this.lb_function = new System.Windows.Forms.Label();
			this.lb_pbest = new System.Windows.Forms.Label();
			this.lb_gbest = new System.Windows.Forms.Label();
			this.nud_generation = new System.Windows.Forms.NumericUpDown();
			this.lb_generation = new System.Windows.Forms.Label();
			this.lb_swarm = new System.Windows.Forms.Label();
			this.nud_swarm = new System.Windows.Forms.NumericUpDown();
			this.btn_run = new System.Windows.Forms.Button();
			this.gb_chart = new System.Windows.Forms.GroupBox();
			this.chrt_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.gb_Params.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_pbest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_gbest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_generation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_swarm)).BeginInit();
			this.gb_chart.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chrt_graph)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_Params
			// 
			this.gb_Params.Controls.Add(this.nud_pbest);
			this.gb_Params.Controls.Add(this.nud_gbest);
			this.gb_Params.Controls.Add(this.cb_function);
			this.gb_Params.Controls.Add(this.lb_function);
			this.gb_Params.Controls.Add(this.lb_pbest);
			this.gb_Params.Controls.Add(this.lb_gbest);
			this.gb_Params.Controls.Add(this.nud_generation);
			this.gb_Params.Controls.Add(this.lb_generation);
			this.gb_Params.Controls.Add(this.lb_swarm);
			this.gb_Params.Controls.Add(this.nud_swarm);
			this.gb_Params.Location = new System.Drawing.Point(12, 12);
			this.gb_Params.Name = "gb_Params";
			this.gb_Params.Size = new System.Drawing.Size(206, 143);
			this.gb_Params.TabIndex = 0;
			this.gb_Params.TabStop = false;
			this.gb_Params.Text = "Parametreler";
			// 
			// nud_pbest
			// 
			this.nud_pbest.Location = new System.Drawing.Point(121, 91);
			this.nud_pbest.Name = "nud_pbest";
			this.nud_pbest.Size = new System.Drawing.Size(76, 20);
			this.nud_pbest.TabIndex = 10;
			this.nud_pbest.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// nud_gbest
			// 
			this.nud_gbest.Location = new System.Drawing.Point(121, 68);
			this.nud_gbest.Name = "nud_gbest";
			this.nud_gbest.Size = new System.Drawing.Size(76, 20);
			this.nud_gbest.TabIndex = 9;
			this.nud_gbest.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// cb_function
			// 
			this.cb_function.FormattingEnabled = true;
			this.cb_function.Items.AddRange(new object[] {
            "F1",
            "F2"});
			this.cb_function.Location = new System.Drawing.Point(121, 114);
			this.cb_function.Name = "cb_function";
			this.cb_function.Size = new System.Drawing.Size(76, 21);
			this.cb_function.TabIndex = 8;
			this.cb_function.Text = "F1";
			// 
			// lb_function
			// 
			this.lb_function.AutoSize = true;
			this.lb_function.Location = new System.Drawing.Point(27, 117);
			this.lb_function.Name = "lb_function";
			this.lb_function.Size = new System.Drawing.Size(88, 13);
			this.lb_function.TabIndex = 7;
			this.lb_function.Text = "Test Fonksiyonu:";
			// 
			// lb_pbest
			// 
			this.lb_pbest.AutoSize = true;
			this.lb_pbest.Location = new System.Drawing.Point(10, 93);
			this.lb_pbest.Name = "lb_pbest";
			this.lb_pbest.Size = new System.Drawing.Size(105, 13);
			this.lb_pbest.TabIndex = 6;
			this.lb_pbest.Text = "pbest İçin Fakt. (C2):";
			// 
			// lb_gbest
			// 
			this.lb_gbest.AutoSize = true;
			this.lb_gbest.Location = new System.Drawing.Point(10, 70);
			this.lb_gbest.Name = "lb_gbest";
			this.lb_gbest.Size = new System.Drawing.Size(105, 13);
			this.lb_gbest.TabIndex = 5;
			this.lb_gbest.Text = "gbest İçin Fakt. (C1):";
			// 
			// nud_generation
			// 
			this.nud_generation.Location = new System.Drawing.Point(121, 45);
			this.nud_generation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_generation.Name = "nud_generation";
			this.nud_generation.Size = new System.Drawing.Size(76, 20);
			this.nud_generation.TabIndex = 4;
			this.nud_generation.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// lb_generation
			// 
			this.lb_generation.AutoSize = true;
			this.lb_generation.Location = new System.Drawing.Point(4, 47);
			this.lb_generation.Name = "lb_generation";
			this.lb_generation.Size = new System.Drawing.Size(111, 13);
			this.lb_generation.TabIndex = 3;
			this.lb_generation.Text = "Jenerasyon Sayısı (G):";
			// 
			// lb_swarm
			// 
			this.lb_swarm.AutoSize = true;
			this.lb_swarm.Location = new System.Drawing.Point(16, 23);
			this.lb_swarm.Name = "lb_swarm";
			this.lb_swarm.Size = new System.Drawing.Size(99, 13);
			this.lb_swarm.TabIndex = 2;
			this.lb_swarm.Text = "Parçacık Sayısı (N):";
			// 
			// nud_swarm
			// 
			this.nud_swarm.Location = new System.Drawing.Point(121, 21);
			this.nud_swarm.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nud_swarm.Name = "nud_swarm";
			this.nud_swarm.Size = new System.Drawing.Size(76, 20);
			this.nud_swarm.TabIndex = 1;
			this.nud_swarm.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// btn_run
			// 
			this.btn_run.Location = new System.Drawing.Point(12, 161);
			this.btn_run.Name = "btn_run";
			this.btn_run.Size = new System.Drawing.Size(206, 23);
			this.btn_run.TabIndex = 1;
			this.btn_run.Text = "Hesapla";
			this.btn_run.UseVisualStyleBackColor = true;
			this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
			// 
			// gb_chart
			// 
			this.gb_chart.Controls.Add(this.chrt_graph);
			this.gb_chart.Location = new System.Drawing.Point(224, 12);
			this.gb_chart.Name = "gb_chart";
			this.gb_chart.Size = new System.Drawing.Size(567, 426);
			this.gb_chart.TabIndex = 2;
			this.gb_chart.TabStop = false;
			this.gb_chart.Text = "Grafik";
			// 
			// chrt_graph
			// 
			chartArea1.Name = "ChartArea1";
			this.chrt_graph.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chrt_graph.Legends.Add(legend1);
			this.chrt_graph.Location = new System.Drawing.Point(6, 19);
			this.chrt_graph.Name = "chrt_graph";
			this.chrt_graph.Size = new System.Drawing.Size(555, 401);
			this.chrt_graph.TabIndex = 0;
			this.chrt_graph.Text = "Grafik";
			// 
			// pso_main_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 450);
			this.Controls.Add(this.gb_chart);
			this.Controls.Add(this.btn_run);
			this.Controls.Add(this.gb_Params);
			this.Name = "pso_main_form";
			this.Text = "Particle Swarm Optimization";
			this.gb_Params.ResumeLayout(false);
			this.gb_Params.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_pbest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_gbest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_generation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_swarm)).EndInit();
			this.gb_chart.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chrt_graph)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_Params;
		private System.Windows.Forms.NumericUpDown nud_swarm;
		private System.Windows.Forms.NumericUpDown nud_pbest;
		private System.Windows.Forms.NumericUpDown nud_gbest;
		private System.Windows.Forms.ComboBox cb_function;
		private System.Windows.Forms.Label lb_function;
		private System.Windows.Forms.Label lb_pbest;
		private System.Windows.Forms.Label lb_gbest;
		private System.Windows.Forms.NumericUpDown nud_generation;
		private System.Windows.Forms.Label lb_generation;
		private System.Windows.Forms.Label lb_swarm;
		private System.Windows.Forms.Button btn_run;
		private System.Windows.Forms.GroupBox gb_chart;
		private System.Windows.Forms.DataVisualization.Charting.Chart chrt_graph;
	}
}


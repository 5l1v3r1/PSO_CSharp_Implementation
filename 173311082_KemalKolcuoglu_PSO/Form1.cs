using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _173311082_KemalKolcuoglu_PSO
{
	public partial class pso_main_form : Form
	{
		public pso_main_form()
		{
			InitializeComponent();
		}

		private void btn_run_Click(object sender, EventArgs e)
		{
			// Form'dan alınan değerlerin Algoritma Sınıfına uygun değerlerinin alınması
			int particalSize = Convert.ToInt32(nud_swarm.Value);
			int iter = Convert.ToInt32(nud_generation.Value);
			int c1 = Convert.ToInt32(nud_gbest.Value);
			int c2 = Convert.ToInt32(nud_pbest.Value);
			int testFunc = cb_function.SelectedIndex; 

			PSO_Algorithm pso = new PSO_Algorithm(particalSize, iter, c1, c2, testFunc); // PSO Algoritmasının oluşturulması
			double[] bestFitnessValues = pso.Algorithm(); // PSO Algoritmasının çalıştırılması ve değerlerin alınması

			Series series = new Series("En İyi Uygunluk Değeri")
			{
				LegendText = "U.D.",
				ChartType = SeriesChartType.Line, // Çizgi Grafik Oluşturulur
				XValueType = ChartValueType.Int32, // Jenerasyon Değeri int tipindedir
				YValueType = ChartValueType.Double // En İyi Uygunluk Değeri double tipindedir
			};

			for (int i = 0; i < bestFitnessValues.Length; i++) // X: Uygunluk Değerleri, Y: Jenerasyon Değeri
				series.Points.Add(new DataPoint(i+ 1, bestFitnessValues[i]));
				
			if (chrt_graph.Series.Count != 0) // Birden fazla problem çözümünde önceki grafik silinir
				chrt_graph.Series.Clear();

			chrt_graph.ChartAreas["ChartArea1"].Axes[0].Interval = 20; // X değerlerinin aralık boyutu
			chrt_graph.ChartAreas["ChartArea1"].Axes[1].Interval = 0.1; // Y değerlerinin aralık boyutu
			chrt_graph.ChartAreas["ChartArea1"].Axes[1].Maximum = bestFitnessValues[0] + 0.08; // Y Değerinin Maximum aralık değeri 
			chrt_graph.ChartAreas["ChartArea1"].Axes[1].Minimum = bestFitnessValues[bestFitnessValues.Length-1] - 0.08; // Y Değerinin Minumum aralık değeri
			chrt_graph.Series.Add(series); // Sonuçların grafiğe işlenmesi
		}
	}
}

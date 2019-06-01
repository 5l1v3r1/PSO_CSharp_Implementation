using System;

namespace _173311082_KemalKolcuoglu_PSO
{
	public static class TestFunctions
	{
		public static double GetFunc(double[] xx, int cFunc)
		{
			double result;
			switch (cFunc)
			{
				case 0:
					result = FitnessFunction1(xx);
					break;
				//case 1:
				//	result = FitnessFunction2(xx);  // Farklı farklı test fonksiyonları bu kısıma eklenebilir
				//	break;
				default:
					result = 0;
					break;
			}

			return result;
		}

		// Six-Hump Camel-Back Test Function
		private static double FitnessFunction1(double[] xx)
		{
			double a, b, c, d, e, f;

			a = 4 * Math.Pow(xx[0], 2);
			b = 2.1 * Math.Pow(xx[0], 4);
			c = 0.33 * Math.Pow(xx[0], 6);
			d = xx[0] * xx[1];
			e = 4 * Math.Pow(xx[1], 2);
			f = 4 * Math.Pow(xx[1], 4);

			double sum = a - b + c + d - e + f;

			//double sum = ((4 * Math.Sqrt(xx[0])) - (2.1 * Math.Pow(xx[0], 4)) + ((1 / 3) * Math.Pow(xx[0], 6)) + (xx[0] * xx[1]) - (4 * Math.Sqrt(xx[1])) + (4 * Math.Pow(xx[1], 4)));

			return sum;
		}
	}
}

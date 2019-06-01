using System;

namespace _173311082_KemalKolcuoglu_PSO
{
	public class PSO_Algorithm
	{
		private double bestFitnessValue = 0; // Global en iyi uygunluk değeri
		private double[] bestGlobalPosition; // Global en iyi pozisyon değerinin x ve y koordinatları

		private static Random random = new Random();

		private int particleSize; // Parçacık Miktarı
		private int iter; // İterason/Jenerasyon Sayısı
		private double c1; // Öğrenme Faktörü
		private double c2; // Öğrenme Faktörü
		private int testFunc; // Hangi Test Fonksiyonundan geçirileceğinin belirtilmesi.
		private Particle[] particles;

		const int dim = 2; // Problem boyutu (Yani 2 boyutlu bir matris üzerinde çalışılması)
		const double minX = -5.0; // Test fonksiyonunda yer alan min. aralık değeri
		const double maxX = 5.0; // Test fonksiyonunda yer alan max. aralık değeri
		const double w = 0.729; // w değeri: Atalet ağırlığı. Araştırmalar sonucu gerekli olduğu düşünülerek eklendi.

		public PSO_Algorithm(int particleSize, int iter, double c1, double c2, int testFunc)
		{
			// Winform'dan alınan değerlere göre hesaplanacak değerler işleniyor
			this.bestGlobalPosition = new double[dim];
			this.particleSize = particleSize;
			this.particles = new Particle[particleSize];
			this.iter = iter;
			this.c1 = c1;
			this.c2 = c2;
			this.testFunc = testFunc;
		}

		private double FitnessCompute(double[] x) // x: Pozisyon koordinatları matrisi
		{
			// Test fonksiyonuna göre yeni uygunluk değeri hesaplanıyor
			return TestFunctions.GetFunc(x, this.testFunc);
		}

		public double[] Algorithm()
		{
			#region Başlangıç Değerlerinin oluşturulması

			for (int i = 0; i < particles.Length; ++i)
			{
				double[] randomPosition = new double[dim];

				// Rasgele pozisyon koordinaları oluşturuluyor. x ve y koordinatları için döngü 2 kez dönecek
				for (int j = 0; j < randomPosition.Length; ++j)
				{
					randomPosition[j] = (maxX - minX) * random.NextDouble() + minX;
				}

				double fitness = FitnessCompute(randomPosition); // Başlangıç uygunluk değeri hesaplanıyor
				double[] randomSpeed = new double[dim];

				// Fonksiyonun aralık değerine göre yeni hız değerleri oluşturuluyor
				for (int j = 0; j < randomSpeed.Length; ++j)
				{
					double lo = minX * 0.1;
					double hi = maxX * 0.1;
					randomSpeed[j] = (hi - lo) * random.NextDouble() + lo;
				}

				// Oluşturulan rangele değerlerle birlikte parçacıkların oluşumuda tamamlanıyor
				particles[i] = new Particle()
				{
					Speed = randomSpeed,
					Position = randomPosition,
					FitnessValue = fitness,
					BestPosition = randomPosition,
					BestFitnessValue = fitness
				};

				// Uygunluk değeri için minimizasyon işlemi yapılıyor
				if (particles[i].FitnessValue < bestFitnessValue)
				{
					bestFitnessValue = particles[i].FitnessValue;
					particles[i].Position.CopyTo(bestGlobalPosition, 0);
				}
			} 

			#endregion

			int k = 1; // While döngüsü kontrol değişkeni
			double r1, r2; // Yeni değerler için alınmış rasgele değerler
			double[] newSpeed = new double[dim]; // Yeni hız değerleri için oluşturulmuş matris
			double[] newPosition = new double[dim]; // Yeni pozisyon değerleri için oluşturulmuş matris
			double newFitness; // Yeni uygunluk değeri

			double[] iterResults = new double[iter]; 
			// En iyi fitness değerlerini kapsayan matris (Grafiksel gösterim için oluştulmuştur)

			#region Asıl Döngü

			do
			{
				for (int i = 0; i < particleSize; i++)
				{
					// Anlık parçacığın değeri alınarak işlemler onun üzerinden yürütülüyor
					Particle currentParticle = particles[i];

					// Yeni hız değerlerinin belirlenmesi
					for (int j = 0; j < currentParticle.Speed.Length; j++)
					{
						r1 = random.NextDouble();
						r2 = random.NextDouble();

						// Yeni hız değeri alaket ağırlığı, anlık hız, en iyi pozisyon ve rasgele değerler eşliğinde hesaplanıyor
						newSpeed[j] = (w * currentParticle.Speed[j]) +
									  (c1 * r1 * (currentParticle.BestPosition[j] - currentParticle.Position[j])) +
									  (c2 * r2 * (bestGlobalPosition[j] - currentParticle.Position[j]));
					}
					newSpeed.CopyTo(currentParticle.Speed, 0); // Yeni hız değerleri eski hız değerlerinin yerine yazılır.

					// Yeni pozisyon değerlerinin belirlenmesi
					for (int j = 0; j < currentParticle.Position.Length; ++j)
					{
						// Yeni pozisyon için kat edilen yol ile önceki pozisyon toplanır
						newPosition[j] = currentParticle.Position[j] + newSpeed[j];

						// Eğer fonksiyonun min değerinden küçük bir pozisyon değeri alındıysa min değeri kaydedilir.
						if (newPosition[j] < minX)
							newPosition[j] = minX;
						// ve fonksiyonun max değerinden büyük bir pozisyon değeri alındıysa max değeri kaydedilir.
						else if (newPosition[j] > maxX)
							newPosition[j] = maxX;
					}
					newPosition.CopyTo(currentParticle.Position, 0); // Yeni pozisyon değerleri eski pozisyon değerlerinin yerine yazılır.

					newFitness = FitnessCompute(newPosition); // Yeni uygunluk değeri test fonksiyonuna göre hesaplanır
					currentParticle.FitnessValue = newFitness; // Anlık parçacığın yeni uygunluk değeri yazdırılır.

					// Uygunluk değeri minimizasyon işleminden geçiriyor.
					if (newFitness < currentParticle.BestFitnessValue)
					{
						newPosition.CopyTo(currentParticle.BestPosition, 0);
						currentParticle.BestFitnessValue = newFitness;
					}

					// Global en iyi uygunluk değeri için minimizasyon işlemi yapılıyor.
					if (newFitness < bestFitnessValue)
					{
						newPosition.CopyTo(bestGlobalPosition, 0);
						bestFitnessValue = newFitness;
					}
				}
				
				iterResults[k-1] = bestFitnessValue; // Grafiğe yazdırılacak en iyi uygunluk değeri matrise kaydediliyor

			} while (k++ < iter); // Jenerasyon sayısı ve hata değeri sıfırlanıncaya kadar döngü devam eder.

			#endregion

			return iterResults; // Grafiğe kaydedilecek değerler döndürülüyor
		}
	}
}

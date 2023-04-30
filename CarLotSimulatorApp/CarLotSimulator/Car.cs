using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
			CarLot.numberOfCars++;
		}

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }

		public Car(string mk, string mod, int yr, string en, string hn, bool id)
		{
			Make = mk;
			Model = mod;
			Year = yr;
			EngineNoise = en;
			HonkNoise = hn;
			IsDrivable = id;
		}

		public void MakeEngineNoise(string en)
		{
			Console.WriteLine(en);
		}

		public void MakeHonkNoise(string hn)
		{
			Console.WriteLine(hn);
		}
	}
}


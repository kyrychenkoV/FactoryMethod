using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class OpelCar:Car
	{
		public string SpeedCar { get; set; }
		public OpelCar()
		{
			SpeedCar = "10";
			Console.WriteLine("Factory built car model Opel");
		}
		public  void ShowSpeed()
		{
			Console.WriteLine("Max speed = " + SpeedCar);
		}
	}
}

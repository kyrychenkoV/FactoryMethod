using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class MazdaCar:Car
	{
		//public string SpeedCar { get; set; }
		public MazdaCar(string SpeedCar)
		{
			Console.WriteLine("Factory built car model Mazda. Max speed="+SpeedCar);
		}
	}
}

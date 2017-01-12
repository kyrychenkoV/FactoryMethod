using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class OpelCar:Car
	{
		public OpelCar()
		{
			Console.WriteLine("Factory built car model Opel");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class OpelFactory:Factory
	{
		public OpelFactory(string nameFactory) : base(nameFactory)
		{
		}

		public override Car CreateCar()
		{
			return new OpelCar();
		}

		public override void AdditionalEquipment()
		{
			Console.WriteLine("AdditionalEquipment:signaling");
		}
	}
}

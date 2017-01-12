using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class FactoryMazda:Factory
	{
		public FactoryMazda(string nameFactory) : base(nameFactory)
		{
		}
		
		public override Car CreateCar()
		{
			return new MazdaCar(SpeedCar);
		}
		
	}
}

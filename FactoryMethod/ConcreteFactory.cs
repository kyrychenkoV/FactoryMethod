using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class ConcreteFactory:Factory
	{
		public ConcreteFactory(string nameFactory) : base(nameFactory)
		{
		}
		public override Car CreateCar(int cartype)
		{
			switch (cartype)
				{
					case 1:
						return new MazdaCar("10");
					case 2:
						return new OpelCar();
					default:return null;
				}
			}
		}
}

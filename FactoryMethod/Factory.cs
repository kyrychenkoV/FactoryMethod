using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	abstract class Factory
	{
		public string NameFactory { get; set; }
		public string SpeedCar { get; set; }

		protected Factory(string nameFactory)
		{
			NameFactory = nameFactory;
		}

		public abstract Car CreateCar();

		public void BasicEquipment()
		{
			Console.WriteLine("BasicEquipment:tripTronic,boardComputer,fogLights");
		}
	
		public void ShowNameFactory()
		{
			Console.WriteLine(NameFactory);
		}
		public virtual void  AdditionalEquipment()
		{
			Console.WriteLine("AdditionalEquipment:signaling,cruise control\n");
		}
	}
}

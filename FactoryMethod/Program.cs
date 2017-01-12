using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Factory factory=new ConcreteFactory("LLC MODEX AUTO");
			factory.ShowNameFactory();
			
				var carMazda = factory.CreateCar(6);
				if (carMazda != null)
				{
				((MazdaCar)carMazda).ShowSpeed();
				((MazdaCar)carMazda).SpeedCar = "200";
				((MazdaCar)carMazda).ShowSpeed();
				factory.BasicEquipment();
				factory.AdditionalEquipment();
				}

				Car carOpel = factory.CreateCar(2);
				if (carOpel != null)
				{
				factory.BasicEquipment();
				factory.AdditionalEquipment();
				((OpelCar)carOpel).SpeedCar = "180";
				((OpelCar)carOpel).ShowSpeed();
				}

		}
	}
}

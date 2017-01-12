using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Factory factory=new MazdaFactory("LLC MODEX AUTO");
			factory.ShowNameFactory();
			factory.SpeedCar = "180";
			Car carMazda = factory.CreateCar();
			factory.BasicEquipment();
			factory.AdditionalEquipment();
			

			factory =new OpelFactory("PLC Vinnichina Avto");
			factory.ShowNameFactory();
			Car carOpel = factory.CreateCar();
			factory.BasicEquipment();
			factory.AdditionalEquipment();

		}
	}
}

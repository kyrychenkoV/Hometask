using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
	class Car:Factory
	{
		private string salonName;
		public string buyDate;
		public int cost;
		public int digit;

		public string brand;
		public string model;
		public int speed;

		public  override void CreateCar()
		{
			Console.Write("Input brand car:");
			brand = Convert.ToString(Console.ReadLine());
			Console.Write("Input model car:");
			model = Convert.ToString(Console.ReadLine());
			do
			{
				Console.Write("Input cost car:");
			} while (!CheckDigit());
			cost = digit;
			do
			{
				Console.Write("Input spead car:");
			} while (!CheckDigit());
			speed = digit;
			Console.Write("Input salon:");
			salonName = Convert.ToString(Console.ReadLine());
			Console.Write("Input paydate:");
			buyDate = Convert.ToString(Console.ReadLine());
		}
		public  override void PrintInfoCar()
		{
			Console.WriteLine("Brand name:" + brand);
			Console.WriteLine("Model:" + model);
			Console.WriteLine("Cost:" + cost + " UAH");
			Console.WriteLine("Max speed:" + speed + " km/h");
			Console.WriteLine("Salon name:" + salonName);
			Console.WriteLine("Date of purchase:" + buyDate);
		}
		public bool CheckDigit()
		{
			bool result = Int32.TryParse(Console.ReadLine(), out digit);
			return result;
		}
	}
}

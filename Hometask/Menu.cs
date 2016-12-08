
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Hometask
{


	class Menu
	{
		private int inputNumber;
		
		List<Car> carList = new List<Car>();
		
		public void MenuWrite()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("     MENU:");
			Console.ResetColor();
			TextDecoration();
			Console.WriteLine("1.Add new element");
			Console.WriteLine("2.Delate element");
			Console.WriteLine("3.Exit");
			Console.WriteLine("4.Read text document");
			Console.WriteLine("5.Show all elements");
			TextDecoration();
			Console.Write("Input Number:");
			bool result = Int32.TryParse(Console.ReadLine(), out inputNumber);
			if (!result || inputNumber > 5 || inputNumber < 1)
			{
				Console.Clear();
				Console.WriteLine("Input correct digit.\nPress any key to return in menu");
				Console.ReadKey();
				Console.Clear();
			}
		}

		public void MenuCase()
		{
			Console.Clear();
			switch (inputNumber)
			{
				case 1:
					CreateCare();
					break;
				case 2:
					DeleteCar();
					break;
				case 3:
					Environment.Exit(0);
					break;
				case 4:
					InfoAutor();
					break;
				case 5:
					ShowAllCar();
					break;
				default:
					Console.Clear();
					break;
			}
			Console.Clear();
		}
		private void CreateCare()
		{
			Car car = new Car();
			car.CreateCar();
			carList.Add(car);
		}

		private void DeleteCar()
		{ int remove=0;
			bool result;
		
				if (carList.Count > 0)
				{
					inputNumber = 0;
					Console.WriteLine("Created car:" + carList.Count + "\nWhat car you want to remove ?" +
					                  "\nPlease input number car (starting with 0): ");
					bool b = true;
					do
					{
						do
						{
							result = (Int32.TryParse(Console.ReadLine(), out inputNumber));
							if (result)
							{
								remove = inputNumber;
							}
						} while (!result);

						if (remove >= 0 && remove < carList.Count)
						{
							carList.RemoveAt(remove);
							b = false;
							break;
						}
						else
						{
							Console.WriteLine("Try again input number with 0 to {0}", carList.Count - 1);
						}
					} while (b);
				}
				else 
				{
					Console.WriteLine("Not Buy car");
				}
			}

		private void InfoAutor()
		{
			Info autor = new Info();
			autor.InfoAutor();
			Console.ReadKey();
		}

		private void ShowAllCar()
		{
			if (carList.Count == 0)
			{
				Console.WriteLine("No Car");
			}
			foreach (Car list in carList)
			{
				TextDecoration();
				list.PrintInfoCar();
				TextDecoration();
			}
			Console.ReadKey();

		}

		private static void TextDecoration()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=================");
			Console.ResetColor();
		}
	}
}


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
    public int count;
    Car car = new Car();
    List<Car> carList = new List<Car>();
    public void MenuWrite()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("     MENU:");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("=================");
      Console.ResetColor();
      Console.WriteLine("1.Add new element");
      Console.WriteLine("2.Delate element");
      Console.WriteLine("3.Exit");
      Console.WriteLine("4.Read text document");
      Console.WriteLine("5.Show all elements");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("=================");
      Console.ResetColor();
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
      switch (inputNumber)
      {
        case 1:
          Console.Clear();
          car.CreateCar();
          carList.Add(car);
          count++;
          Console.Clear();
          break;
        case 2:
          Console.Clear();
          if (count > 0)
          {
            Console.WriteLine("Created car:" + count + "\nWhat car you want to remove ?" +
                              "\nPlease input number car (starting with 0): ");
            int remove;
            bool b = true;
            do
            {
              remove = Convert.ToInt32(Console.ReadLine());
              if (remove >= 0 && remove < count)
              {
                carList.RemoveAt(remove);
                count--;
                b = false;
                break;
              }
              else
              {
                Console.WriteLine("Try again input number with 0 to {0}", count - 1);
              }
            } while (b);
          }
          if (count == 0)
          {
            Console.WriteLine("Not Buy car");
          }
          Console.Clear();
          break;
        case 3:
          Environment.Exit(0);
          break;
        case 4:
          Console.Clear();
          Info autor = new Info();
          autor.InfoAutor();
          Console.ReadKey();
          Console.Clear();
          break;
        case 5:
          Console.Clear();
          if (carList.Count == 0)
          {
            Console.WriteLine("No Car");
          }
          foreach (Car list in carList)
          {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================");
            Console.ResetColor();
            car.PrintCar();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================");
            Console.ResetColor();
          }
          Console.ReadKey();
          Console.Clear();
          break;
        default:
          Console.Clear();
          break;
      }
    }


  }
}

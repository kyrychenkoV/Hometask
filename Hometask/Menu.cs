
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
    private int _inputnumber;
    public int count = 0;
    
    List<CarInShowrooms> vinnitsyaSity = new List<CarInShowrooms>();
  public void MenuWrite() {
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
      _inputnumber = Convert.ToInt32(Console.ReadLine());
        }
    public void MenuCase() {
      int a = _inputnumber;
      switch (a) {
        case 1:
          Console.Clear();
          CarInShowrooms str = new CarInShowrooms();
          str.addCar();
          vinnitsyaSity.Add(str);
          count++;
          Console.Clear();
          break;
        case 2:
          Console.Clear();
          Console.WriteLine("Caumt" + count);
          
            if (count > 0)
            {
            Console.WriteLine("Byyed car" + count+ "What car you want to remove ?" +
                              "\nPlease input number car: ");
            //Regex myReg=new Regex(@"[0-9]");
            //var tmp= (Console.ReadLine());
            //Console.WriteLine(myReg.IsMatch("tmp")); // True
            int remove;
            bool b=true;
            do
            { 
              remove = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Remove{0}", remove);
              if (remove>=0&&remove<count)
              {
                vinnitsyaSity.RemoveAt(remove);
                count--;
                b = false;
                break;
              }
              else
              {
                Console.WriteLine("Try again input number with 0 to {0}", count);
                }
              } while (b); 
            }
          else
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
          foreach (CarInShowrooms carsInShowrooms in vinnitsyaSity)
          {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================");
            Console.ResetColor();
            Console.WriteLine("Brand name= " + carsInShowrooms.brand + "\n str.getCar();" + "\nSalon Name " 
                              + carsInShowrooms.SalonName + "\nPydate = " 
                              +carsInShowrooms.BuyDate);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================");
            Console.ResetColor();

          }
          Console.ReadKey();
          Console.Clear();
          break;
        default:
          Console.WriteLine("Default case");
          break;
      }
    }

    
  }
}

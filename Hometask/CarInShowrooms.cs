using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
  class CarInShowrooms:Car
  {
    public string SalonName;
    public string BuyDate;
    
    public void addCar() {
      Console.Write("Input brand car:");
      brand =Convert.ToString(Console.ReadLine());
      Console.Write("Input model car:");
      model = Convert.ToString(Console.ReadLine());
      Console.Write("Input cost car:");
      cost = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input spead car:");
      spead = Convert.ToInt32(Console.ReadLine());

      Console.Write("Input salon:");
      SalonName = Convert.ToString(Console.ReadLine());
      Console.Write("Input paydate:");
      BuyDate = Convert.ToString(Console.ReadLine());

          }
    public void print() {
      Console.WriteLine(brand);
      Console.WriteLine(model);
      Console.WriteLine(cost);
      Console.WriteLine(spead);
      Console.WriteLine(SalonName);
      Console.WriteLine(BuyDate);

    }

  }
}

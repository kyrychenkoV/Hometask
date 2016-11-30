using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
  class Car
  {
    public string brand;
    protected string model;
    protected int cost;
    protected int spead;

    public void setCar(string a)
    {
      model = a;
    }
    public string getCar()
    {
      return model;
    }


  }
}

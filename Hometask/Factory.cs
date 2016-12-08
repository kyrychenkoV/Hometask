using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
	

	abstract class Factory
	{
		protected string brand;
		public string model;
		public int speed;
		
		public abstract void PrintInfoCar();
	}

}

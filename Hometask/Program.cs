using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu myMenu = new Menu();
			while (true)
			{
				myMenu.MenuWrite();
				myMenu.MenuCase();
			}
			}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
	public class Computer : Product
	{
		public Computer(string id, string type, double price, int number) : base(id, type, price, number)
		{
		}
	}


}

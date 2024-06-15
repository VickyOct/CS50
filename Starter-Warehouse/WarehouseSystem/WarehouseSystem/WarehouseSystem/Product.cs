using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{

	public class Product
	{
		public string Id { get; set; }

		public string Type { get; set; }

		public double Price { get; set; }

		public int Number { get; set; }

		public Product(string id, string type, double price, int number)
		{
			Id = id;
			Type = type;
			Price = price;
			Number = number;
		}
	}

}

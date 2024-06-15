using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{

	public class Warehouse
	{
		List<List<Product>> myWarehouse = new List<List<Product>>();
		
		public	void ShowProd()
        {
			 foreach(List<Product> product in myWarehouse)
            {
				Console.WriteLine(product[0].Type + ":", product.Count);
            }
        }
		/// <summary>
		/// myWarehouse[0]Phone
		/// myWarehouse[1]Computer
		/// </summary>
		public Warehouse()
		{
			myWarehouse.Add(new List<Product>());
			myWarehouse.Add(new List<Product>());
			myWarehouse.Add(new List<Product>());
			myWarehouse.Add(new List<Product>());
		}
		
		public Product[] PickProduct(string type, int number)
		{
			Product[] products = new Product[number];
			for (int i = 0; i < number; i++)
            {
				switch (type)
				{
					case "Acer":
						products[i] = myWarehouse[0][0];
						myWarehouse[0].RemoveAt(0);
						break;
					case "SamSung":
						products[i] = myWarehouse[1][0];
						myWarehouse[1].RemoveAt(0); 
						break;
					default:
						break;
				}
			}
			return products;
		}

		//public void Product(Product product, int number)
		//{

		//}

		/// <summary>
		/// Add Products
		/// </summary>
		/// <param name="product">type</param>
		/// <param name="number">count</param>
		public void AddProduct(string type, int number)
		{
			for (int i = 0; i < number; i++)
			{
				switch (type)
				{
					case "Acer":
						myWarehouse[0].Add(new Computer(Guid.NewGuid().ToString(), "Acer", 7000, number));
						break;
					case "SamSung" : 
						myWarehouse[1].Add(new Phone(Guid.NewGuid().ToString(), "SamSung", 5000, number));
						break;

				}
			}
		}
	}


}

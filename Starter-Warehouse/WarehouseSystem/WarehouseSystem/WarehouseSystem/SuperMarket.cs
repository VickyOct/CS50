using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    internal class SuperMarket
    {
        Warehouse storage = new Warehouse();

        public SuperMarket()
        {
            storage.AddProduct("Acer", 1000);
            storage.AddProduct("Samsung", 1000);
        }

        public void Sell()
        {
            Console.WriteLine("what do you need?");
            string strType = Console.ReadLine();
            Console.WriteLine("how much?");
            int count = Convert.ToInt32(Console.ReadLine());

            Product[] items = storage.PickProduct(strType, count);
            double price = GetSumPay(items);
            Console.WriteLine($"You need to pay {price}");

            Console.WriteLine("Choose your way for the discount");
            string input = Console.ReadLine();
            Discount discountType = GetDiscountPrice(input);
            double totalPay = discountType.GetTotalMoney(price);
            Console.WriteLine(totalPay);

            ShowProd();
        }

        public Discount GetDiscountPrice(string input)
        {
            switch (input)
            {
                case "1":
                    return new DiscountOpt1();
                case "2":
                    return new DiscountRate(0.8);
                case "3":
                    return new MoneyDiscount(500,100);
                default:
                    return new DiscountOpt1();
            }
        }

        public double GetSumPay(Product[] pros)
        {
            double sum = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                sum += pros[i].Price;
            }
            return sum;
        }

        public void ShowProd()
        {
            storage.ShowProd();
        }
    }   
}

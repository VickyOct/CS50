using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperMarket supmarket = new SuperMarket();
            supmarket.ShowProd();

            supmarket.Sell();
            Console.ReadKey();
        }
    }
}

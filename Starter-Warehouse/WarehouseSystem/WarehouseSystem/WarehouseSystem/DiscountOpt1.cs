using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    class DiscountOpt1 : Discount
    {
        public override double GetTotalMoney(double amount)
        {
            return amount;
        }
    }
}

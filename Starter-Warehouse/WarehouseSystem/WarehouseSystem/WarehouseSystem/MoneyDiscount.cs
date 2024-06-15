using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    class MoneyDiscount : Discount
    {
        public double AmountBuy { get; set; }
        public double AmountGift { get; set; }

        public MoneyDiscount(double buy, double gift)
        {
            AmountBuy = buy;
            AmountGift = gift;
        }
        public override double GetTotalMoney(double amount)
        {
            if(amount >= AmountBuy)
            {
                
                return amount - (int)(amount/AmountBuy) * AmountGift;
            }else
                return amount;
        }
    }
}

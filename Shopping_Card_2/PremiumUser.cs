using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Card_2
{
    public class PremiumUser : IUser
    {
        public string FullName { get; set; }

        public ShoppingCard Card { get; set; }

        public decimal GetPriseDiscountForUser(decimal totalPrise)
        {
            return totalPrise * (1 - 0.30M);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Card_2
{
    public class NormalUser : IUser
    {
        public string FullName { get; set; }

        public ShoppingCard Card { get; set; }

        public decimal GetPriseDiscountForUser(decimal totalPrise)
        {
            if(Card.Products.Count > 5)
            {
                return totalPrise * (1 - 0.30M);
            }
            else 
            {
                return totalPrise;
            }
        }
    }
}

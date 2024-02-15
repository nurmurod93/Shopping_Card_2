using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Card_2
{
    public interface IUser
    {
        string FullName { get; }
        ShoppingCard Card { get; set; }

        decimal GetPriseDiscountForUser(decimal totalPrice);
    }
}

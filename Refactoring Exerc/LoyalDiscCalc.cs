using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Exerc
{
    public interface ILoyalDiscCalc
    {
        decimal ApplyDiscount(decimal price, int YearsOfHavingAccount);

        public class LoyalDiscClac : ILoyalDiscCalc
        {
            public decimal ApplyDiscount(decimal price, int YearsOfHavingAccount)
            {
                decimal discountForAccountAge = (YearsOfHavingAccount > Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY) ?
                    (decimal)Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY / 100 : (decimal)YearsOfHavingAccount / 100;
                return price - (discountForAccountAge * price);

            }
        }
      
    }
}

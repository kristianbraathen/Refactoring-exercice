using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Exerc
{
    internal class ValuableCustomerCalc : IAccountDiscCalc
    {
        public decimal CalculateCost(decimal price)
        {
            return price - Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS * price;
        }
    }
}

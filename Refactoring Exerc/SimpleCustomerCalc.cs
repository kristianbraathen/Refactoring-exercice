using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Exerc
{
    public class SimpleCustomerCalc : IAccountDiscCalc
    {
        public decimal CalculateCost(decimal price)
        {
            return price - Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS * price;
        }
    }
}

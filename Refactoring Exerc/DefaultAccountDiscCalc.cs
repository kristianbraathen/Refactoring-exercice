using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Exerc
{
    public interface IAccountDiscCalcFactory
    {
        IAccountDiscCalc GetAccountDiscCalc( AccountType type);
    }
    public interface IAccountDiscCalc
    {
        decimal CalculateCost(decimal price);
    }
     class DefaultAccountDiscCalc : IAccountDiscCalcFactory
    {
     public IAccountDiscCalc GetAccountDiscCalc(AccountType type)
        {
            IAccountDiscCalc calculator;

            switch (type)
            {
                case AccountType.NotRegistered:
                    calculator = new NotRegisteredDiscCalc();
                    break;
                case AccountType.SimpleCustomer:
                    calculator = new SimpleCustomerCalc();
                    break;
                case AccountType.ValuableCustomer:
                    calculator = new ValuableCustomerCalc();
                    break;
                case AccountType.MostValuabelCustomer:
                    calculator = new MostValuableCalc();
                    break;
                default:
                    throw new NotImplementedException();

                   

            }
            return calculator;

        }
    }
}

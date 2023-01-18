using System;



namespace Refactoring_Exerc
{
   
    
        public enum AccountType
        {
            NotRegistered = 1,
            SimpleCustomer = 2,
            ValuableCustomer = 3,
            MostValuabelCustomer = 4,
        }
        public class DiscountManager
        {
            private IAccountDiscCalcFactory _factory;
            private ILoyalDiscCalc _loyalDiscCalc;
            public DiscountManager(IAccountDiscCalcFactory factory, ILoyalDiscCalc loyalDiscCalc)
            {
                _factory = factory;
                _loyalDiscCalc = loyalDiscCalc;
            }
            public decimal CalculateCost( decimal price, AccountType accountType, int YearsOfHavingAccount)
            {
                decimal priceAfterDisc = 0;
                var calc = _factory.GetAccountDiscCalc(accountType);
                priceAfterDisc = calc.CalculateCost(price);
                priceAfterDisc = _loyalDiscCalc.ApplyDiscount(priceAfterDisc, YearsOfHavingAccount);
                return priceAfterDisc;

            }
        }
           
           
        
    
}

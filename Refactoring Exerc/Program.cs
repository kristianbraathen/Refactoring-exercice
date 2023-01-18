using System;
using System.Collections.Generic;

namespace Refactoring_Exerc
{
    internal class Program
    {
       
        static void Main(string[] args)

        {
            var Notreg = new NotRegisteredDiscCalc();
            var discountSimpleC = new SimpleCustomerCalc();
            var discountValuableC = new ValuableCustomerCalc();
            var discountMostVC = new MostValuableCalc();

            var Items1 = new Items("Drumchair", 500);
            var Items2 = new Items("Gong", 800);
            var Items3 = new Items("Snare", 350);
            var Items4 = new Items("Cymbales", 300);

            Console.WriteLine("Hello World! Welcome to my Shop");
            Console.WriteLine(" I have 4 items for sale");
            Console.WriteLine("1: " + Items1.Name);
            Console.WriteLine("2: " + Items2.Name);
            Console.WriteLine("3: " + Items3.Name); 
            Console.WriteLine("4: " + Items4.Name);
            
            int input1 = int.Parse(Console.ReadLine());
            int _price= 0;
                switch (input1)
            {
                case 1:

                    Console.WriteLine(Items1.Print());
                    Console.WriteLine("So you need a drumchair,ay?");
                    _price = Items1.Price;

                    break;

                case 2:
                    Console.WriteLine(Items2.Print());
                    Console.WriteLine("Gong it is");
                    _price = Items2.Price;

                    break;
                case 3:
                    Console.WriteLine(Items3.Print());
                    Console.WriteLine(" Snardrum on sale");
                    _price = Items3.Price;
                    break;
                case 4:
                    Console.WriteLine(Items4.Print());
                    Console.WriteLine("Cymbales, ok");
                    _price = Items4.Price;
                    break;

               default: Console.WriteLine("Not on Sale");
                    break;

            }
            
            Console.WriteLine("Are You A regisered Customer ? (Y/N)");
            string input2 = Console.ReadLine().ToLower();

            if (input2 == "n")
            {
                Console.WriteLine("Not a registered Customer");
                Console.WriteLine("Your Price is: " + Notreg.CalculateCost(_price));


            }
            
            if (input2 == "y")
            {
                Console.WriteLine("What kind of account do you have?");
                Console.WriteLine("A: Bronze Customer");
                Console.WriteLine("B: Silver Customer");
                Console.WriteLine("C: Gold Customer");
                string input3 = Console.ReadLine().ToLower();
                switch (input3)
                {
                    case "a":
                        Console.WriteLine("Bronze Customer");
                        Console.WriteLine("Your Price is: " + discountSimpleC.CalculateCost(_price));
                        break;
                    case "b":
                        Console.WriteLine("Silver Customer");
                        Console.WriteLine("Your Price is: " + discountValuableC.CalculateCost(_price));
                        break;
                    case "c":
                        Console.WriteLine("Gold Customer");
                        Console.WriteLine("Your Price is: " + discountMostVC.CalculateCost(_price));
                        break;
                }
            }
            
            
           
            Console.ReadLine();
           
        }
    }
}

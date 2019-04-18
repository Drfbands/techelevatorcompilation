using System;

namespace ConsoleApp12

//    This kata arose from some discussions we’ve been having at the DFW Practioners meetings.The problem domain is something seemingly simple: pricing goods at supermarkets.

//Some things in supermarkets have simple prices: this can of beans costs $0.65. Other things have more complex prices. For example:

//three for a dollar (so what’s the price if I buy 4, or 5?)
//$1.99/pound(so what does 4 ounces cost?) answer math.round takescare of this because it automatically rounds up at 2 decimal places
//buy two, get one free(so does the third item have a price?)
//This kata involves no coding.The exercise is to experiment with various models for representing money and prices that are flexible enough to deal with these(and other) pricing schemes, and at the same time are generally usable(at the checkout, for stock management, order entry, and so on). Spend time considering issues such as:

//does fractional money exist?
//when(if ever) does rounding take place?
//how do you keep an audit trail of pricing decisions(and do you need to)?
//are costs and prices the same class of thing?
//if a shelf of 100 cans is priced using “buy two, get one free”, how do you value the stock?
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3 for a dollar and what if there is more thatn 3
            // Yuo would have to have a counter for ever product in the store, and a boolean for common sales. 
            bool threeForADollar = true;
            double totalCornPrice = 0; 
            // 5 11 things cost 1.59. it is 3 for a dollar 

            int corn = 0; // you would have to have a bar code match this counter 
            if(threeForADollar == true)
            {
                int dollarCorns = corn / 3;
                int numberPriceCorn = corn % 3;
                totalCornPrice = dollarCorns + (1.59 * numberPriceCorn);
            }
            else
            {
                totalCornPrice = corn * 1.59;
            }
          


            // This is for 1.99 per pound, deal with fractional prices with math.round 
            double pound = 1.99;
            double divider = (pound / 6);
            double total = Math.Round(divider, 2);
            Console.WriteLine(total);
            Console.ReadKey();

            // Buy 2 get one free
            // price is 1.45 and  we bought 7
            int spam = 0;
            bool buyTwogetonefree = true;
            double spamQuantity = 0;
            if(buyTwogetonefree == true)
            {
             if(spamQuantity >= 3)
                {
                    double freeCansOfSpam = spamQuantity / 3;
                    double totalFreeCans = Math.Round(freeCansOfSpam, 0);
                    double totalDiscountSpamCans = (spamQuantity - totalFreeCans);
                    double totalSpamPrice = totalDiscountSpamCans * 1.59; 

                }

             // Every item would need a counter 
             // A grocery checkout would be a list 
             // then every discount would need a method and a boolean for discounts 
             // if items could have double discounts you would have to run them in order of methods based on priorities
             // Every item would need to get rn through a bunch of filters 



             
                
            }

        }
    }
}

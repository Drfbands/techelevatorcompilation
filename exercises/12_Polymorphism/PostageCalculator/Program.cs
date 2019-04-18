
using PostageCalculator.Classes;
using System;
using System.Collections.Generic;


namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("If weight of your package is 15oz and below, enter o. OR if Weight is 1lb or more enter p: ");
            string inputtype = Console.ReadLine().ToLower();
            Console.Write("Please enter the weight of the package: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("What distance will it be traveling:");
            int distance = int.Parse(Console.ReadLine());

            List<IDeliveryDriver> ShippingMethods = new List<IDeliveryDriver>();

            ShippingMethods.Add(new PostalService1stClass("Postal Service (1st Class)"));
            ShippingMethods.Add(new PostalService2ndClass("Postal Service (2nd Class)"));
            ShippingMethods.Add(new PostalService3rdClass("Postal Service (3rd Class)"));
            ShippingMethods.Add(new FedEd("FexEd                     "));
            ShippingMethods.Add(new SPU_4_Day_Ground("SPU (4 Day)              "));
            ShippingMethods.Add(new SPU_2_Day_Business("SPU (2 Day)             "));
            ShippingMethods.Add(new SPU_Next_Day("SPU (Next Day)           "));

            Console.WriteLine("Delivery Method \t Cost");
            Console.WriteLine("_________________________________________");
            foreach (IDeliveryDriver shippingMethod in ShippingMethods)
            {
                Console.WriteLine($"{shippingMethod.Name}\t\t ${shippingMethod.CalculateRate(distance, weight, inputtype)}");







            }

            Console.ReadLine();





        }





    }
}


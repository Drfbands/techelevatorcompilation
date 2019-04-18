using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool dummyInput = true; // Made to pass into bool to method
            //GetSet obj = new GetSet();


            //Console.WriteLine($"{obj.OutputOne(7)}");
            //Console.WriteLine($"{obj.One}");

            Typing dicy = new Typing();
          bool  isItThere = dicy.pair.ContainsKey(0);
          bool isKd =  dicy.pair.ContainsValue("KD");
            dicy.pair.Add(9,"Cook");

            if (!dicy.pair.ContainsKey(10))
            {
                dicy.pair[11] = "my man";
            }

            bool isEleven = dicy.pair.ContainsKey(11);

            Console.WriteLine(isItThere + " Mother fucker");
            Console.WriteLine(isKd + " KD");
            Console.WriteLine(isEleven + " 11");
            Console.WriteLine(dicy.pair[11]);

            // Outputting the contents of a loop. 
            int addKeys = 0;
            string conValue = "";
            foreach (KeyValuePair<int, string> KV in dicy.pair)
            {
                addKeys += KV.Key;
                conValue += KV.Value;
                Console.WriteLine(KV.Key + " " + KV.Value);
               

            }

            Console.WriteLine("Key Total equals " + addKeys);
            Console.WriteLine("Value Total equals " + conValue);
            

            TryCatch.TryCatchWhile(); // This is the while loop on try catch. 
            //BoolToMethod.BoolSubtract(dummyInput);
            TryCatch tcobject = new TryCatch();
            tcobject.TryAndCatchDoWhile();
            TryCatch.TryAndCatch();
            Adder mathOne = new Adder("John", 41);
            Adder mathTwo = new Adder("Carl", 31);
            Subtractor minus = new Subtractor("Jenny", 53);

            Dictionary<int, string> Mydics = new Dictionary<int, string>();
            Mydics.Add(1, "One");
            Mydics.Add(2, "Two");
            Mydics.Add(3, "Three");
            Mydics.Add(4, "Four");
            Mydics.Add(5, "Five");
            Mydics.Add(6, "Six");
            Mydics.Add(7, "Seven");


            foreach (KeyValuePair<int, string> dic in Mydics)
            {
                switch (dic.Key) // have to use dic.key or dic.value
                {
                    case 1:
                        Console.WriteLine("first level");
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("second level");
                        break;
                    case 6:
                        Console.WriteLine("third level");
                        break;
                    case 7:
                        Console.WriteLine("fourth level");
                        break;


                }
            }
                foreach (KeyValuePair<int, string> mic in Mydics)
                {
                    switch (mic.Value) // have to use dic.key or dic.value
                    {
                        case "One":
                            Console.WriteLine("first");
                            break;
                        case "Two":
                        case "Three":
                        case "Four":
                        case "Five":
                            Console.WriteLine("second");
                            break;
                        case "Six":
                            Console.WriteLine("third");
                            break;
                        case "Seven":
                            Console.WriteLine("fourth");
                            break;


                    }
                }








            Console.WriteLine("Enter a Name: ");
            string enteredName =  Console.ReadLine();
            Console.WriteLine("Enter one, two, three, or four for the dictionary: ");
            string getvar = Console.ReadLine();
            Console.WriteLine("Enter 9,8,7,6 For your int to string output ");
            int num = int.Parse(Console.ReadLine());

            CaseStatement.Cae('D');





            // working with dictionaries
            // Make a method out of this














            Console.WriteLine(mathOne.GetName());
            Console.WriteLine($"WIll it still print the name?:  {mathTwo.GetName()}");
            Console.WriteLine(mathOne.ChangeName("Bill"));
            Console.WriteLine(mathOne.ChangeName(enteredName));
            //Overload Method
            Console.WriteLine("Overload Method. Want to put the methods in there own class. OO classes also really helps with nameing conlisions. ");
            Console.WriteLine(minus.Subtract());
            Console.WriteLine(minus.Subtract(53));
            Console.WriteLine(minus.Subtract(53, 25));



            Console.WriteLine($" mathtwo is {mathTwo.AddAge(4)} years old");
            Console.WriteLine($" mathtwo is {mathTwo.SecondLevelAgeAdder(4, "Larry")} years old, and name is {mathTwo.GetName()}");
            Console.WriteLine($"{mathTwo.ChangeName("Paul")}");
            Console.WriteLine($" The new name is {mathOne.GetName()}");
            Console.WriteLine($" mathtwo is {mathTwo.SecondLevelAgeAdder(4, "Pearl")} years old, and name is {mathTwo.GetName()}");

            TowObjInteractAdderSubtract.TwoClasses(mathOne, minus);
            Console.WriteLine($"{mathOne.Name}, {minus.Age}");
            PracDict.Dicswitch(getvar);
            PracDict.IntStringTester(num);



            // working with dictionaries

            Console.ReadKey();



        }
      
    }
}



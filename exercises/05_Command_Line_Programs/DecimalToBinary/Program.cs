using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            string userInput;
            int useNum = 0;
            string binaryOutput = "";
            string reverseBinaryOutput = "";

            Console.WriteLine("Enter a interger:");
            do
            {
                userInput = Console.ReadLine();
                try
                {
                    useNum = int.Parse(userInput);
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine($"{userInput} is not valid input. Try again");
                    validInput = false;
                }

            }
            while (!validInput);

            while (useNum != 0)
            {
                if(useNum % 2 == 0)
                {
                    binaryOutput += 0;
                }
                else
                {
                    binaryOutput += "1";
                }
                useNum = (useNum / 2);
            }
            int stringLength = binaryOutput.Length - 1;

            while(stringLength >= 0)
            {
                reverseBinaryOutput += binaryOutput[stringLength];
                stringLength--;

            }
            Console.WriteLine($"\n{userInput} in binary is {reverseBinaryOutput}");
            
            Console.WriteLine("\n Press any key to quit");
            Console.ReadKey(); 
}
    }
}



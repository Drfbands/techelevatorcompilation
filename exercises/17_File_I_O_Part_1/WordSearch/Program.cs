using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1. Ask the user for the search string
            //2. Ask the user for the file path
            Console.WriteLine("Please Enter the path the file you want searched:  ");
            string filePath = Console.ReadLine();
            Console.WriteLine("What is the word in the file your would like to search for: ");
            string wordToSearch = Console.ReadLine();
            Console.WriteLine("Do you want the search to be case sensative Y?N? ");
            string casing = Console.ReadLine().ToUpper();
            // string insensative = casing.ToLower();

            // StringComparison.OrdinalIgnoreCase

            Io textinput = new Io();
            textinput.ProcessFile(filePath, wordToSearch, casing);


                Console.ReadKey();


            }
        }
    }



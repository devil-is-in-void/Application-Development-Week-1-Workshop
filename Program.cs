using System;

namespace PersonalDetailsAppWeek1Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Personal Details ===");
            Console.WriteLine("Name: Prajwal Chaulagain");
            Console.WriteLine("Address: Biratnagar, Nepal");
            Console.WriteLine("Phone Number: +977-9707156094");
            Console.WriteLine("College: (Itahari International College)");

            Console.WriteLine();

            //call quote class

            Quote quote_1 = new Quote();
            quote_1.PrintQuote();

            Console.ReadLine();
        }
    }
}

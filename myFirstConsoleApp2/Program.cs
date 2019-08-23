using System;

namespace myFirstConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseDate variable.
            DateTime purchaseDate = DateTime.Now;

            /* 
             * String is the type of the lastName variable
             * It tells the compiler that the lastName varirable 
             * can ONLY hold a string value.
             */

            string lastName = "Smith";

            /*
             C# now supports implicitly typing of a variable.
             The type of the variable will be determined by the compiler at compile time.
             */

            var firstName = "Bill";

            // Not only doe you have to say what type the variable is, you also have to 
            // instantiate that exact same type of object on assignment. This may seem 
            // reduandant, but it's part of the C# language compiler's type checking constraints


            string[] products = new string[] { "Motorcycle", "Sofa", "Sandals", "Omega Watch", "iPhone" };

            foreach (string product in products)
            {
                if (product.Length > 5 )
                {
                    Console.WriteLine(product);
                }

            }



            Console.WriteLine($"{firstName} {lastName} visited on {purchaseDate}");
            Console.ReadLine(); // This will stop the program waiting for user input. B

        }
    }
}

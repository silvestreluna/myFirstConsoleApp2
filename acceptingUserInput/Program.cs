using System;

namespace acceptingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            } while (enteredKey.Key != ConsoleKey.Escape);

            // Console.Read();
            Console.WriteLine("test");

            // testing toChar();
            int enetedItem;
            enetedItem = Console.Read();
            var convertedItem = Convert.ToChar(enetedItem);
            Console.WriteLine($"{convertedItem}");
            Console.WriteLine($"{enetedItem}, Withot Conversion");


            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done.");
                sentence = Console.ReadLine();

                Console.WriteLine($"You typed {sentence}");
            } while (sentence != "quit");

        }
    }
}

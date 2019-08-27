using System;


namespace letterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFromUser = Console.ReadLine();
            string finalResult = "";
            int counter = 0;

            foreach (var eachLetter in inputFromUser)
            {
                finalResult += eachLetter.ToString().ToUpper();

                for (var item = 0; item < counter; item++)
                {
                    var lowerCaseLetter = eachLetter.ToString().ToLower();
                    finalResult += lowerCaseLetter;
                }
                finalResult += "-";
                counter++;

            }

            Console.WriteLine(finalResult.TrimEnd('-'));
        }
    }
}
using System;


namespace letterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFromUser = Console.ReadLine();

            foreach (var eachLetter in inputFromUser)
            {
                int indexOfEachLetter = inputFromUser.IndexOf(eachLetter);

                string thisLetter = eachLetter.ToString().ToUpper();

                Console.WriteLine(indexOfEachLetter);
            }
            
            // Console.WriteLine($"{inputFromUser}, ...TEST");
        }
    }
}

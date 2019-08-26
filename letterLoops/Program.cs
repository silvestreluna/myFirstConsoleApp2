using System;


namespace letterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFromUser = Console.ReadLine().ToString();

            foreach (var eachLetter in inputFromUser)
            {
                int indexOfEachLetter = inputFromUser.IndexOf(eachLetter);

                string thisLetter = eachLetter.ToUpper();

                Console.WriteLine(indexOfEachLetter);
            }
            
            // Console.WriteLine($"{inputFromUser}, ...TEST");
        }
    }
}

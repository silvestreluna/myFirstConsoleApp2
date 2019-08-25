using System;
using System.Collections.Generic;
using System.Linq;

namespace numManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var prevNum = 1;
            List<string> numBySquare = new List<string>();


            var listOfNum = "2,4,5";
            var splitNum = listOfNum.Split(",");
                Console.WriteLine("Would you like to multiply by Previous number or the square of the numbe? Type Previous Number or Square");
                var askUserWhatToUse = Console.ReadLine().ToLower();

            if (askUserWhatToUse == "previous number")
            {
                foreach ( var item in splitNum)
                {
                    var itemInt = int.Parse(item);
                    var multipleValueByPrev = itemInt * prevNum;
                    prevNum = multipleValueByPrev;
                }
            }

            if (askUserWhatToUse == "square")
            {
            foreach ( var item in splitNum )
                {
                    var itemInt = int.Parse(item);
                    var squareNum = itemInt * itemInt;
                    prevNum = squareNum;
                    numBySquare.Add($"{prevNum}");

                }
            }
            var test = string.Join(",", numBySquare);

            Console.WriteLine($"{prevNum}, This is the answer!");
            Console.WriteLine($"{test}, Results for multiplying by the number square.");

        }
    }
}

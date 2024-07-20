using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise4
    {
        public static void Task4()
        {
            Console.WriteLine("Please enter number: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt %4 == 0)
            {
                Console.WriteLine($"{aToInt} is a leap year");
            }
            else
            {
                Console.WriteLine($"{aToInt} is not a leap year");
            }
        }
    }
}
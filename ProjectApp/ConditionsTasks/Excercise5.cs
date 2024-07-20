using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise5
    {
        public static void Task5()
        {

            Console.WriteLine("Please enter age: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt >= 21)
            {
                Console.WriteLine("You can become an MP");
            }
        }
    }
}
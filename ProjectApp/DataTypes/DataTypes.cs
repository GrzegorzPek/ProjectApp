using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DataTypes
{
    public static class DataTypes
    {
        
        public static void DTTask()
        {
            bool exitSubMenu = false;

            //  Console.Clear();
            Console.WriteLine("Enter the number of Tasks 1- 3 q-quit");
            var operationConditions = Console.ReadKey();
         //   while(operationConditions.KeyChar!='q')
           // {
                switch (operationConditions.KeyChar)
                {
                    case '1':
                        Console.WriteLine("You have choosen task 1");
                       
                        exitSubMenu = true;
                        break;
                    case '2':
                    Task1();
                    // TaskDataType2();
                    break;
                    case '3':
                       exitSubMenu = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                        Console.ReadKey();
                        break;
             //   }
            }
            bool Task1()
            {
                bool exitSubMenu = false;
                Console.WriteLine("Please enter first number: ");
                var a = Console.ReadKey();
                int inta;
                Int32.TryParse(a.ToString(), out inta);
                //var idTasks = actio
                Console.WriteLine("Please enter second number: ");
                var b = Console.ReadKey();
                
                if (a == b)
                {
                    Console.WriteLine($"The numbers are the same");
                    exitSubMenu = true;

                }
                else
                {
                    Console.WriteLine($"The numbers are different");
                    exitSubMenu = true;

                }
                return exitSubMenu;
            }






        }
       
    }
}

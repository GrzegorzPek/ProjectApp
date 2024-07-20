using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise8
    {
        public static void Task8()
        {
            
            int b = int.MaxValue;

            Console.WriteLine($"Zamiana liczby dziesiętnej na binarną podaj liczbę naturalną od {1} do {b}: ");

           // {
                Console.Write("Podaj liczbę całkowitą: ");
                int liczba = int.Parse(Console.ReadLine());

                //string liczbaBinarna = ZamienNaBinarny(liczba);

              
           // }

           // static string ZamienNaBinarny(int liczba)
          //  {
            //    if (liczba <= 0);
            //{
            //    Console.WriteLine(" Liczba ujemna");
                
            //}
            
           
      
                
            
          string n = string.Empty;
                int l2 = liczba;

                while (l2 > 0)
                {
                n = (l2 % 2) + n;
                l2 = l2/ 2;  //schemat hornera






                //if (liczba2 % 2 == 0)
                //{
                //    Console.WriteLine(" Liczba ujemna");
                //    n = "1";
                //    n +=n;
                //}
                //else
                //{
                //    n = "0";
                //    n += n;
                //}


                Console.Write($"{n} ");


                // liczbaRobocza /= 2;
                //  }




            }
           Console.WriteLine($"Reprezentacja binarna liczby: {liczba} to: {n}");

        }

        }
    }

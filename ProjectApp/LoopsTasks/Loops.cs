using Microsoft.EntityFrameworkCore.Query.Internal;
using ProjectApp.ConditionsTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks.Loops
{
    public static class Loops
    {

        public static ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("MenuName");
            Console.WriteLine("\nPlease select item type:");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }

        public static void LTasks()
        {
            Console.WriteLine("\nEnter the number of taks");

            bool subMenu;
            subMenu = true;
            while (subMenu == true)
            {
                Console.WriteLine("Please enter the number of task 1-10, q - qiut\n:");
                var operationConditions = Console.ReadLine();
                switch (operationConditions)
                {
                    case "1":
                        Excercise1.Task1();
                        break;
                    case "2":
                        Excercise2.Task2();
                        break;
                    case "3":
                        Excercise3.Task3();
                        break;
                    case "4":
                        Excercise4.Task4();
                        break;
                    case "5":
                        Excercise5.Task5();
                        break;
                    case "6":
                        Excercise6.Task6();
                        break;
                    case "7":
                        Excercise7.Task7c();
                        break;
                    case "8":
                        Excercise8.Task8();
                        break;
                    case "9":
                        // LTask9.Task9();
                        break;
                    case "10":
                        //  LTask10.Task10();
                        break;
                    default:
                        Console.WriteLine("\nAction you entered does not exist");
                        subMenu = false;
                        break;
                }
            }
        }
    }
}


        /*
         * 
         * 
         * 
         * 
        public static void Task1()
        {
            Console.WriteLine("Prime number in  od 0 - 100 ");
            int[] numbers = new int[100];

            for (int i = numbers.Length - 1; i >= 0; --i)
            {
                numbers[i] = i + 1;
                int rest;
                for (int j = 2; j < i; j++)
                {
                    rest = (i + 1) % j;
                    if (rest == 0)
                    {
                        numbers[i] = 0;
                        break;
                    }
                }
            }
            Console.WriteLine($"The Prime number is : ");
            int k = 0;
            for (int i = 1; i < numbers.Length - 2; i++)
            {
                if (numbers[i] != 0)
                {
                    k++;
                    Console.WriteLine($"Prime number {k} is {numbers[i]}");
                }
            }
        }

        public static void Task2()
        {
            Console.WriteLine("Please enter number: ");
            int aToInt = 2;
            int j = 0;
            Console.WriteLine("The even number 0 - 100 "); 
            int[] numbers = new int[1000];
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"The number {i} is even ");
                    numbers[i] = i;
                }
            }
            while (j != 1000)
            {
                j = j + 2;
                Console.WriteLine($"The number while {j} is even ");
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Fibonacci string : ");
            Console.WriteLine("Fibonacci string : ");
            int a = 1;
            int b = 2;
            int k = 2;
            int[] c = new int[30];
            {
                c[0] = 0;
                c[1] = 1;
            }
            Console.WriteLine($"{0}: {c[0]}");
            Console.WriteLine($"{1}: {c[1]}");
         
            for (k = 2; k < c.Length - 1; k++)
            {
                c[k] = c[k - 1] + c[k - 2];
                Console.WriteLine($"{k}: {c[k]}");
            }
        }

        public static void Task4()
        {

            Console.WriteLine("Enter number a: of rows and columns\n : ");
            var a = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            int column = 0;
            int i = 1;
            int c;
            int[] l = new int[10];

            while (column <= aToInt)
            {
                column++;
                for (int row = 1; row <= column; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {
                    if (i <= aToInt)
                    {
                        Console.Write($"{i}   ");
                        i++;
                    }
                    else
                    {
                        break;
                    }


                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }


        public static void Task5()
        {

            Console.WriteLine("The program gives powers of 3 of numbers from 1 to 20\n");
       
            Console.WriteLine("");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"The powers of 3 of number {i} is: {i * i * i}");
            }
        }

        public static void Task6()
        {

            Console.WriteLine("The program gives sum of numbers from 1 to A \n");
            var a = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            float sum = 0;
            Int32.TryParse(a.ToString(), out aToInt);

            float[] w = new float[aToInt + 1];

            for (int i = 1; i <= 20; i++)
            {
                w[i] = i;
                sum += 1 / w[i];
                Console.WriteLine($"{i} :{w[i]} {1 / w[i]} ");
            }
            Console.WriteLine($"Sum: {sum} ");
        }

        public static void Task7()
        {

            Console.WriteLine("Enter number a: of rows and columns\n : ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter number b: of columns and columns\n : ");
            var b = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            int bToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            Int32.TryParse(b.ToString(), out bToInt);
            int i = 1;         
            int row;
            int column = 0;
            int[] l = new int[10];
            string c = "*";
            string d;

            for (column = 0; column < aToInt; column++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
            {
                for (row = 0; row < bToInt; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {
                    c = "*";
                    Console.Write($" {i} ");
                    i++;
                }
                Console.WriteLine("");
            }
        }

        public static void Task8a()
        {
            Console.WriteLine("Enter number a: of rows and columns\n : ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter number b: of columns and columns\n : ");
            var b = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            int bToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            Int32.TryParse(b.ToString(), out bToInt);
            int i = 1;
            int row;
            int column;
            string[,] rc = new string[aToInt + 1, bToInt + 1];
            string c = "*";
            string d;

            for (row = 1; row <= aToInt; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
            {


                //c = "1";
                //d = c + c;
                //Console.Write($" {d} ");

                // Console.Write($"{i} ");
                for (column = 1; column <= bToInt; column++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {
                    //rc[row, column] = "*";
                    // n = -2;


                    if ((row == 1 && column == 1) || (row == 1 && column == bToInt))
                    {
                        for (int r1 = 1; r1 <= bToInt; r1++)
                        {
                            if (r1 == bToInt / 2 + 1)
                            {
                                rc[row, r1] = "*";
                            }
                            else
                            {
                                rc[row, r1] = " ";
                            }
                        }
                    }
                    else
                    if
                        (row == aToInt / 2 + 1 && column == 1)
                    {
                        for (int r2 = 1; r2 <= aToInt; r2++)
                        {
                            rc[row, r2] = "*";
                            i++;
                        }
                    }
                    else
                         if ((row == aToInt && column == 1) || (row == aToInt && column == bToInt))
                    {
                        for (int r3 = 1; r3 <= aToInt; r3++)
                        {
                            if (r3 == bToInt / 2 + 1)
                            {
                                rc[row, r3] = "*";
                            }
                            else
                            {
                                rc[row, r3] = " ";
                            }
                        }
                    }
                    else
                    {
                        rc[row, column] = "*";
                    }
                    Console.Write($"{rc[row, column]} ");
                    i++;
                }
                Console.WriteLine("");
            }
            Console.WriteLine($"operation account: {i}");
            Console.WriteLine("===========================");

            for (row = 1; row <= aToInt; row++)
            {
                for (column = 1; column <= bToInt; column++)
                {
                    Console.Write($"{rc[row, column]} ");
                }
                Console.WriteLine("");
            }
        }
        public static void Task9a()
        {
            Console.WriteLine("Enter number a: of rows and columns\n : ");
            var a = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            int column = 0;
            int i = 1;
            int c;
            int[] l = new int[10];
            Console.Clear();
            Console.SetCursorPosition(aToInt + aToInt, aToInt);

            // I
            while (column <= aToInt)
            {
                column++;
                for (int row = 1; row < column; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {
                    Console.Write($"{i}   ");
                    i++;
                }
                Console.WriteLine("");
                Console.Write("1 2 3 4 5 6 7 8 9 ---");
            }
          
            // II

            int columnb = aToInt;

            while (columnb >= 1)
            {
                columnb--;
                for (int row = 1; row <= columnb; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {


                    //if (i <= aToInt)
                    //{
                    Console.Write($"{i}   ");

                    i++;
                    //}

                    //else
                    //{
                    //  //  break;
                    //}


                }
                Console.WriteLine("");
                Console.Write("1 2 3 4 5 6 7 8 9 ---");
            }
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");
            //  return (columnb, cursorLeft)

        }




        // Wyświetlenie aktualnej pozycji kursora
        //Console.SetCursorPosition(0, Console.WindowHeight - 1);
        //Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");


        public static void Task9b()
        {


            Console.WriteLine("Enter number a: of rows and columns\n : ");
            var a = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            int row = 0;

            int i = 1;

            int[] l = new int[10];
            Console.Clear();
            //Console.SetCursorPosition(aToInt+aToInt, aToInt);
            //Console.Write("O");
            Console.Clear();
            Console.SetCursorPosition(aToInt + aToInt, aToInt + aToInt);
            int cursorLefta = Console.CursorLeft;
            int cursorTopb = Console.CursorTop;

            Console.Write($"Current cursor position: X = {cursorLefta}, Y = {cursorTopb}  ");


            int aktc = Console.CursorLeft;
            int aktr = Console.CursorTop;
            Console.SetCursorPosition(aktc, aktr);
            // III

            while (row <= aToInt)
            {
                row++;
                int column;

                //aktc = Console.CursorLeft;
                aktr = Console.CursorTop;
                // u mnie row to colimn


                //Console.SetCursorPosition(aktc--, aktr);

                for (column = 1; column < row; column++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {


                    //if (i <= aToInt)
                    //{
                    // Console.SetCursorPosition(row, column);
                    aktc = Console.CursorLeft;
                    //r = Console.CursorTop;


                    Console.SetCursorPosition(aktc--, aktr);
                    Console.Write($"{i}   ");

                    //cursorTopb = Console.CursorTop;

                    i++;
                    //}

                    //else
                    //{
                    //  //  break;
                    //}


                }
                // Console.SetCursorPosition(row, column);
                aktr = Console.CursorLeft;
                aktc = Console.CursorTop;
                Console.SetCursorPosition(aktc + column, aktr--);

                //Console.WriteLine("");
                // Console.Write("1 2 3 4 5 6 7 8 9 ---");
            }










            /*



            // IV
            int columnb = aToInt;


            while (columnb >= 1)
            {
                columnb--;


                for (int row = 1; row <= columnb; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {


                    //if (i <= aToInt)
                    //{
                    Console.SetCursorPosition(aToInt + aToInt, aToInt);
                    Console.Write($"{i}   ");

                    i++;
                    //}

                    //else
                    //{
                    //  //  break;
                    //}


                }
                Console.WriteLine("");
                Console.Write("1 2 3 4 5 6 7 8 9 ---");
            }

            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;


            //  Console.SetCursorPosition(aToInt+ aToInt, aToInt);
            Console.Write("Fuck          ");
            Console.SetCursorPosition(15, 20);
            Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");


            Console.WriteLine("Fuck          ");
            Console.Write("Fuck          ");
            Console.Write("Fuck          ");

            Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");


            //  Console.WriteLine("\n");
            //    }
            //    Console.WriteLine("Pyramid enter numbers : ");
        }
            

        }

        public static void Task8()
        {
            int a = int.MinValue;
            int b = int.MaxValue;

            Console.WriteLine($"Zamiana liczby dziesiętnej na binarną podaj liczbę całkowitą od {a} do {b}: ");

            {
                Console.Write("Podaj liczbę całkowitą: ");
                int liczba = int.Parse(Console.ReadLine());

                string liczbaBinarna = ZamienNaBinarny(liczba);

                Console.WriteLine($"Reprezentacja binarna liczby {liczba} to: {liczbaBinarna}");
            }

            static string ZamienNaBinarny(int liczba)
            {
                if (liczba == 0) return "0";

                string wynik = string.Empty;
                int liczbaRobocza = Math.Abs(liczba);

                while (liczbaRobocza > 0)
                {
                    //liczbaRobocza =liczbaRobocza/2;  //schemat hornera
                    wynik = (liczbaRobocza % 2) + wynik;
                  liczbaRobocza = liczbaRobocza / 2;
                    // liczbaRobocza /= 2;
                }

                if (liczba < 0)
                {
                    wynik = "-" + wynik;
                }

                return wynik;
            }




        }
    }
}


*///













/*



sing System;

class Program
{
static void Main()
{
    int windowHeight = Console.WindowHeight;
    int windowWidth = Console.WindowWidth;

    Console.WriteLine("Liczba wierszy w oknie konsoli: " + windowHeight);
    Console.WriteLine("Liczba znaków w wierszu konsoli: " + windowWidth);
}
}












    public static void Task10()
    {
        ConsoleKeyInfo keyInfo;
        int cursorX = 0, cursorY = 0;

        Console.Clear();
        Console.SetCursorPosition(cursorX, cursorY);
        Console.Write("O"); // Początkowa pozycja kursora

        while (true)
        {
            keyInfo = Console.ReadKey(true);
            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write(" "); // Usuń poprzedni znak

            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    cursorX = Math.Max(0, cursorX - 1);
                    break;
                case ConsoleKey.UpArrow:
                    cursorY = Math.Max(0, cursorY - 1);
                    break;
                case ConsoleKey.RightArrow:
                    cursorX = Math.Min(Console.WindowWidth - 1, cursorX + 1);
                    break;
                case ConsoleKey.DownArrow:
                    cursorY = Math.Min(Console.WindowHeight - 1, cursorY + 1);
                    break;
            }

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("O"); // Narysuj nowy znak

            Thread.Sleep(50); // Krótkie opóźnienie, aby ruch kursora był bardziej płynny
        }

    }

    public static void Task11()
    {

        {
            int lineCount = 0;
            int charCount = 0;
            string input;

            Console.WriteLine("Wpisz wiersze tekstu. Aby zakończyć, wprowadź pusty wiersz:");

            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                lineCount++;
                charCount += input.Length;
            }

            Console.WriteLine("Liczba wierszy: " + lineCount);
            Console.WriteLine("Liczba znaków: " + charCount);
        }



    }


    public static void Task12()
    {
    int lineCount = 0;
    int charCount = 0;
    string input;

    Console.WriteLine("Wpisz wiersze tekstu. Aby zakończyć, wprowadź pusty wiersz:");

    while (true)
    {
        Console.CursorLeft = 0;  // Ustawia pozycję kursora na początek linii
        input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
            break;

        lineCount++;
        charCount += input.Length;
    }

Console.WriteLine("Liczba wierszy: " + lineCount);
    Console.WriteLine("Liczba znaków: " + charCount);
}


}
}
//  Console.WriteLine("\n");
//    }
//    Console.WriteLine("Pyramid enter numbers : ");






*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public static class Excercise7
    {
        public static void Task7a()
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
        public static void Task7b()
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

       
        public static void Task7c()
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
            int cursorLefta;
            int cursorTopb;
            aToInt = aToInt/2+1;
            Console.SetCursorPosition(aToInt, 1);

            // I
            while (column <= aToInt)
            {
                column++;
                for (int row = 1; row < column; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {

                  //  cursorLefta = Console.CursorLeft;
                  //  cursorTopb = Console.CursorTop;

                  //  Console.SetCursorPosition(cursorLefta+aToInt, cursorTopb);
                    // Console.SetCursorPosition(aToInt, cursorTopb);
                    // Console.SetCursorPosition(aToInt + aToInt, aToInt);
                    Console.Write("a");
                    //int cursorLefta = Console.CursorLeft;
                    //int cursorTopb = Console.CursorTop;
                    //Console.SetCursorPosition(cursorLefta + aToInt, cursorTopb);
                    //i++;
                }
                //cursorLefta = Console.CursorLeft;
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt, cursorTopb+1);
                // Console.SetCursorPosition(aToInt + aToInt, aToInt);

                //Console.Write("");

               


                //Console.Write("1 2 3 4 5 6 7 8 9 ---");
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
                    Console.Write($"a");

                    i++;
                    //}

                    //else
                    //{
                    //  //  break;
                    //}


                }


                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt, cursorTopb + 1);
                //Console.WriteLine("");
                //Console.Write("1 2 3 4 5 6 7 8 9 ---");
            }
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.SetCursorPosition(cursorLefta-1, cursorTopb-1);
            //Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");
            //  return (columnb, cursorLeft)


            ///III
            ///\
            ///
           // cursorLeft = Console.CursorLeft;
            //cursorTop = Console.CursorTop;

            column =0;
            while (column <= aToInt-1)
            {
                column++;
                for (int row = 1; row < column; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {

                    //  cursorLefta = Console.CursorLeft;
                    //  cursorTopb = Console.CursorTop;

                    //  Console.SetCursorPosition(cursorLefta+aToInt, cursorTopb);

                   




                  
                    Console.Write("a");
                    cursorLefta = Console.CursorLeft;
                    cursorTopb = Console.CursorTop;
                    Console.SetCursorPosition(cursorLefta-2, cursorTopb);
                    

                   // Console.SetCursorPosition(aToInt, cursorTop -1);
                   
                    //int cursorLefta = Console.CursorLeft;
                    //int cursorTopb = Console.CursorTop;
                    //Console.SetCursorPosition(cursorLefta + aToInt, cursorTopb);
                    i++;
                }
                //cursorLefta = Console.CursorLeft;
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt, cursorTopb -1 );
                // Console.SetCursorPosition(aToInt + aToInt, aToInt);

                //Console.Write("");




                //Console.Write("1 2 3 4 5 6 7 8 9 ---");
            }

            //IV

            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.SetCursorPosition(aToInt-1, cursorTopb);
            columnb = aToInt;

            while (columnb >= 1)
            {
                columnb--;
                for (int row = 1; row <= columnb; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {




                    //if (i <= aToInt)
                    //{
                    Console.Write("a");
                    cursorLefta = Console.CursorLeft;
                    cursorTopb = Console.CursorTop;
                    Console.SetCursorPosition(cursorLefta - 2, cursorTopb);

                    i++;
                    //}

                    //else
                    //{
                    //  //  break;
                    //}


                }
                cursorLefta = Console.CursorLeft;
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt - 1, cursorTopb - 1);
                //Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");
                //  return (columnb, cursorLeft)


            }
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.WriteLine("");
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.SetCursorPosition(0, cursorTopb+aToInt+aToInt);

            ///III
            ///\
            ///
            // cursorLeft = Console.CursorLeft;
            //cursorTop = Console.CursorTop;





        }




        // Wyświetlenie aktualnej pozycji kursora
        //Console.SetCursorPosition(0, Console.WindowHeight - 1);
        //Console.Write($"Current cursor position: X = {cursorLeft}, Y = {cursorTop}  ");


        public static void Task7d()
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
        }

        public static void Task7e()
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


    }


}

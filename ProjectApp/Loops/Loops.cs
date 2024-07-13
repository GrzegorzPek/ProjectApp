using Microsoft.EntityFrameworkCore.Query.Internal;
using ProjectApp.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Loops
{
    public static class Loops
    {
        //   public List<CTasks> Conditions { get; set; }

        //public static CTasks()
        //{
        //  //  Conditions = new List<CTasks>();
        //}


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
            //var nrTask = Console.ReadKey();
            //int itemTypeId;
            //Int32.TryParse(nrTask.ToString(), out itemTypeId);
            //var idTasks = actionService.IdTasks(itemTypeId);




            //    Console.WriteLine("\nPlease select task number ");
            //    for (int i = 0; i < mainMenuC.Count; i++)
            //    {
            //        Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            //    }
            //    var operation = Console.ReadKey();
            //    return operation;
            //}











            bool subMenu;
            subMenu = true;

            //   public ConsoleKeyInfo ChooseTask(MenuActionService actionService) 
            //  { 
            //  Console.WriteLine("Welcome to warehouseapp!");
            while (subMenu == true)
            {
                //var mainMenu = actionService.GetMenuActionsByMenuName("Conditions");
                //for (int i = 0; i < mainMenu.Count; i++)
                //{
                //    Console.WriteLine($"{mainMenu[i].Id} {mainMenu[i].Name}");
                //}

                Console.WriteLine("Please enter the number of task 1-9 q - qiut\n:");
                var operationConditions = Console.ReadKey();
                //  var operation = (int)itemTypeId;
                // 
                switch (operationConditions.KeyChar)
                {
                    case '1':
                        Task1(); //id moze byc potrzebne
                        ConditionTask1.Task1();                                       // ItemService.AddNewItem(keyInfo.KeyChar);
                        break;
                    case '2':
                        Task2(); //id moze byc potrzebne
                                 //  TaskCondition1.TaskC1();
                                 //var removeId = itemService.RemoveItemView();
                                 //itemService.RemoveItem(removeId);
                        break;
                    case '3':
                        //var detailId = itemService.ItemDetailSelecionView();
                        //itemService.ItemDetailView(detailId);

                        break;
                    case '4':
                        //var typeId = itemService.ItemTypeSelectionView();
                        //itemService.ItemsByTypeIdView(typeId);
                        break;
                    default:
                        Console.WriteLine("\nAction you entered does not exist");
                        subMenu = false;
                        break;
                }
            }
        }

        public static void Task1()
        {
            Console.WriteLine("Prime number in  od 0 - 100 ");
            int[] numbers = new int[10000];
            int[] notprimenumbers = new int[100];
            int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //numbers[i] = i+1;
            //    //Console.WriteLine($" liczba {i} {numbers[i]}");
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //Console.Write($" liczba  {numbers[i]}");
            //    //sum = numbers[i] + sum;
            //}
            Console.WriteLine($"The sum from 1 to 100 is {sum}");
          //  Console.WriteLine("\n");
            for (int i = numbers.Length-1; i >=0; --i)
            {
                numbers[i] = i + 1;
                int rest;
                int sumrest=0;
                //Console.WriteLine($"\n----{numbers[i]}-------------");
               // Console.WriteLine($"\n---------{i+1}-------------");
                //for (int j = 2; j < numbers[i]-1; j++)
                for (int j = 2; j<i; j++)
                {
                    rest = (i+1)%j;
                    //Console.WriteLine($"The rest of divide {numbers[i]} by {j} is {rest}");
                    //Console.WriteLine($"The rest of divide {i+1} by {j} is {rest}");
                  

                    sumrest = sumrest + rest;
                    if (rest == 0)
                    {
                        numbers[i] = 0;
                       // Console.WriteLine($"The number is not prime the number is  {numbers[i]}\n");
                       // Console.WriteLine($"The number is not prime the rest is {rest}\n");
                        break;
                    }                   
                }
            }
            Console.WriteLine($"The Prime number is : ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i]!=0)
                {                
                    Console.WriteLine($"--- {numbers[i]}");
                }
            }
                

  








        }

        public static void Task2()
        {

            Console.WriteLine("Please enter number: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt == 0) { Console.WriteLine("You entered wrong number"); }
            else
            if (aToInt % 2 == 0)
            {
                Console.WriteLine($"The number {aToInt} is even ");
            }
            else
            {
                Console.WriteLine($"The number {aToInt} is odd");
            }
        }
    }
}



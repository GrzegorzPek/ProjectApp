using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Conditions
{
    public static class Conditions
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

        public static void CTasks()
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
            while (subMenu==true)
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
            Console.WriteLine("\nPlease enter first number: ");
            int aToInt;
            int bToInt;
           
            var a = Console.ReadLine();
            Int32.TryParse(a.ToString(), out aToInt);

            if (!Int32.TryParse(a.ToString(), out aToInt))
            { 
                Console.WriteLine("You have typed wrong number");              
            }
            Console.WriteLine("\nPlease enter second number: ");

            var b = Console.ReadLine();

            if (!Int32.TryParse(b.ToString(), out bToInt))
            {
                Console.WriteLine("You have typed wrong number");
            }
            if (aToInt == bToInt)
            {
                Console.WriteLine($"The numbers are the same");
            }
            else
            {
                Console.WriteLine($"The numbers are different");
            }
        }

        public static void Task2()
        {
           
            Console.WriteLine("Please enter number: ");
            var a = Console.ReadLine();
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);

            if (aToInt == 0) 
            {
                Console.WriteLine("You entered wrong number");
            }
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

    


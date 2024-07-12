
using ProjectApp;
using ProjectApp.Conditions;
using ProjectApp.DataTypes;
using ProjectApp.Loops;
using System;
using System.Threading.Tasks;

namespace AppExercise

{//Warehouse
    class Program
    {
        public const string FILE_NAME = @"D:\ImportFile";
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();

            ItemService itemService = new ItemService();

            actionService = InitializeConditionsTasks(actionService);
            actionService = Initialize(actionService);

            var mainMenu = actionService.GetMenuActionsByMenuName("MenuName");
            var mainMenuC = actionService.GetMenuActionsByMenuName("Conditions");
            var mainMenuDT = actionService.GetMenuActionsByMenuName("DataTypes");
            var mainMenuL = actionService.GetMenuActionsByMenuName("Loops");
            Console.WriteLine("Welcome to warehouseapp!");
            bool menu=true;
            while (menu==true)
            {
                Console.WriteLine("Please let me now what you want to do q-quit:\n");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id} {mainMenu[i].Name}");
                }
               var operation = Console.ReadKey();




               // ConsoleKeyInfo keyInfo = Console.ReadKey();
                // char inputChar = keyInfo.KeyChar;




                switch (operation.KeyChar)
                {
                    case '1':
                        {


                            Console.WriteLine("\nConditions");

                            actionService = Initialize(actionService);
                            for (int i = 0; i < mainMenuC.Count; i++)
                            {
                                Console.WriteLine($"{mainMenuC[i].Id} {mainMenuC[i].Name}");
                            }
                            Conditions.CTasks();
                            Conditions.Task1();
                            ConditionTask1.Task1();
                        }
                        


                        //  Console.WriteLine("Podaj numer zadania od 1 do 9 q-quit");
                        //var nrConditionTasks = Console.ReadKey();
                        //  nService.IdTasks(itemTypeId);   //int itemTypeId;
                        //Int32.TryParse(nrConditionTasks.ToString(), out itemTypeId);
                        //var idTasks = actio

                        //ConsoleKeyInfo keyInfo = Console.ReadKey();
                        // char inputChar = keyInfo.KeyChar;


                        /*
                      var operationConditions = Console.ReadKey();
                        //   do
                        //  {
                        switch (operationConditions.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Please enter first number: ");
                                var a = Console.ReadKey();
                                Console.WriteLine("Please enter second number: ");
                                var b = Console.ReadKey();
                                if (a == b)
                                {
                                    Console.WriteLine($"The numbers are the same");
                                }
                                else
                                {
                                    Console.WriteLine($"The numbers are different");
                                    break;
                                }
                                break;
                            case '2':
                                Console.WriteLine("Operacje na typach danych");
                                DataTypes.DTTask1();
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
                                Console.WriteLine("Action you entered does not exist");
                                break;
                        }














                        */

                        break;
                    case '2':

                        Console.WriteLine("\nDataTypes");

                        actionService = Initialize(actionService);
                        for (int i = 0; i < mainMenuDT.Count; i++)
                        {
                            Console.WriteLine($"{mainMenuDT[i].Id} {mainMenuDT[i].Name}");
                        }
                        DataTypes.DTTask();
                        //var removeId = itemService.RemoveItemView();
                        //itemService.RemoveItem(removeId);

                        break;
                    case '3':
                        Console.WriteLine("\nLoops");

                        actionService = Initialize(actionService);
                        for (int i = 0; i < mainMenuL.Count; i++)
                        {
                            Console.WriteLine($"{mainMenuL[i].Id} {mainMenuL[i].Name}");
                        }
                        Loops.LTasks();

                        //var detailId = itemService.ItemDetailSelecionView();
                        // itemService.ItemDetailView(detailId);

                        break;
                    //case '4':
                    //    var typeId = itemService.ItemTypeSelectionView();
                    //    itemService.ItemsByTypeIdView(typeId);
                    //    break;
                    default:
                        Console.WriteLine("Action you entered does not exist");
                        menu = false;
                        break;

                }

            }
        }
        public static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Conditions", "MenuName");
            actionService.AddNewAction(2, "Data Types", "MenuName");
            actionService.AddNewAction(3, "Loops", "MenuName");

            actionService.AddNewAction(1, "Add item", "Main");
            actionService.AddNewAction(2, "Remove item", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "list of items", "Main");

            actionService.AddNewAction(1, "Task1", "DataTypes");
            actionService.AddNewAction(2, "Task2", "DataTypes");
            actionService.AddNewAction(3, "Task3", "DataTypes");
            actionService.AddNewAction(4, "Task4", "DataTypes");
            actionService.AddNewAction(5, "Task5", "DataTypes");
            actionService.AddNewAction(6, "Task6", "DataTypes");
            actionService.AddNewAction(7, "Task7", "DataTypes");
            actionService.AddNewAction(8, "Task8", "DataTypes");
            actionService.AddNewAction(9, "Task9", "DataTypes");

            actionService.AddNewAction(1, "Task1", "Loops");
            actionService.AddNewAction(2, "Task2", "Loops");
            actionService.AddNewAction(3, "Task3", "Loops");
            actionService.AddNewAction(4, "Task4", "Loops");
            actionService.AddNewAction(5, "Task5", "Loops");
            actionService.AddNewAction(6, "Task6", "Loops");
            actionService.AddNewAction(7, "Task7", "Loops");
            actionService.AddNewAction(8, "Task8", "Loops");
            actionService.AddNewAction(9, "Task9", "Loops");

            actionService.AddNewAction(1, "Task1", "Conditions");
            actionService.AddNewAction(2, "Task2", "Conditions");
            actionService.AddNewAction(3, "Task3", "Conditions");

            //  actionService.AddNewAction(4, "list of items", "MenuName");
            return actionService;
        }
        public static MenuActionService InitializeConditionsTasks(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Task1", "Conditions");
            actionService.AddNewAction(2, "Task2", "Conditions");
            actionService.AddNewAction(3, "Task3", "Conditions");
            actionService.AddNewAction(4, "Task4", "Conditions");
            return actionService;
        }
    }
}




using ProjectApp;
using System;

namespace AppExercise

{//Warehouse

    class Program
    {
        public const string FILE_NAME = @"D:\ImportFile";
        static void Main(string[] args)
        {

            //uzytkownik zostaje przywitany ok.
            //dostaje mozliwosc wyboru akcji ok.
            //a. stworzenie nowego przedmiotu ok.
            //b. Usuniecie przedmiotu ok.
            //c. Sprawdzenie stanu magazynowego 
            //d. Zwrocenie listy przedmiotow o zadanym filtrze (nazwa kategorii)
            ////a1 Najpierw dostane do wyboru kategorie produktu
            ////a2 zostane poproszony o wprowadzenie wszystkich szczegolow
            ////b1 zostane poproszony o id albo nazwe produktu
            ////b2 usune ten produk z listy produktow
            ////c1 zostane proproszony o wprowadzenie id produktu
            ////c2 wyswietle wszystkie informacje zwiazane z tym produktem
            ////d1 zostane poproszony o wprowadzenie nazwy albo id kategorii
            ////d2 wyswietle liste produktow
            ///
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService();
            actionService = Initialize(actionService);
            // Console.WriteLine("Program do obliczania zadań z listy");

            Console.WriteLine("Welcome to warehouseapp!");
            while (true)
            {
                Console.WriteLine("Please let me now what you want to do:");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id} {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
              // 
                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = itemService.AddNewItemView(actionService);
                        var id = itemService.AddNewItem(keyInfo.KeyChar); //id moze byc potrzebne
                                                                          // ItemService.AddNewItem(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = itemService.RemoveItemView();
                        itemService.RemoveItem(removeId);
                        break;
                    case '3':
                        var detailId = itemService.ItemDetailSelecionView();
                        itemService.ItemDetailView(detailId);

                        break;
                    case '4':
                        var typeId = itemService.ItemTypeSelectionView();
                        itemService.ItemsByTypeIdView(typeId);
                        break;
                    default:
                        Console.WriteLine("Action you entered does not exist");
                        break;
                }
            }

            //Console.WriteLine("Please let me now what you want to do");
            //int chosenOperation = 3;

            //Int32.TryParse(operation, out chosenOperation);

            //Console.WriteLine("Select iten category");
            //Console.WriteLine("1. Gocery");
            //Console.WriteLine("2. Clothing");
            //Console.WriteLine("3. Elektronics");

            //string category = Console.ReadLine();
            //ItemType chosenCategory;
            //Enum.TryParse(category, out chosenCategory);
        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            /// throw new NotImplementedException();
            actionService.AddNewAction(1, "Add item", "Main");
            actionService.AddNewAction(2, "Remove item", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "list of items", "Main");

            actionService.AddNewAction(1, "Clothing", "AddNewItemMenu");
            actionService.AddNewAction(2, "Electronics", "AddNewItemMenu");
            actionService.AddNewAction(3, "Grocery", "AddNewItemMenu");

            return actionService;



        }
    }
}

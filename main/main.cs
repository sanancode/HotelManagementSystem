using Week5_Thursday.config;
using Week5_Thursday.util;

namespace Week5_Thursday.main
{
    internal class main
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\tWelcome to Code Academy Hotel\n");
            CreateHotel.createHotel();
            run();

        }

        public static void run()
        {
            bool program = true;

            do
            {
                MenuUtil.mainMenu();

                int menu = MenuUtil.getInteger("Please select the menu above: ");

                switch (menu)
                {
                    case 0:
                        mainMethods.Menu_ShowAll();
                        break;
                    case 1:
                        mainMethods.Menu_CheckIn();
                        break;
                    case 2:
                        mainMethods.Menu_CheckOut();
                        break;
                    case 3:
                        mainMethods.Menu_Services();
                        break;
                    case 4:
                        Console.WriteLine("\nExiting the system...");
                        program = false;
                        break;
                }

            } while (program);
        }

    }
}
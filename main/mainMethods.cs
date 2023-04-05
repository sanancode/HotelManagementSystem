using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Thursday.Classes;
using Week5_Thursday.util;

namespace Week5_Thursday.main
{
    internal class mainMethods
    {

        public static void Menu_ShowAll()
        {
            for (int i = 0; i < config.Config.hotel.Count; i++)
            {
                config.Config.hotel[i].showAll(i);
            }
        }

        public static void Menu_CheckIn()
        {
            Console.WriteLine("\n\tWelcome to Customer check-in system\n");

            //customerin adi
            string fullName = MenuUtil.getString("Please enter the fullname: ");

            //customerin id-si
            string id = MenuUtil.getString("Please enter the id: ");

            //Otaq nomresini yaz
            int roomNumber;
            do
            {
                roomNumber = MenuUtil.getInteger("Please enter the room number: ");

                //otaq nomresini yoxla (1. bos olmalidir && 2. boyuk olmamalidi)
                if (roomNumber - 1 < config.Config.hotel.Count)
                {
                    if (config.Config.hotel[roomNumber - 1].isRoomStatus() == false)
                    {
                        config.Config.hotel[roomNumber - 1].setRoomStatus(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nSelected room is not empty...\nContinue with another please...\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nThere is not selected room in array...\nTry again please...\n");
                }
            } while (true);

            //Yekun
            config.Config.customer[roomNumber - 1].setFullName(fullName);
            config.Config.customer[roomNumber - 1].setId(id);

            MenuUtil.sleep(5, 450);
            Console.WriteLine($"\nCustomer registration completed...\n{fullName} took {roomNumber}. room");
        }

        public static void Menu_CheckOut()
        {
            //hotelde musteri olub olmamasini yoxlayir
            int check = 0;
            for (int i = 0; i < config.Config.hotel.Count; i++)
            {
                if (config.Config.hotel[i].isRoomStatus() == true)
                {
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("\nThere is not any customer in the hotel...\n");
                main.run();

            }

            //ESAS
            Console.WriteLine("\n\tWelcome to Customer check-out system\n");
            Console.WriteLine("Here are the All Customers\n");

            //customerlerin adlarini gosterir ilk once
            int row = 1;
            int count = 0;
            List<string> tempArray = new List<string>();
            for (int i = 0; i < config.Config.customer.Count; i++)
            {
                if (!(config.Config.customer[i].getFullName() == ""))
                {
                    Console.WriteLine($"{row}. customer: {config.Config.customer[i].getFullName()}");
                    tempArray.Add(config.Config.customer[i].getFullName());
                    count++;
                }
                row++;
            }

            //customeri sec ve cixart
            string custName = "";
            int roomNum = 0;
            do
            {
                int customer = MenuUtil.getInteger("Please select the customer above (row number): ");

                if (customer <= count)
                {

                    //customer arrayinde "" et && hotel arrayinda "Empty" et
                    for (int i = 0; i < config.Config.customer.Count; i++)
                    {
                        if (config.Config.customer[i].getFullName() == tempArray[customer - 1])
                        {
                            //customer
                            custName = config.Config.customer[i].getFullName();
                            config.Config.customer[i].setFullName("");
                            config.Config.customer[i].setId("");

                            //hotel
                            roomNum = config.Config.hotel[i].getRoomNumber();
                            config.Config.hotel[i].setRoomStatus(false);
                        }
                    }

                    //yekun
                    MenuUtil.sleep(5, 450);
                    Console.WriteLine($"\nRoom number: {roomNum} is empty now\nCustomer: {custName} leaved...");

                    break;
                }
                else
                {
                    Console.WriteLine("\nThere is not customer in selected row...\nTry again please...\n");
                }
            } while (true);

            Console.WriteLine("\nCheking-out procces is completed...");

        }

        public static void Menu_Services()
        {
            //hotelde musteri olub olmamasini yoxlayir
            int check = 0;
            for (int i = 0; i < config.Config.hotel.Count; i++)
            {
                if (config.Config.hotel[i].isRoomStatus() == true)
                {
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("\nThere is not any customer in the hotel...\n");
                main.run();

            }

            Console.WriteLine("\n\tWelcome to the Services system\n");
            MenuUtil.servicesMenu();

            //servislerden secim edir
            int service = 0;
            do
            {
                service = MenuUtil.getInteger("Please select the service above: ");

                if (service <= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nThere is not any service in selected row\nTry again please...\n");
                }
            } while (true);

            //esas proses
            switch (service)
            {
                case 1:
                    selectService("cleaning");
                    break;
                case 2:
                    selectService("dinner");
                    break;
            }

            #region Xidmetler
            static void selectService(string service)
            {
                int room = 0;

                //otagin olub olmamasini yoxla
                do
                {
                    room = MenuUtil.getInteger("Please select the room: ");

                    if (room <= config.Config.hotel.Count) //esas proses
                    {
                        if (config.Config.customer[room - 1].getFullName() != "")
                        {
                            MenuUtil.sleep(5, 350);

                            Console.WriteLine(
                                $"\n{room}. room took {service} service" +
                                $"\nCustomer: {config.Config.customer[room - 1].getFullName()}" +
                                $"\nDate: {DateTime.Now.ToString("dd.mm.yyyy")}" +
                                "\n"
                                );

                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nSelected room is empty now...\nTry another please...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThere is not room in selected number\nTry again please...\n");
                    }

                } while (true);
            }
            #endregion

            //yekun
            Console.WriteLine("\nService is completed...");

        }

    }
}

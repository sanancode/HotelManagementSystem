using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Week5_Thursday.main;
using Week5_Thursday.util;

namespace Week5_Thursday.config
{
    internal class CreateHotel
    {

        public static void createHotel()
        {

            //otaq sayi
            int roomCount = MenuUtil.getInteger("PLease enter the room count: ");

            for (int i = 0; i < roomCount; i++)
            {
                Random rnd = new Random();

                //otaq nomreleri
                int roomNumber = i + 1;

                //carpayi sayi
                int bedCount = rnd.Next(1, 4);

                //otagin qiymeti
                float price = (float)rnd.NextDouble() * 1000;

                //otaq seviyyesi
                string roomLevelString;
                if (price >= 0 && price <= 100)
                {
                    roomLevelString = "Econom";
                }
                else if (price > 100 && price <= 500)
                {
                    roomLevelString = "Standart";
                }
                else
                {
                    roomLevelString = "VIP";
                }

                //room status
                bool roomStatusBool = false;

                //yekun
                Config.hotel.Add(new Classes.Hotel(roomNumber, bedCount, price, roomLevelString, roomStatusBool));
                Config.customer.Add(new Classes.Customer("", ""));

            }

            MenuUtil.sleep(5, 300);
            Console.WriteLine($"\nHotel created...\n{roomCount} rooms added");
        } //oteldeki otaqlari yaradir



    }
}

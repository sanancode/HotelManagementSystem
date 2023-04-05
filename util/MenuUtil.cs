using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Thursday.util
{
    internal class MenuUtil
    {

        public static void mainMenu()
        {
            Console.WriteLine(
                "\n\tMENU" +
                "\n0. Show all rooms" +
                "\n1. Check-in customer" +
                "\n2. Check-out customer" +
                "\n3. Special services" +
                "\n4. Exit the System");
        } //esas menyunu gosterir

        public static void servicesMenu()
        {
            Console.WriteLine(
                "1. Cleaning" +
                "\n2. Dinner service");
        } //xidmetler menyusunu gosterir

        public static int getInteger(string title)
        {
            Console.Write(title);
            return int.Parse(Console.ReadLine());
        }

        public static string getString(string title)
        {
            Console.Write(title);
            return Console.ReadLine();
        }

        public static void sleep(int times, int millis)
        {
            Console.Write("\nWait a minute please ");
            for (int i = 1; i <= times; i++)
            {
                Thread.Sleep(millis);
                Console.Write(". ");
            }
            Console.WriteLine("\n");
        }

    }
}

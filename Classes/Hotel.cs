using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Thursday.Classes
{
    internal class Hotel
    {

        private int roomNumber;
        private int bedCount;
        private float price;
        private string roomLevel;
        private bool roomStatus;

        public Hotel(int roomNumber, int bedCount,
            float price, string roomLevel, bool roomStatus)
        {
            this.roomNumber = roomNumber;
            this.bedCount = bedCount;
            this.price = (int)price;
            this.roomLevel = roomLevel;
            this.roomStatus = roomStatus;
        }

        public void showAll(int index)
        {
            string roomStatus_;
            if (roomStatus == true)
            {
                roomStatus_ = "Reserved";
            }
            else
            {
                roomStatus_ = "Empty";
            }

            Console.WriteLine(
                "\n" + $"{roomNumber}. room" +
                "\nBed count: " + bedCount +
                "\nPrice &: " + price +
                "\nRoom level: " + roomLevel +
                "\nRoom status: " + roomStatus_
                );

            if (config.Config.customer[index].getFullName() != "")
            {
                config.Config.customer[index].showAll();
            }
        }

        public bool isRoomStatus()
        {
            return roomStatus;
        }

        public void setRoomStatus(bool roomStatus)
        {
            this.roomStatus = roomStatus;
        }

        public int getRoomNumber()
        {
            return roomNumber;
        }

    }
}

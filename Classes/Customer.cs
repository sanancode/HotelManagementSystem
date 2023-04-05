using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Thursday.Classes
{
    internal class Customer
    {

        private string fullName;
        private string id;

        public Customer(string fullName, string id)
        {
            this.fullName = fullName;
            this.id = id;
        }

        public void setFullName(string fullName)
        {
            this.fullName=fullName;
        }

        public string getFullName()
        {
            return this.fullName;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public void showAll()
        {
            Console.WriteLine(
                "Customer: " + fullName + 
                "\nId: " + id);
        }

    }
}

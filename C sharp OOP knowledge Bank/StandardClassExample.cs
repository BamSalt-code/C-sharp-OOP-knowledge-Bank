using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class client
    {
        // Member Variables
        public int CustID;
        public string Name;
        public string Address;

        //constuctor for initializing fields
        public client()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

        //method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }
        // Code for entry point
    }
}

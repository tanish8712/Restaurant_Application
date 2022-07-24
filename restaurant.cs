using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Application
{
    class restaurant
    {
        public string Restaurant_Name;
        public string Restaurant_Address;
        double GrandTotal = 0;

        public restaurant(string name, string address)
        {
            Restaurant_Name = name;
            Restaurant_Address = address;
        }

        public void receipt()
        {
            double Price = 0 ;
            int People;
            double Discount = 0.10;

            while(Price != -1)
            {
                GrandTotal = GrandTotal + Price;
                Console.Write("Enter price of the food [TO EXIT -1] : $ ");
                Price = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Enter number of people : ");
            People = Convert.ToInt32(Console.ReadLine());

            if (People > 5)
            {
                GrandTotal = GrandTotal - (Discount * GrandTotal);
                Console.WriteLine($"Number of People are greater than 5, so after Discount your Total is : $ {GrandTotal}");
            }
            else
            {
                Console.WriteLine($"your Total is : $ {GrandTotal}");
            }
        }

        public double grandtotal()
        {
            return GrandTotal;
        }

    }
}

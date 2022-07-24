using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Restaurant_Application
{
    class CustomerDetails
    {
        public string Name { get; set; }
        public long Number { get; set; }
        
        public void CustomerInfo()
        {
            Console.WriteLine("\nCustomer Thanks for telling your Fav Dish, So we will Provide you as a complementry because toady is our 15th anniversery :) ");
        }

        public void Thanks()
        {
            Console.WriteLine("\t\t\t\t***********Thanks For Visting Us***********".ToUpper());
        }
    }

    class MyCustomer:CustomerDetails
    {
        private string __Fav_Dish;
        private string __Payment_Method;

        public MyCustomer(string dish, string payment)
        {
            __Fav_Dish = dish;
            __Payment_Method = payment;
        }

        public void dish()
        {
            Console.WriteLine($"\nYour Fav dish : {__Fav_Dish}");
        }
        public void pay()
        {
            Console.WriteLine($"Payment Method will be : {__Payment_Method}");
        }
    }
}

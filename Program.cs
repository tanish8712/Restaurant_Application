using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Restaurant_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t****************** WELCOME TO OUR RESTAURANT APPLICATION BILLING ******************");
            restaurant r1 = new restaurant("BlueBarry", "SRM Nagar, Potheri");
            Console.WriteLine($"Restaurant Name : { r1.Restaurant_Name}");
            Console.WriteLine($"Our Address is : {r1.Restaurant_Address}");
            Console.Write("Plz Give your Review : ");
            string review = Console.ReadLine();
            Console.Write($"Thanks for your Review : {review}\n");
            Console.WriteLine();
            r1.receipt();

            var customer = new List<CustomerDetails>()
            {
                new CustomerDetails {Name = "Raj",Number = 142526},
                new CustomerDetails {Name = "Sam",Number = 156526},
                new CustomerDetails {Name = "Rahul",Number = 140026},
                new CustomerDetails {Name = "Mohan",Number = 882521},
            };
            Console.Write("Enter your Name plz : ");
            string user = Console.ReadLine();
            //using Lamda function
            var res = customer.FirstOrDefault(p => p.Name == user);
            
            if(res == null)
            {
                Console.WriteLine($"customer not found : Mr./Mrs. {user} you are new customer, So you are not eligible for another Discount");
            }
            else
            {
                Console.WriteLine($"\nMr./Mrs. {res.Name} you are our Old customer, you will get Old customer's Discount also :)\n ");
                double total = r1.grandtotal();
                double Bill = total - (0.05 * total);
                int B1 = Convert.ToInt32(Bill);
                Console.WriteLine($"As you are our old customer , your Total Bill is after additional discount is : $ {Bill}");
                //using Humanizer Nuget package library
                Console.WriteLine($"Bill in Words : {B1.ToWords().ToUpper()}");
                Console.WriteLine("\n\t\t++ HAPPY CUSTOMER ++");
            }
           
            Console.Write("\nAnd your Payment Method : ");
            string pa = Console.ReadLine();
            Console.WriteLine("We have a Surprise for our every Customer :) :)\n");
            Console.Write("\nEnter your Fav Sweet Dish : ");
            string d = Console.ReadLine();
            MyCustomer my = new MyCustomer(d, pa);
            my.CustomerInfo();
            my.dish();
            my.pay();
            //using Date time function 
            DateTime now = DateTime.Now;
            Console.WriteLine($"\nBill Paid at : {now}");
            Console.WriteLine("\nYour Old customers who are eligible for Discount :) \n");
            foreach(var cust in customer)
            {
                Console.WriteLine($"Old Customers of our Restaurant are : {cust.Name} and mobile no. -> {cust.Number}");
            }
            Console.WriteLine();
            my.Thanks();
            Console.ReadLine(); 
        }
    }
}

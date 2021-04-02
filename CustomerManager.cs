using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("We have gained a new customer : " + customer.CustomerName );
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("We lost our customer : " + customer.CustomerName);
        }

        public void Display(Customer[] customers)
        {
            Console.WriteLine("Customer's Features");
            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerId);
                Console.WriteLine(item.CustomerName);
                Console.WriteLine(item.CustomerSurname);
                Console.WriteLine(item.CustomerEmail);
                Console.WriteLine(item.CustomerPhone);
                Console.WriteLine("-----------------------");
            }
        }

        public void Since(Customer customer)
        {
            int tmp = 2021 - customer.SinceCustomer;
            Console.WriteLine(tmp + " years");

        }
    }
}

using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the customer information system");

            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Kamran";
            customer1.CustomerSurname = "Hasanli";
            customer1.CustomerEmail = "kamran312321@gmail.com";
            customer1.CustomerPhone = "+9945736282912";
            customer1.SinceCustomer = 2000;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Atilla";
            customer2.CustomerSurname = "Ugur";
            customer2.CustomerEmail = "atillaugur4567@hotmail.com";
            customer2.CustomerPhone = "+90457365555934";
            customer2.SinceCustomer = 2007;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Customer[] customers = new Customer[] {customer1 , customer2 };
            customerManager.Display(customers);
            customerManager.Since(customer1);
            customerManager.Since(customer2);
            customerManager.Remove(customer2);
        }
    }
}

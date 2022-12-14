using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Eren Ali";
            customer1.Address = "Yeni mah.";
            customer1.City = "Aydın";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Azra Betül";
            customer2.Address = "Yeni mah.";
            customer2.City = "Afyon";

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Address);
                Console.WriteLine(customer.City);
                Console.WriteLine("  ");
            }
            Console.WriteLine("--------Customer Metodları--------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);


        }
    }
}

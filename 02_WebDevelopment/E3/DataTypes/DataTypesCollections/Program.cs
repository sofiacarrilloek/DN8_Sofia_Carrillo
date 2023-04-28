using System;
using System.Collections.Generic;

namespace DataTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            DateTime now = DateTime.Now;

            // Add parts to the list.

            customers.Add(new Customer() { CustomerName = "Sofia", CustomerLastName = "Carrillo", CustomerDateTime = now, CustomerId = 1234 });
            customers.Add(new Customer() { CustomerName = "Adrian", CustomerLastName = "Munoz", CustomerDateTime = now, CustomerId = 1334 });
            customers.Add(new Customer() { CustomerName = "Dennis", CustomerLastName = "Yam", CustomerDateTime = now, CustomerId = 1434 });
            customers.Add(new Customer() { CustomerName = "Yessel", CustomerLastName = "May", CustomerDateTime = now, CustomerId = 3030 });
            customers.Add(new Customer() { CustomerName = "Fanny", CustomerLastName = "May", CustomerDateTime = now, CustomerId = 4040 });
            customers.Add(new Customer() { CustomerName = "Marcela", CustomerLastName = "Dominguez", CustomerDateTime = now, CustomerId = 5050 });
            customers.Add(new Customer() { CustomerName = "Ariatne", CustomerLastName = "Moo", CustomerDateTime = now, CustomerId = 6060 });
            customers.Add(new Customer() { CustomerName = "Diego", CustomerLastName = "Cima", CustomerDateTime = now, CustomerId = 7070 });
            customers.Add(new Customer() { CustomerName = "Miguel", CustomerLastName = "Ciau", CustomerDateTime = now, CustomerId = 8080 });
            customers.Add(new Customer() { CustomerName = "Sayuri", CustomerLastName = "Cauich", CustomerDateTime = now, CustomerId = 9090 });


            Console.WriteLine("-------------Foreach-------------");
            foreach (Customer aCustomer in customers)
            {
                Console.WriteLine(aCustomer);
            }

            Console.WriteLine("-------------For-------------");
            int i = 0;
            for ( i=0; i<customers.Count; i++)
            {
                Console.WriteLine(customers[i]);
            }

            Console.WriteLine("-------------While-------------");

            i = 0;
            while (i < customers.Count)
            {
                Console.WriteLine(customers[i]);
                i++;
            }

            Console.WriteLine("-------------Do While-------------");

            i = 0;
            do
            {
                Console.WriteLine(customers[i]);
                i++;
            }
            while (i < customers.Count);
            
        }
    }
}

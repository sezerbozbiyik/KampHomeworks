using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Name = "Samet";
            customer1.Surname = "Bozbıyık";
            customer1.TcNo = "111111111";

            Customers customer2 = new Customers();
            customer2.Name = "Mehmet";
            customer2.Surname = "Bozbıyık";
            customer2.TcNo = "222222222";

            Customers customer3 = new Customers();
            customer3.Name = "İsmet";
            customer3.Surname = "Bozbıyık";
            customer3.TcNo = "333333333";

            CustomerManager CustomerManager = new CustomerManager();

            CustomerManager.Add(customer1);
            CustomerManager.Add(customer2);
            CustomerManager.Add(customer3);

            CustomerManager.Delete(customer1);

            Console.WriteLine("---------------------");

            Customers[] customers = new[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.TcNo);
            }

        }
    }
}

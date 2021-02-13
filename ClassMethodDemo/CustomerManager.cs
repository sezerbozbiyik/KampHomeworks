using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customers customer)
        {
            Console.WriteLine(customer.Name + " müşterisi Eklendi..");
        }
        public void Delete(Customers customer)
        {
            Console.WriteLine(customer.Name + " müşterisi Silindi..");
        }


    }
}

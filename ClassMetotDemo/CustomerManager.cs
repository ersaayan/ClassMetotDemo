using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri EKlendi. Eklenen müşterinin adı: " + customer.Name);
        }
        public void Update(Customer customer) 
        {
            Console.WriteLine("Müşteri güncellendi. Güncellenen müşterinin adı: " + customer.Name);
        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine("Müşteri silindi. Silinen müşterinin adı: " + customer.Name);
        }
        

    }
}

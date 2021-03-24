using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerInfo
{
    class CustomerManager
    {
        public void Add(int Id, string Name, string Surname, int Age)
        {
            Console.WriteLine("Tebrikler, müşteri " + Id + " eklendi!");
        }

       
        public void List(int Id, string Name, string Surname, int Age)
        {
            Console.WriteLine("Listeleme başarılı!");
        }

        public void Delete(int Id, string Name, string Surname, int Age)
        {
            Console.WriteLine("Tebrikler, müşteri " + Id + " silindi!");
        }
    }
}

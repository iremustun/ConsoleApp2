using System;

namespace CustomerInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ayşe";
            customer1.Surname = "Yılmaz";
            customer1.Age = 25;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Selim";
            customer2.Surname = "Saygın";
            customer2.Age = 38;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Tarık";
            customer3.Surname = "Bozgun";
            customer3.Age = 32;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Ahmet";
            customer4.Surname = "Demir";
            customer4.Age = 21;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + ". " + customer.Name + " " + customer.Surname + " " + customer.Age);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(3, "Tarık", "Bozgun", 32);
            customerManager.List(4, "Ahmet", "Demir", 21);
            customerManager.Delete(1, "Ayşe", "Yılmaz", 25);
        }
    }
}

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Indivisual indivisual1 = new Indivisual();
            indivisual1.CustomerNumber = "12345";
            indivisual1.CustomerName = "Çağan";
            indivisual1.CustomerLastName = "Parmaksız";
            indivisual1.TcNo = "13123432254";

            //Kodlama.io
            Corporate corporate1 = new Corporate();
            corporate1.CustomerId = 2;
            corporate1.CustomerNumber = "123125";
            corporate1.CompanyName = "Kodlama.io";
            corporate1.TaxNo = "1234567890";

            Customer customer = new Indivisual();
            Customer customer1 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer1);


        }
    }
}

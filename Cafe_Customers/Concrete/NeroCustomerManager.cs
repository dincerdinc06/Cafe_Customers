using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Customers
{
    class NeroCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper() + " Adlı Müşteri Başarıyla Eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper() + " Adlı Müşteri Başarıyla Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper() + " Adlı Müşteri Başarıyla Güncellendi.");
        }
    }
}

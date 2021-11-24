using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Customers
{
    class CustomerManager : ICustomerService
    {
        private ICustomerChechService customerChechService;

        public CustomerManager(ICustomerChechService chechService)
        {
            customerChechService = chechService;
        }
        public void Add(Customer customer)
        {
            if(customerChechService.Chech(customer))
            {
                Console.WriteLine(customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper() + " Adlı Müşteri Başarıyla Eklendi.");
            }
            else
            {
                Console.WriteLine("Müşteri Bilgileri Doğrulanamadı.");
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper() + " Adlı Müşteri Başarıyla Silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper() + " Adlı Müşteri Başarıyla Güncellendi.");
        }
    }
}

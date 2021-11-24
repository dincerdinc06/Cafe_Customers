using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Customers
{
    class StarbucksCustomerManager:ICustomerService
    {
        private ICustomerChechService customerChechService;

        public StarbucksCustomerManager(ICustomerChechService ChechService)
        {
            customerChechService = ChechService;
        }
        public void Add(Customer customer)
        {
            if (customerChechService.Chech(customer))
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

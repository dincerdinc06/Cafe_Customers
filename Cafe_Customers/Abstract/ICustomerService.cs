using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Customers
{
    interface ICustomerService
    {
        void Add(Customer customer);

        void Delete(Customer customer);

        void Update(Customer customer);
    }
}

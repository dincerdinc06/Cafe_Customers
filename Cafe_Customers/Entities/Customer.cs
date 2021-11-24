using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Customers
{
    class Customer
    {
        public Customer(int id,long nationalityid,string firstName,string lastname,DateTime dateofbirth)
        {
            this.Id = id;
            this.NationalityId = nationalityid;
            this.FirstName = firstName;
            this.LastName = lastname;
            this.DateofBirth = dateofbirth;
        }
        public Customer()
        {
                
        }
        public int Id { get; set; }

        public long NationalityId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }

    }
}

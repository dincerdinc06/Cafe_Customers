using System;
using MernisServiceReference;

namespace Cafe_Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1,11656188196,"Dinçer","Dinç", new DateTime(2000, 8, 25));

            ICustomerService starbuckscustomermanager = new StarbucksCustomerManager(new MernisCheckAdapter());
            starbuckscustomermanager.Add(c1);

            ICustomerService nerocustomermanager = new NeroCustomerManager();
            nerocustomermanager.Add(c1);

            Console.ReadLine();
        }
    }
}

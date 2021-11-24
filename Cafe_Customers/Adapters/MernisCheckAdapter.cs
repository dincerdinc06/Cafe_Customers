using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace Cafe_Customers
{
    class MernisCheckAdapter : ICustomerChechService
    {
        public bool Chech(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateofBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before Interface
            //Customer c1 = new Customer();
            //c1.Fistname = "Engin";
            //c1.Lastname = "Demiroğ";
            //c1.Id = 1;
            //c1.IdentityNo = "12345678910" ; // Tüzel müşterinin tc numarası, adı soyadı olmaz.
            //c1.CustomerNo = "12345" ;
            //c1.CompanyName = "?" ;  // Gerçek müşterinin şirket adı olmaz.

            // Gerçek - Tüzel(Şirket) olmak üzere iki tür müşterin var. İkisininde farklı özellikleri olabilir. O yüzden tek classta oluşturmak hatadır.
            #endregion
            // SOLID PRINCIPLES 

            IndividualCustomer c1 = new IndividualCustomer
            {
                Id = 1,
                CustomerNo = "12345",
                IdentityNo = "12345678910",
                Firstname = "Engin",
                Lastname = "Demiroğ"
            };

            CoorporateCustomer c2 = new CoorporateCustomer
            {
                Id = 2,
                CustomerNo = "54321",
                CompanyName = "Kodlama.io",
                TaxNumber = "1234567890"
            };

            Customer c3 = new IndividualCustomer();
            Customer c4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(c1);
            customerManager.Add(c2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Customer class'ından inherit edildi. - Miras
    // CoorporateCustomer is a Customer
    class CoorporateCustomer : Customer  //Tüzel Müşteri - LegalEntity
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // IndividualCutomer is a Customer. It inherits from Customer class.
    class IndividualCustomer : Customer // Gerçek Müşteri
    {
        public string IdentityNo { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}

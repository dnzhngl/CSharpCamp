using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Base class for Individual and Coorporate customer classes
    class Customer
    {
        #region Parçalamadan önce

        /*Eğer ki bir nesne de bir değeri kullanmak zorunda gibi görünmüyorsan, o alan o nesneye ait değilmiş gibi görünmüyorsa orada soyutlama hatası vardır.*/

        //public int Id { get; set; }
        //public string CustomerNo { get; set; }
        //public string IdentityNo { get; set; }
        //public string Firstname { get; set; }
        //public string Lastname { get; set; }
        //public string CompanyName { get; set; }
        //public string TaxNumber { get; set; }
        #endregion
         
        // Classların 2 tane özelliği vardır: içerisinde özellikler(properties) ya da operasyonlar(operations, methods, business) tutarlar.
        // Özellik tuttuğumuz yerde operasyon tutmayız. İkisini aynı yerde tutmayız.

        // eğer bir base sınıfın varsa o base sınıf referans tutucudur.

        public int Id { get; set; }
        public string CustomerNo { get; set; }

    }
}



using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array örneği
            //string[] nameList = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(nameList[0]);
            //Console.WriteLine(nameList[1]);
            //Console.WriteLine(nameList[2]);
            //Console.WriteLine(nameList[3]);
            // Console.WriteLine(nameList[4]); OutOfRange Hatası verir.

            //nameList = new string[5];   // Sıfırdan yeni dizi oluşturur. Eski elemanları kaybedersin.
            //nameList[4] = "İlker";
            //Console.WriteLine(nameList[4]);
            //Console.WriteLine(nameList[0]); // Dizinin ilk 4 elemanı boştur.
            #endregion

            #region List
            List<string> isimler = new List<string> {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            isimler.Add("İlker");
            //Console.WriteLine(isimler[4]);
            #endregion

        }
    }
}

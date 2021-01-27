using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 = 30
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;    //sayilar[0] = 999 olur. sayilar1'e, sayilar2'nin referans adresi atanır. Yani bellekte ikisi de aynı yeri gösterir. Birinde yapılan değişiklik doğal olarak öbüründe de yapılmış olur.
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);


            string isim = "Ali";
            string isim2 = "Veli";
            isim = isim2;
            isim2 = "Ayşe";
            Console.WriteLine(isim);
        }
    }
}

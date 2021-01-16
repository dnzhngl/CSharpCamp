using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            //Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            //Console.WriteLine(ogrenciSayisi);
            double faizOranı = 1.45;
            #endregion

            #region if else
            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayaları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            #endregion

            #region if else elif
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }
            #endregion

            #region Nested Ternary If
            int x = 5, y = 10, z = 15;

            int result = x > y ? x :
                y > z ? y :
                z;

            Console.WriteLine(result);
            #endregion

        }
    }
}

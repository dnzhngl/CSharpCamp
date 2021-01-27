using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region for
            //for (int i = 1; i < 10; i +=2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region while
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            do
            {
                Console.WriteLine(j);
                j--;
            } while (j >= 0);

            #endregion

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Giriş için Temel Kurs";
            string kurs3 = "Java";

            //string[] Kurslar = { kurs1, kurs2, kurs3 };
            //string[] kurslar = new string[] { kurs1, kurs2, kurs3, };
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Giriş için Temel Kurs", "Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            #region foreach
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            #endregion

            Console.WriteLine("Sayfa Sonu - footer");

            Console.ReadLine();
        }
    }
}

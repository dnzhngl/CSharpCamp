using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string adi = "Engin";
        //    int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Eğitmen = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 53;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Eğitmen = "Kerem Varış";
            kurs3.IzlenmeOrani = 64;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani  { get; set; }
    }

}

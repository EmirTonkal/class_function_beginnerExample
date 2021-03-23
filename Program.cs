using System;

namespace class_function_beginnerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();
            musteri1.musteriAdi = "Emir";
            musteri1.musteriSoyadi = "Tonkal";
            musteri1.musteriId = 1;

            musteri musteri2 = new musteri();
            musteri2.musteriAdi = "Ali";
            musteri2.musteriSoyadi = "Veli";
            musteri2.musteriId = 2;

            musteri[] musteriListe = new musteri[] { musteri1, musteri2 };
            /* foreach (musteri a in musteriListe)
            {
                Console.WriteLine(a.musteriAdi);
            } */

            musteriManager musteriManager1 = new musteriManager();
            musteriManager1.add(musteri1);

        }

        class musteri
        {
            public int musteriId { get; set; }
            public string musteriAdi { get; set; }
            public string musteriSoyadi { get; set; }

        }

        class musteriManager
        {
            public void add(musteri musteri) { Console.WriteLine(musteri.musteriAdi + " eklendi"); }
            public void update(musteri musteri) { Console.WriteLine(musteri.musteriAdi + " güncellendi"); }
            public void delete(musteri musteri) { Console.WriteLine(musteri.musteriAdi + " silindi"); }
        }



    }
}

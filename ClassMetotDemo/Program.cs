using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Sergen Bilgin";
            musteri1.Id = 383;
            musteri1.Bakiye = -20000;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Burak Erdem";
            musteri2.Id = 400;
            musteri2.Bakiye = -25000;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Metin Ünlü";
            musteri3.Id = 321;
            musteri3.Bakiye = 45000;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager manager = new MusteriManager();
            manager.Listele(musteriler);

            foreach (Musteri item in musteriler)
            {

                Console.WriteLine(manager.BakiyeSor(item));
            }


        }
    }
}

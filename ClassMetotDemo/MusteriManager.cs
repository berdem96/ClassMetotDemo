using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] Liste)
        {
            foreach (Musteri item in Liste)
            {
                Console.WriteLine("Müsteri Adı ="+ item.Name + "\n");
            }
        }


        public double BakiyeSor(Musteri musteri)
        {
            return musteri.Bakiye;


        }

    
    }
}

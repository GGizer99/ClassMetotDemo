using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri m)
        {
            Console.WriteLine("Sayin" + " " + m.Ad + " " + m.Soyad + " " + "Eklendi"); 
        } 

        public void Silme(Musteri m)
        {
          
            Console.WriteLine("Sayin" + " " + m.Ad + " " + m.Soyad + " " + "Silindi");
        }

        public void Listele(Musteri[] m)
        {
            Console.WriteLine("----------Müşteriler---------");
            foreach (Musteri x in m)
            {
                Console.WriteLine("İSİM SOYİSİM : " + " " + x.Ad+ " " + x.Soyad + " : " + "Müsteri Bakiye : "+ " " + x.Bakiye );
            }
        }
    }
}

using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { };
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Soyadı1";
            musteri1.Id = 1111;
            musteri1.Bakiye = 10000;

            Musteri musteri2 = new Musteri() { };
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Soyadı2";
            musteri2.Id = 2222;
            musteri2.Bakiye = 20000;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteriler);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);

        }
    }
}

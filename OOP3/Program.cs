using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ferhat Adibelli
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ferhat";
            musteri1.Soyadi = "Adibelli";
            musteri1.TcNo = "12345678910";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";

            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Müsteri musteri3 = new GercekMusteri();
            Müsteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);

            
            //Gerçek - Tüzel müşteri
          


        }
    }
}

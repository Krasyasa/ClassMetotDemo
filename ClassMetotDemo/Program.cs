using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteri = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Çağan";
            musteri1.Soyad = "Parmaksız";
            musteri1.Bakiye = 2500;

            Musteri musteri2 = new Musteri();
            
            musteri2.Id = 2;
            musteri2.Isim = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.Bakiye = 3000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteri.Add(musteri1);
            Console.WriteLine("Müşteri 1 eklendi");
            musteri.Add(musteri2);
            Console.WriteLine("Müşteri 2 eklendi");
            musteri.List(musteri1);
            musteri.Delete(musteri1);

            
            
            
            

        }
    }
}

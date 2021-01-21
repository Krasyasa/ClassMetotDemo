using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adi : " + musteri.Isim);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Bakiyesi : " + musteri.Bakiye);
            Console.WriteLine("Kayıt Eklendi");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adi : " + musteri.Isim);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            Console.WriteLine("Müşteri Bakiyesi : " + musteri.Bakiye);
            Console.WriteLine("Kayıt Listesi");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Kayıt silindi");
        }

    }
}

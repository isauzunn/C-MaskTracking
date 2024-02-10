using Business.Concrete;
using System;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;

namespace WorkAround
{
    class Program
    {

        static void Main(string[] args)
        {
            SelamVer(isim: "İsa");
            SelamVer(isim: "Şüheda");
            SelamVer(isim: "Mehmet");

            SelamVer();


            int sonuc = Topla(6,58);

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for(int i =0; i< ogrenciler.Length;i++)
            {
                Console.WriteLine(ogrenciler[1]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirsName = "İsa";
            person1.LastName = "Uzun";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 12345678910;

            Person person2 = new Person();
            person2.FirsName = "Ahmet";

            foreach( string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add("İzmir");
            
            foreach( string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());

            pttManager.GiveMask(person1);



            Console.ReadLine();







        }

        static void SelamVer(string isim ="isimsiz")
        {
            Console.WriteLine("Merhaba"+isim);

        }
        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam"+sonuc.ToString());
            return sonuc;

        }


            
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

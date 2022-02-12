using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Degiskenler();



            // Mantıksal olarak gruplandırma. Değişkenleri bir kutuya koyarız (class) sonra ona bir isim veririz ve o artık bir nesne olmuş olur.



            Vatandas vatandas1 = new Vatandas(); // Bir tane vatandaş oluşturdum demek. instance-örnek.

            SelamVer(isim: Console.ReadLine());
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");

            SelamVer();


            int sonuc = Topla(50);

            Console.WriteLine("-------------");

            // dizi ---> array

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";
            string ogrenci4 = "İlker";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = ogrenci1;
            ogrenciler[1] = ogrenci2;
            ogrenciler[2] = ogrenci3;
            //ogrenciler[3] = ogrenci4; dizi sınırı 3. onu aştı hata verir.

            ogrenciler = new string[4]; //eleman sayısını 4'e çektik.
            ogrenciler[3] = ogrenci4;   // tekrardan new lediğimiz için heap'te yeni bir alan ayırdı ve ilkeri oraya koydu, yukarıdaki ayrılan alan iptal oldu. yenisinde üçü boş kaldı ve sadece ilkeri yazmış oldu.




            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Console.WriteLine("-------------");

            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine(ogr);
            }

            Console.WriteLine("----------");


            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1; // değeri atamak olarak düşünme. sehirler2'nin referansı eşittir sehirler1'in referansı diye okuruz.
            sehirler1[0] ="Adana";

            Console.WriteLine(sehirler2[0]);

            Console.WriteLine("-------");


            List<string> yeniSehirler1 = new List<string> { "Ankara 2","İstanbul 2","İzmir 2"}; //üç elemanlı bir liste. Aynı zamanda 3 elemanlı bir dizi. .NETFramework ile gelmiştir.
            yeniSehirler1.Add("Adana 2");

           // list bir class tır.
                
            
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }






            Console.WriteLine("---------");





            int sayi1 = 10;
            int sayi2 = 20;

            sayi2=sayi1;
            sayi1 = 30;

            Console.WriteLine(sayi2); //ekrana 10 yazar.
        }

        static void SelamVer(string isim = "no name")  // burası parametre. No name= default parameter dedik.
        {
            // Bu yapıya metot deriz.
            // Bir sürü kod olabilir. Bir işi yapacak kodu bir bloğa koyarız ve proje içerisinde bunu çağırırız.
            // void metotlar sadece işi yapar, herhangi bir bilgi vermez değer döndürmez. (Emir kipiyle çalışır, git bunu yap git bunu kaydet...)

            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)      // dafault verirsek kullanıcı girerse onu alır girmezse default alır.    // eğer bir değer oluşturmak istiyorsak değer döndüren fonksiyonlardan yararlanırız.
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }




















        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;


            string ad = "Engin";
            string soyadi = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        // class içerisinde vatandaşa ait bilgileri koyduk.

        // başlarına public eklemeden yazınca yukarıda çalışmadı. Sadece bu class ın içinde çalışır. Başına public eklemek "Dışarıdan da kullanılsın" demektir.

        // prop yaz tab tab

        // pascal casing

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }









    }



}
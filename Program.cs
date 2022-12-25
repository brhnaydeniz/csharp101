using System;

namespace console_programlama;

    class Program
    {
        public static void Main(string[] args)
        {
            DateTime tarih_saat = DateTime.Now;
            Console.WriteLine("İsminizi Giriniz");
            string name =Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Sayın " + name + " " + surname + " " + "Hoşgeldiniz" + " --  Son Giriş : " + tarih_saat);
        
        string yapilacak_islem;
        Console.WriteLine("Yapmak İstediginiz islemi girin  = ( Hesap Makinesi , Kargo Ucreti )");
        yapilacak_islem = Console.ReadLine();
        if (yapilacak_islem == "Hesap Makinesi")
        {
        int sayi1 , sayi2 ;
        double sonuc ; 
        string islem ;
       
       Console.WriteLine("Birinci Sayıyı Giriniz    :");
       sayi1 = Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine("İkinci Sayıyı Giriniz     :");
       sayi2 = Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine("Yapacagınız İslemi Secin (- , + , / , *  )  ");
       islem = Console.ReadLine();
       
       if (islem == "-")
       {
           sonuc = sayi1-sayi2;
           Console.WriteLine("Sonuc     : " + sonuc);
       }
       
       if (islem == "+")
       {
           sonuc = sayi1+sayi2;
           Console.WriteLine("Sonuc     : " + sonuc);
       }
       
       if (islem == "/")
       {
           sonuc = sayi1/sayi2;
           Console.WriteLine("Sonuc     :" + sonuc);
       }
       if (islem == "*")
       {
           sonuc = sayi1*sayi2;
           Console.WriteLine("Sonuc     : " + sonuc);
           
       }
       Console.ReadKey();
        }
    if(yapilacak_islem == "Kargo Ucreti Hesaplama")
    {
        double odeme_tutari ; 
        Console.WriteLine("Urun fiyati Giriniz");
        double fiyat = Convert.ToDouble(Console.ReadLine());
        if (fiyat >= 100)
        {
            odeme_tutari = fiyat ; 
        }
        else 
        odeme_tutari = fiyat + 5;
        
        Console.WriteLine("Odemeniz Gereken Tutar {0} Tl'dir" , odeme_tutari);
    }
        }
    }
    
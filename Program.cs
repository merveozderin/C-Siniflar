﻿using System;

namespace Sınıf_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan() ;
            calisan1.Ad = "Merve" ;
            calisan1.Soyad = "Özderin" ;
            calisan1.No = 12345678 ;
            calisan1.Departman = "ARGE" ;

            Calisan calisan2 = new Calisan() ;
            calisan2.Ad = "Deniz" ;
            calisan2.Soyad = "Gökyüzü" ;
            calisan2.No = 87654321 ;
            calisan2.Departman = "İnsan Kaynakları" ;

            calisan1.CalisanBilgileri() ;
            Console.WriteLine("**************") ;
            calisan2.CalisanBilgileri() ;
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad) ;
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad) ;
            Console.WriteLine("Çalışanın Numarası:{0}", No) ;
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman) ;
        }

    }
}

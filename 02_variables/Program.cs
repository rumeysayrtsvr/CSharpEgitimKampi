using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler
            double number;
            number = 4.85;
            Console.WriteLine(number);
            Console.WriteLine();

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine("---------------------------------------");

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 12.5;
            orangePrice = 20;
            strawberryPrice = 40;
            potatoPrice = 12;
            tomatoPrice = 25;

            Console.WriteLine("----- Elma Birim Fiyatı:" + applePrice + "TL");
            Console.WriteLine("----- Portakal Birim Fiyatı:" + orangePrice + "TL");
            Console.WriteLine("----- Çilekl Birim Fiyatı:" + strawberryPrice + "TL");
            Console.WriteLine("----- Patates Birim Fiyatı:" + potatoPrice + "TL");
            Console.WriteLine("----- Domates Birim Fiyatı:" + tomatoPrice + "TL");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alınan ürün: Elma - Birim Fiyat:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Portakal - Birim Fiyat:" + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Çilek - Birim Fiyat:" + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Patates - Birim Fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Domates - Birim Fiyat:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("---------------------------------------");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            

            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");
            Console.WriteLine();
            #endregion



            #region CharDegiskenler

            char symbol = 'a';
            Console.WriteLine(symbol);
            ;
            #endregion




            #region KlavyedenVeriGirisleri

            Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            Console.WriteLine("---------------------------------------");

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcunun Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcunun TC Kimliği: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " " +
                "Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " +
                passengerDistrict + "/" + passengerCity + " " + passengerAge);
            Console.WriteLine();
            #endregion




            #region Klavyeden Tam Sayı Girisleri Ve Donusumler

            //C# veri girişlerinin tamamını string olarak düşünür

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 2000;
            chairPrice = 1500;
            tvPrice = 2000;

            int shoesCount, computerCount, chairCount, tvCount;


            Console.WriteLine("***** Alışveriş Bilgileri *****");
            Console.WriteLine("---------------------------------------");
            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            int totalPrice = shoesCount * shoesPrice +
                computerCount * computerPrice +
                chairCount * chairPrice +
                tvCount * tvPrice;

            
            Console.WriteLine("Toplam ödemeniz gereken tutar : " + totalPrice);
            Console.WriteLine();

            #endregion

            #region KlavyedenOndalikliSayiİslemleri

            double exam1, exam2, exam3, result;
            Console.WriteLine("***** Sınav Sonuç Bilgileri *****");
            Console.WriteLine("---------------------------------------");
            Console.Write("1.sınav notunuz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2.sınav notunuz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3.sınav notunuz: ");
            exam3 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            result = (exam1 + exam2 + exam3) / 3;

            
            Console.WriteLine("Sınav ortalamanız: " + result);
            Console.WriteLine();

            #endregion




            #region KlavyedenKarakterGirisleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
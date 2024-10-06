using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutlari
            Console.Write("Merhaba ");
            Console.WriteLine("Dünya");
            Console.WriteLine();


            Console.WriteLine("****Yemek Kategorileri****");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Salatalar");
            Console.WriteLine("3-Tatlılar");
            Console.WriteLine();

            #endregion




            #region String Degiskenler

            string name;
            name = "Rümeysa";
            Console.WriteLine(name);
            Console.WriteLine();

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Rümeysa";
            customerSurname = "Yurtsever";
            customerPhone = "05465812987";
            customerEmail = "rumeysayurtsvr@gmail.com";
            district = "Merkez";
            city = "Bolu";



            Console.WriteLine("****Rezervasyon Kartı****");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();


            customerName = "Feray Yaren";
            customerSurname = "Turasay";
            customerPhone = "05348697124";
            customerEmail = "turasayferay@gmail.com";
            district = "Kartal";
            city = "İstanbul";


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            #endregion




            #region Int Degiskenler

            int hambugerPrice = 300;
            int cokePrice = 20;
            int waterPrice = 5;
            int friedPrice = 100;
            int pizzaPrice = 200;
            int lemonadePrice = 150;


            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine("----------------------------");
            Console.WriteLine("---- Hamburger Fiyatı: " + hambugerPrice + "TL");
            Console.WriteLine("---- Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("---- Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("---- Kızartma Fiyatı: " + friedPrice + "TL");
            Console.WriteLine("---- Limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine("---- Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            int hamburgerCount = 2;
            int cokeCount = 0;
            int waterCount = 1;
            int friedCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 1;

            int totalPrice = 0;

            int totalHamburgerPrice = hambugerPrice * hamburgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalFriedPrice = friedPrice * friedCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;

            totalPrice = totalFriedPrice + totalLemonadePrice + totalCokePrice + totalWaterPrice + totalPizzaPrice + totalHamburgerPrice;

            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriedPrice + "TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice);

            #endregion





            Console.Read();
        }
    }
}
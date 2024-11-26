
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 22.85;

            //Console.WriteLine(number);



            //Console.WriteLine("**** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, bananaPrice, orangePrice, tomatoPrice, potatoPrice;

            //applePrice = 22.60;
            //bananaPrice = 31.99;
            //orangePrice = 15.84;
            //tomatoPrice = 6.78;
            //potatoPrice = 10.14;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Muz Birim Fiyatı: " + bananaPrice + " TL");
            //Console.WriteLine("---- Portokal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");


            //double appleGram, bananaGram, orangeGram, tomatoGram, potatoGram;

            //appleGram = 1.500;
            //bananaGram = 0.890;
            //orangeGram = 2.450;
            //tomatoGram = 0.960;
            //potatoGram = 3.154;

            //double totalApplePrice = applePrice * appleGram;
            //double totalBananaPrice = bananaPrice * bananaGram;
            //double totalOrangePrice = orangePrice * orangeGram;
            //double totalTomatoPrice = tomatoPrice * tomatoGram;
            //double totalPotatoPrice = potatoPrice * potatoGram;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün Elma - " + "Birim Fiyatı: " + applePrice + "- Gramaj: " + appleGram + "- Toplam Tutar: " + totalApplePrice);
            //Console.WriteLine("Alınan Ürün Muz - " + "Birim Fiyatı: " + bananaPrice + "- Gramaj: " + bananaGram + "- Toplam Tutar: " + totalBananaPrice);
            //Console.WriteLine("Alınan Ürün Portakal - " + "Birim Fiyatı: " + orangePrice + "- Gramaj: " + orangeGram + "- Toplam Tutar: " + totalOrangePrice);
            //Console.WriteLine("Alınan Ürün Domates - " + "Birim Fiyatı: " + tomatoPrice + "- Gramaj: " + tomatoGram + "- Toplam Tutar: " + totalTomatoPrice);
            //Console.WriteLine("Alınan Ürün Patates - " + "Birim Fiyatı: " + potatoPrice + "- Gramaj: " + potatoGram + "- Toplam Tutar: " + totalPotatoPrice);


            //Console.Read();



            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            //Console.Read();


            #endregion

            #region Klavyeden Veri Girişi String İfadeler

            //Console.WriteLine("****** Csharp Hava Yolları Yolcu Bilgisi ****** ");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "\n" + "Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + "\n" + "Yolcu Yaşı: " + passengerAge + "\n" + "Yolcu İkamet Bilgileri: " + passengerDistrict + " " + passengerCity);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 500;
            //computerPrice = 20000;
            //chairPrice = 1300;
            //tvPrice = 14500;

            //int shoesCount, computerCount, chairCount,  tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;


            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL"); 

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender; //Kız için = K; Erkek için E

            //Console.Write("Lütfen cinstiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //if (gender == 'k' || gender == 'K')
            //{
            //    Console.WriteLine("Bebeğin Cinsiyeti: KIZ");
            //}
            //else if (gender == 'e' || gender == 'E')
            //{
            //    Console.WriteLine("Bebeğin Cinsiyeti: ERKEK");
            //}
            //else
            //{
            //   Console.WriteLine("Hatalı Giriş");
            //}
            #endregion















            Console.Read();
        }
    }
}

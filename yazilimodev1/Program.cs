using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimodev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRNEK1

            //Console.WriteLine("Merhaba Dünya");
            //Console.ReadKey();
            //***************************************//


            //ÖRNEK2

            //Console.WriteLine("Adınızı Girin : ");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Girin : ");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"AD-SOYAD {ad} {soyad}");
            //Console.ReadKey();


            //ÖRNEK3

            //Console.WriteLine("Sayı giriniz");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz");
            //int sayi2=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Toplamı : ");
            //Console.WriteLine(sayi + sayi2);
            //Console.ReadKey();


            //ÖRNEK4

            //Console.WriteLine("Sayı giriniz");
            //double sayi=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz");
            //double sayi2=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Toplam Sonucu = {sayi + sayi2}");
            //Console.WriteLine($"Çıkarma Sonucu = {sayi - sayi2}");
            //Console.WriteLine($"Çarpma Sonucu = {sayi * sayi2}");
            //Console.WriteLine($"Bölme Sonucu = {sayi / sayi2}");
            //Console.ReadKey();


            //ÖRNEK5

            //Console.WriteLine("Bir Sayı Giriniz");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //int yüzde = sayi * 18 / 100;
            //Console.WriteLine("Girdiğiniz Sayının %18'i = " + yüzde);
            //Console.ReadKey();


            //ÖRNEK6

            //Console.WriteLine("Bir Sayı Giriniz");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir Yüzde Değeri Giriniz");
            //int yüzde=Convert.ToInt32(Console.ReadLine());
            //yüzde = sayi * yüzde / 100;
            //Console.WriteLine("Girdiğiniz Sayının Yüzdesi (%) = " + yüzde);
            //Console.ReadKey();


            //ÖRNEK7

            //Console.WriteLine("Bir Alış Fiyatı Giriniz");
            //double fiyat=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yüzdelik Kar Oranı Giriniz");
            //double yüzde=Convert.ToInt32(Console.ReadLine());
            //double kSatıs;
            //kSatıs = fiyat+(fiyat * yüzde / 100);
            //Console.WriteLine("Girdiğiniz alış fiyatının,girdiğiniz yüzdeliğe göre karı = " + kSatıs);
            //Console.ReadKey();


            //ÖRNEK8

            //Console.WriteLine("Uzun Kenarın değerini giriniz: ");
            //int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kısa Kenarın değerini giriniz: ");
            //int b=Convert.ToInt32(Console.ReadLine());
            //int alan = a * b;
            //int cevre = 2 * (a + b);
            //Console.WriteLine("Girdiğiniz değerlere göre Dikdörtgenin alanı = " + alan);
            //Console.WriteLine("Girdiğiniz değerlere göre Dikdörtgenin Çevresi = " + cevre);
            //Console.ReadKey();  


            //ÖRNEK9

            //int r, Pi, alan, cevre;
            //Console.WriteLine("Yarıçap Giriniz");
            //r=Convert.ToInt32(Console.ReadLine());
            //Pi = 3;
            //alan = Pi * r * r;
            //cevre = 2 * Pi * r;
            //Console.WriteLine("Girdiğiniz değere göre dairenin alanı: " + alan);
            //Console.WriteLine("Girdiğiniz değer göre dairenin çevresi: " + cevre);
            //Console.ReadKey();


            //ÖRNEK10

            //int not1, not2, not3, aOrt;
            //Console.WriteLine("Not1 girin: ");
            //not1=Convert.ToInt16(Console.ReadLine());                     
            //Console.WriteLine("Not2 girin: ");                      
            //not2 = Convert.ToInt16(Console.ReadLine());             
            //Console.WriteLine("Not3 girin: ");                      
            //not3 = Convert.ToInt16(Console.ReadLine());
            //aOrt = not1 + not2 + not3 / 3;

            //if (aOrt >= 50) 
            //{
            //    Console.WriteLine("Geçti");
            //}
            //else
            //{
            //    Console.WriteLine("Kaldı");
            //}
            //Console.ReadKey();


            //ÖRNEK11

            //int a, b;
            //Console.WriteLine("Birinci Sayıyı Giriniz : ");
            //a =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci Sayıyı Giriniz : ");
            //b =Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine(a + " Büyüktür " + b + " den ");
            //}
            //else if(a==b)
            //{
            //    Console.WriteLine(a + " Eşittir " + b);
            //}
            //else
            //{
            //    Console.WriteLine(b + " Büyüktür " + a + " den ");
            //}
            //Console.ReadKey();


            //ÖRNEK12

            //int sayi;
            //Console.WriteLine("Bir Sayı Giriniz :");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Tektir");
            //}
            //Console.ReadKey();


            //ÖRNEK13

            //int sayi;
            //Console.WriteLine("Bir Sayı Giriniz : ");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Pozitiftir(+)");
            //}
            //else if (sayi ==0)
            //{
            //    Console.WriteLine("Sıfır Doğal Sayıdır(Nötr)");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Negatiftir(-)");
            //}
            //Console.ReadKey();


            //ÖRNEK14

            //int sayi;
            //Console.WriteLine("Bir Sayı Giriniz : ");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi % 4 == 0 && sayi % 7 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz Sayı 4 Ve 7 Ye Tam Bölünür");
            //}
            //else 
            //{
            //    Console.WriteLine("Girdiğiniz Sayı tam bölünmez !!!");
            //}
            //Console.ReadKey();


            //ÖRNEK15

            //int sayi;
            //Console.WriteLine("Bir Sayı Giriniz : ");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi >= 0 && sayi <= 100)
            //{
            //    Console.WriteLine("Girdiğiniz Sayı 0-100 Arasında");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Sayı 0-100 Arasında DEĞİL!!! ");
            //}
            //Console.ReadKey();   

        }
    }

}

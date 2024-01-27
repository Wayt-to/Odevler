using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ödevler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Ödev yuvarlama

            //Ödev : Konsoldan bir sayı alınacak, alınan sayı duruma göre yukarı veya aşağı yuvarlayacaksınız.

            //while (true)
            //{

            //    ////Console.WriteLine("Bir sayı giriniz");
            //    ////double sayi = Convert.ToDouble(Console.ReadLine()); burası garip bir şekilde çalışıyor ??
            //
            //    ////int tamlik = Convert.ToInt32(sayi);
            //    ////Console.WriteLine("Sayınızın yuvarlanmış hali = " + tamlik);

            //    Console.WriteLine("Lütfen yuvarlanacak sayıyı giriniz : ");
            //    double sayi = Convert.ToDouble(Console.ReadLine());

            //    int tamlik = (int)sayi;
            //    double ondalikkisim = sayi - tamlik;


            //    if (ondalikkisim >= 0.5)
            //    {
            //        Console.WriteLine("Sayınızın yuvarlanmış hali = " + (tamlik + 1));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayınızın yuvarlanmış hali = " + tamlik);
            //    }
            //}


            #endregion

            #region Ödev 1
            //Kullanıcının kullanıcı adı ve şifresini girmesini isteyin. Eğer kullanıcı adı ve şifre doğruysa, "Giriş başarılı" mesajını gösterin; aksi halde "Hatalı giriş" uyarısı verin.

            //string kadi = "Wayt Bey";
            //string sifre = "12345";

            //Console.Write("\n\t|Kullanıcı Adı : ");
            //string kadiGiris = Console.ReadLine();
            //Console.WriteLine("\n   *-*-*-*-*-*-*-*-*-*-*-*-*-*");
            //Console.Write("\n\t|Şifre : "); 
            //string sifreGiris = Console.ReadLine();
            //Console.WriteLine("\n   *-*-*-*-*-*-*-*-*-*-*-*-*-*");

            //if (kadi == kadiGiris && sifre == sifreGiris)
            //{
            //    Console.WriteLine("\n\t<Giriş başarılı. Hoşgeldiniz.>");
            //}
            //else
            //{
            //    Console.WriteLine("\n  <Kullanıcı adı veya şifre hatalı.>\n");
            //}
            #endregion

            #region Ödev 2
            //Kullanıcıdan bir ay girmesini isteyin ve bu aya göre hangi mevsimde olduğunu gösterin.
            //Console.Write("\n  Lütfen hangi ayda olduğunuzu giriniz : ");
            //string ay = Console.ReadLine();
            //Console.WriteLine("\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            //if (ay == "aralık" || ay == "ocak" || ay == "şubat")
            //{
            //    Console.WriteLine("\n  Şu an Türkiye'de kış mevsimi . \n");
            //}
            //if (ay == "mart" || ay == "nisan" || ay == "mayıs")
            //{
            //    Console.WriteLine("\n  Şu an Türkiye'de ilbahar mevsimi . \n");

            //}
            //if (ay == "haziran" || ay == "temmuz" || ay == " ağustos")
            //{
            //    Console.WriteLine("\n  Şu an Türkiye'de yaz mevsimi. \n");

            //}
            //if (ay == "eylül" || ay == "ekim" || ay == "kasım")
            //{
            //    Console.WriteLine("\n  Şu an Türkiye'de kış mevsimi. \n");
            //}

            #endregion

            #region  ödev2 çözüm2

            ////eğer koşul bir aralık değeri değil bir sabit değer ise switch-case kullanılabilir

            //Console.WriteLine("ay giriniz : ");
            //string ay = Console.ReadLine();

            //switch (ay)
            //{
            //    case "aralık":
            //        Console.WriteLine("kış");
            //        break;
            //    case "ocak":
            //        Console.WriteLine("kış");
            //        break;
            //        //gibi gibi devam eder


            //}

            #endregion

            #region Ödev 3

            ////Kullanıcının Doğum Yılını isteyin yaşı 15 ten büyük ise merhaba değilse yaş değeri uygun değil yazdırın
            //int mevcutYil = DateTime.Now.Year;
            //Console.Write("Lütfen doğum yılınızı giriniz : ");
            //int kullaniciYili = Convert.ToInt32(Console.ReadLine());
            //int yas = mevcutYil - kullaniciYili;

            //if (yas >= 15)
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //else
            //{
            //    Console.WriteLine("Yaş değeri uygun değil. ");
            //}

            #endregion

            #region Ödev 4

            //Kullanıcıdan bir dil seçmesini isteyin (örneğin, "Türkçe" veya "İngilizce"). Ardından, seçilen dile göre Seçilen dilde bir hoş geldiniz mesajı görüntüleyin.

            //Console.Write("  Lütfen dilinizi belirtin \n (Please define your language) : ");
            //string dil = Console.ReadLine();
            //Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            //if (dil == "Türkçe")
            //{
            //    Console.WriteLine("\t  Hoşgeldiniz\n");
            //}
            //if (dil == "English")
            //{
            //    Console.WriteLine("\t  Welcome\n");
            //}
            //if (dil == "Deutsch")
            //{
            //    Console.WriteLine("\t  Wilkommen\n");
            //}
            //if (dil == "Espanol")
            //{
            //    Console.WriteLine("\t  Bienvenido\n");
            //}
            #endregion

            #region Ödev 5

            //Öğrencinin vize final notunu alınız. vize notunun %40'ı final Notunun %60'ı alınarak ortalama hesaplayın. Ortalama 50 üstü ise geçti değilse kaldı yazınız
            //while (true)
            //{ 
            //    Console.Write("\n   Vize puanınızı giriniz  : ");
            //    double vize = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("\n   Final puanınızı giriniz : ");
            //    double final = Convert.ToDouble(Console.ReadLine());

            //    double notvize = vize * 40 / 100;
            //    double notfinal = final * 60 / 100;

            //    double gecis = notfinal + notvize;
            //    Console.WriteLine("\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            //    if (gecis >= 50)
            //    {
            //        Console.WriteLine("        Öğrenci Geçti. \n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("        Öğrenci Kaldı. \n");
            //    }
            //}

            //BEEP MARİO
            //Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);

            #endregion

            #region Ödev 6

            //Konsoldan 6 adet sayı alın bu sayıların tek olanları ile çift olanlarının ortalamalarını ayrı ayrı konsola yazdırın.

            //Console.WriteLine("Lütfen 6 adet tamsayı giriniz : ");

            //int tektoplam = 0;
            //int cifttoplam = 0;
            //int ciftsayi = 0;
            //int teksayi = 0;

            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //int sayi1mod = sayi1 % 2;
            //if (sayi1mod == 0)
            //{
            //    cifttoplam += sayi1;
            //    ciftsayi += 1;
            //}
            //else
            //{
            //    tektoplam += sayi1;
            //    teksayi += 1;
            //}


            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi2mod = sayi2 % 2;
            //if (sayi2mod == 0)
            //{
            //    cifttoplam += sayi2;
            //    ciftsayi += 1;
            //}
            //else
            //{
            //    tektoplam += sayi2;
            //    teksayi += 1;
            //}

            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //int sayi3mod = sayi3 % 2;
            //if (sayi3mod == 0)
            //{
            //    cifttoplam += sayi3;
            //    ciftsayi += 1;
            //}
            //else
            //{
            //    tektoplam += sayi3;
            //    teksayi += 1;
            //}

            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //int sayi4mod = sayi4 % 2;
            //if (sayi4mod == 0)
            //{
            //    cifttoplam += sayi4;
            //    ciftsayi += 1;
            //}
            //else
            //{
            //    tektoplam += sayi4;
            //    teksayi += 1;
            //}

            //int sayi5 = Convert.ToInt32(Console.ReadLine());
            //int sayi5mod = sayi5 % 2;
            //if (sayi5mod == 0)
            //{
            //    cifttoplam += sayi5;
            //    ciftsayi += 1;
            //}
            //else
            //{
            //    tektoplam += sayi5;
            //    teksayi += 1;
            //}

            //int sayi6 = Convert.ToInt32(Console.ReadLine());
            //int sayi6mod = sayi6 % 2;
            //if (sayi6mod == 0)
            //{
            //    cifttoplam += sayi6;
            //    ciftsayi += 1;
            //}
            //else
            //{
            //    tektoplam += sayi6;
            //    teksayi += 1;
            //}

            //Console.Write("\nTek sayı ortalamanız = " + (tektoplam / teksayi) + "\n");
            //Console.Write("\nÇift sayı ortalamanız = " + (cifttoplam / ciftsayi) + "\n");

            #endregion

            #region Ödev 7

            //Konsoldan alınan karakter büyük mü, küçük mü?

            //while (true)
            //{
            //    Console.WriteLine("Lütfen bir karakter giriniz : ");
            //    char karakter = Convert.ToChar(Console.ReadLine());
            //    int sayisal = (int)karakter;

            //    if (sayisal <= 90 && sayisal >= 65)
            //    {
            //        Console.WriteLine("Girdiğiniz karakter büyüktür.");
            //    }
            //    if (sayisal <= 122 && sayisal >= 97)
            //    {
            //        Console.WriteLine("Girdiğiniz karakter küçüktür.");
            //    }

            //}


            #endregion

            #region Ödev 8

            // Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) seçildiğinde, sonucu hesaplayarak ekranda gösteren programı yazalım.

            //while (true)
            //{
            //    Console.Write("\n Lütfen ilk sayıyı giriniz : ");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("\n Lütfen ikinci sayıyı giriniz : ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("\n Lütfen yapılmasını istediğiniz işlem operatörünü giriniz (+,-,*,/) : ");
            //    string oper = Console.ReadLine();

            //    double toplam = sayi1 + sayi2;
            //    double fark = sayi1 - sayi2;
            //    double carpim = sayi1 * sayi2;
            //    double bolum = sayi1 / sayi2;

            //    if (oper == "+")
            //    {
            //        Console.Write("\n İki sayı toplamı = " + toplam + "\n");
            //    }
            //    if (oper == "-")
            //    {
            //        Console.Write("\n İki sayının farkı = " + fark + "\n");
            //    }
            //    if (oper == "*")
            //    {
            //        Console.Write("\n İki sayının çarpımı = " + carpim + "\n");
            //    }
            //    if (oper == "/")
            //    {
            //        Console.Write("\n İki sayının bölümü = " + bolum + "\n");
            //    }
            //}

            ////Console.Write("\n Lütfen ilk sayıyı giriniz : ");
            ////double sayi1 = Convert.ToDouble(Console.ReadLine());
            ////Console.Write("\n Lütfen ikinci sayıyı giriniz : ");
            ////double sayi2 = Convert.ToDouble(Console.ReadLine());
            ////Console.Write("\n Lütfen yapılmasını istediğiniz işlem operatörünü giriniz (+,-,*,/) : ");
            ////string oper = Console.ReadLine();






            #endregion

            #region Kullanıcıdan alınan değerden 100 e kadar sayıların çift olanlarını yaz

            //Console.Write("Lütfen 0 ile 100 arasında bir tamsayı giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while (sayi <= 100)
            //{
            //    int mod = sayi % 2;
            //    if (mod == 0)
            //    {
            //        Console.WriteLine(sayi);
            //        sayi++;
            //    }
            //    sayi++;


            //}

            #endregion

            #region Canlı Hava Durumu

            ////Eskişehir İstanbul Ankara arası seçim ile canlı havadurumu



            //string apikey = "e4b7070abab1899610fd58316c8d4c53";

            //Console.Write("1)Eskişehir\n2)İstanbul\n3)İzmir\n4)Trabzon\nHangi Şehirin Hava Durumunu Öğrenmek İstersiniz ? : ");

            //string giris = Console.ReadLine();

            //if (giris == "1")
            //{
            //    string linkesk = "https://api.openweathermap.org/data/2.5/weather?q=Eskişehir&lang=tr&units=metric&mode=xml&appid=" + apikey;
            //    XDocument havadurumu = XDocument.Load(linkesk);
            //    string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //    string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            //    string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            //    string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;

            //    Console.WriteLine("| Eskişehir için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);

            //}
            //if (giris == "2")
            //{
            //    string linkist = "https://api.openweathermap.org/data/2.5/weather?q=İstanbul&lang=tr&units=metric&mode=xml&appid=" + apikey;
            //    XDocument havadurumu = XDocument.Load(linkist);
            //    string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //    string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            //    string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            //    string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;
            //    Console.WriteLine("| İstanbul için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);
            //}
            //if (giris == "3")
            //{
            //    string linkizmir = "https://api.openweathermap.org/data/2.5/weather?q=İzmir&lang=tr&units=metric&mode=xml&appid=" + apikey;
            //    XDocument havadurumu = XDocument.Load(linkizmir);
            //    string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //    string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            //    string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            //    string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;
            //    Console.WriteLine("| İzmir için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);

            //}
            //if (giris == "4")
            //{
            //    string linktrb = "https://api.openweathermap.org/data/2.5/weather?q=Trabzon&lang=tr&units=metric&mode=xml&appid=" + apikey;
            //    XDocument havadurumu = XDocument.Load(linktrb);
            //    string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //    string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            //    string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            //    string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;
            //    Console.WriteLine("| Trabzon için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);

            //}

            #endregion

            #region fibonacci serisini yazdır.

            //0 1 1 2 3 5 8 13 21

            //int sayi1 = 0;
            //int sayi2 = 1;
            //int sayi3 = 0;
            //int sayac = 0;
            //Console.Write("Kaç aşamalı Fibonacci serisi istiyorsunuz ? : ");
            //int asama = Convert.ToInt32(Console.ReadLine());

            //Console.Write( sayi1 + " " + sayi2+" ");
            //while (sayac <= asama)
            //{
            //    sayi3 = sayi1 + sayi2;

            //    Console.Write(sayi3 + " ");

            //    sayi1 = sayi2;
            //    sayi2 = sayi3;
            //    sayac++;
            //}

            #endregion

            #region Konsoldan alınan 10 sayının ortalaması


            //int sc = 1;
            //double toplam = 0;

            //while (sc <= 10)
            //{

            //    Console.WriteLine("Lütfen "+ sc+". sayı giriniz : ");

            //    double sayi = Convert.ToDouble(Console.ReadLine());
            //    toplam += sayi;
            //    sc++;

            //}
            //Console.Write("10 sayının ortalaması : " + (toplam/10)+ "\n\n");
            #endregion

            #region Konsoldan alınan 10 sayının tek olanlarının ayrı, çift olanlarının ayrı ortalamasını alınız


            //int sc = 1;
            //double ciftToplam = 0;
            //double tekToplam = 0;
            //int ciftAdet = 0;
            //int tekAdet = 0;

            //while (sc <= 10)
            //{

            //    Console.Write("Lütfen " + sc + ". sayı giriniz : ");

            //    double sayi = Convert.ToDouble(Console.ReadLine());
            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //        ciftAdet++;
            //    }
            //    else
            //    {
            //        tekAdet++;
            //        tekToplam += sayi;
            //    }
            //    sc++;

            //}
            //Console.WriteLine($"TEK SAYILARIN ORTALAMASI : { tekToplam / tekAdet}\n *-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n " );
            //Console.WriteLine("ÇİFT SAYILARIN ORTALAMASI : " + ciftToplam / ciftAdet);


            #endregion

            #region     While Uygulamalarının For Adaptasyonları




            #endregion

            #region Konsol tahmin oyunu

            //1. oyuncu tarafından Konsoldan alınan sayı var konsol temizlenecek, 2. oyuncu bilgisayarın başına oturacak lütfen tahmin giriniz çıkacak tahmin girilecek tahmini küçük kalmışsa lütfen daha büyük bir sayıyla deneyin diyecek, büyükse lütfen daha küçük bir sayı giriniz diyecek.10 denemede bulabilirse tebrikler kazandınız bulamazsa üzgünüz kaybettiniz + girilen sayı= sayi denilecek
            //Console.Clear

            //Console.Write("1.Oyuncu 2.Oyuncuya Göstermeden Sayınızı Giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Hoşgeldiniz 1. Oyuncu Bir Sayı Belirledi. 10 Hakkınız Var. İyi Şanslar...\n");
            //bool kazanma = false;
            //for (int i = 1; i <= 10;i++)
            //{

            //    Console.Write($"{i}. Hakkınız, lütfen tahmininizi giriniz :");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == sayi)
            //    {
            //        Console.WriteLine("Tebrikler Kazandınız :)");
            //        kazanma = true;
            //        break;
            //    }
            //    else 
            //    {
            //         int fark = sayi - tahmin;
            //         if (fark < 0)
            //         {
            //             Console.WriteLine("Bilemediniz,  daha küçük bir sayı girmelisiniz.");
            //         }
            //         else if (fark > 0)
            //         {
            //             Console.WriteLine("Bilemediniz,  daha büyük bir sayı girmelisiniz");
            //         }

            //    }

            //}
            //if (!kazanma)
            //{
            //    Console.WriteLine($"Üzgünüz Bulamadınız. Sayı {sayi} olmalıydı.");
            //}

            //Tek oyunculu versiyon

            //Random rnd = new Random();
            //int sayi = rnd.Next(10, 100);
            //bool kazanma = false;


            //Console.WriteLine("Oyuna Hoşgeldiniz");
            //Console.WriteLine("lütfen Zorluk Seviyesi Seçiniz");
            //Console.WriteLine("1)Kolar(20 Hak)");
            //Console.WriteLine("2)Orta(10 Hak)");
            //Console.WriteLine("3)Zor(5 Hak)");

            //string zorlukSecim = Console.ReadLine();
            //int hak = 0;
            //switch (zorlukSecim)
            //{
            //    case "1": hak = 20;break;
            //    case "2": hak = 10;break;
            //    case "3": hak = 5;break;
            //}
            //for (int i = 0; i < hak; i++)
            //{
            //    Console.WriteLine("Lütfen Tahmin Giriniz : ");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == sayi)
            //    {
            //        Console.WriteLine("Tebrikler Kazadınız");
            //        kazanma = true;
            //        break;
            //    }
            //    else if (tahmin <sayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen daha küçük bir sayı giriniz");

            //    }

            //}
            //if (kazanma ==false)
            //{
            //    Console.WriteLine("maalesef kazanamadınız");
            //}


            #endregion

            #region Konsol tahmin oyunu 2

            // ilk oyunun aynısı haklara göre zorluk kolay (20 hak) orta (10 hak) zor (5 hak) eklenecek

            //Console.Write("1.Oyuncu 2.Oyuncuya Göstermeden Sayınızı Giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.Write("Hoşgeldiniz 1. Oyuncu Bir Sayı Belirledi. Lütfen İstediğiniz Zorluk Seviyesini Belirleyin :\n 1)Kolay (20 Tahmin Hakkı)\n 2)Orta (10 Tahmin Hakkı)\n 3)Zor (5 Tahmin Hakkı)\n ");
            //string zorluk = Console.ReadLine();
            //Console.WriteLine(" İyi Şanslar\n");
            //if (zorluk == "1")
            //{
            //    bool kazanma = false;
            //    for (int i = 1; i <= 10; i++)
            //    {

            //        Console.Write($"{i}. Hakkınız, lütfen tahmininizi giriniz :");
            //        int tahmin = Convert.ToInt32(Console.ReadLine());

            //        if (tahmin == sayi)
            //        {
            //            Console.WriteLine("Tebrikler Kazandınız :)");
            //            kazanma = true;
            //            break;
            //        }
            //        else
            //        {
            //            int fark = sayi - tahmin;
            //            if (fark < 0)
            //            {
            //                Console.WriteLine("Bilemediniz,  daha küçük bir sayı girmelisiniz.");
            //            }
            //            else if (fark > 0)
            //            {
            //                Console.WriteLine("Bilemediniz,  daha büyük bir sayı girmelisiniz");
            //            }

            //        }

            //    }
            //    if (!kazanma)
            //    {
            //        Console.WriteLine($"Üzgünüz Bulamadınız. Sayı {sayi} olmalıydı.");
            //    }
            //}
            //if (zorluk == "2")
            //{
            //    bool kazanma = false;
            //    for (int i = 1; i <= 10; i++)
            //    {

            //        Console.Write($"{i}. Hakkınız, lütfen tahmininizi giriniz :");
            //        int tahmin = Convert.ToInt32(Console.ReadLine());

            //        if (tahmin == sayi)
            //        {
            //            Console.WriteLine("Tebrikler Kazandınız :)");
            //            kazanma = true;
            //            break;
            //        }
            //        else
            //        {
            //            int fark = sayi - tahmin;
            //            if (fark < 0)
            //            {
            //                Console.WriteLine("Bilemediniz,  daha küçük bir sayı girmelisiniz.");
            //            }
            //            else if (fark > 0)
            //            {
            //                Console.WriteLine("Bilemediniz,  daha büyük bir sayı girmelisiniz");
            //            }

            //        }

            //    }
            //    if (!kazanma)
            //    {
            //        Console.WriteLine($"Üzgünüz Bulamadınız. Sayı {sayi} olmalıydı.");
            //    }
            //}
            //if (zorluk == "3")
            //{
            //    bool kazanma = false;
            //    for (int i = 1; i <= 5; i++)
            //    {

            //        Console.Write($"{i}. Hakkınız, lütfen tahmininizi giriniz :");
            //        int tahmin = Convert.ToInt32(Console.ReadLine());

            //        if (tahmin == sayi)
            //        {
            //            Console.WriteLine("Tebrikler Kazandınız :)");
            //            kazanma = true;
            //            break;
            //        }
            //        else
            //        {
            //            int fark = sayi - tahmin;
            //            if (fark < 0)
            //            {
            //                Console.WriteLine("Bilemediniz,  daha küçük bir sayı girmelisiniz.");
            //            }
            //            else if (fark > 0)
            //            {
            //                Console.WriteLine("Bilemediniz,  daha büyük bir sayı girmelisiniz");
            //            }

            //        }

            //    }
            //    if (!kazanma)
            //    {
            //        Console.WriteLine($"Üzgünüz Bulamadınız. Sayı {sayi} olmalıydı.");
            //    }
            //}
            #endregion

            #region Ödev Dizi içerisindeki çift sayıları yazdırınız

            //int[] sayilar = { 5, 20, -90, 908, 23, -9876, 43, 1, 23, 43, 2 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]%2==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            #endregion

            #region Ödev Dizi İçerisindeki sayıların ortalamasını hesaplayınız

            //int[] sayilar = { 5, 20, 25, 97, 12, 100, 63, 1, 23, 43, 2 };
            //int toplam=0;
            //int adet=0;
            //foreach (int eleman in sayilar)
            //{
            //    toplam += eleman;
            //    adet++;
            //}
            //Console.WriteLine("Dizideki Sayıların Ortalaması = "+(toplam/adet));
            #endregion

            #region Ödev Dizi İçerisindeki Çift Sayıların Ortalamasını Hesaplayınız

            //int[] sayilar = { 5, 20, 25, 97, 12, 100, 63, 1, 23, 43, 2 };
            //int ctoplam = 0;
            //int cadet = 0;
            //foreach (int eleman in sayilar)
            //{
            //    if (eleman %2 == 0)
            //    {
            //        ctoplam += eleman;
            //        cadet++;
            //    }
            //}
            //Console.WriteLine("Dizideki Sayıların Ortalaması = " + (ctoplam / cadet));

            #endregion

            #region Ödev Dizideki Çift Sayıların ortalamasının genel ortalmaya yüzdesini hesaplayınız

            //int[] sayilar = { 5, 20, 25, 97, 12, 100, 63, 1, 23, 43, 2 };
            //int ctoplam = 0;
            //int cadet = 0;
            //int adet = 0;
            //int toplam = 0;
            //foreach (int eleman in sayilar)
            //{
            //    toplam += eleman;
            //    adet++;
            //    if (eleman % 2 == 0)
            //    {
            //        ctoplam += eleman;
            //        cadet++;
            //    }
            //}
            //Console.WriteLine("Dizideki Sayıların Ortalaması = " + (toplam / adet));
            //Console.WriteLine("Dizideki Çift Sayıların Ortalaması = " + (ctoplam / cadet));
            //Console.WriteLine("Çift Ortalamanın Genel Ortalamaya Yüzdesi = %" + ((ctoplam / cadet) * 100) / (toplam / adet));

            #endregion

            #region Kart Sormalı Adetli KDV'li Ürün Sepet Uygulaması

            //string[] ogrenciler = { "serap", "hüseyin", "nasuh", "oğuz", "emre", "kaan", "nur", "vahit", "armağan", "yasin", "enes" };
            //string[] kartlar = { "3124958212", "1380819549", "1219969301", "3259801860", "1658178308", "1117254916", "0143086088", "0575011844", "1116070404", "1645263364", "0707663364" };
            //string[] urunler = { "domates", "biber", "patlıcan", "yumurta", "ekmek", "doritos", "kola" };
            //double[] fiyat = { 28.90, 33.40, 24.10, 3.10, 7, 40, 45 };
            //double[] kdv = { (fiyat[0]*1/100), (fiyat[1] * 1 / 100), (fiyat[2] * 1 / 100),(fiyat[3] * 1 / 100), (fiyat[4] * 1 / 100), (fiyat[5] * 1 / 100), (fiyat[6] * 8 / 100) };

            //string secenek = "e";
            //double toplam = 0;
            //double kdvtop = 0;
            //Console.WriteLine("WahitShop'a hoşgeldiniz. \n");
            //Console.WriteLine("WahitKart Sahibi Misiniz? (e/h)");
            //string kartvarmi = Console.ReadLine();
            //Console.Clear();
            //if (kartvarmi =="e")
            //{
            //    Console.WriteLine("Sepette %5 indirim kazanmak için kartınızı okutunuz : ");
            //    string musteriKart = Console.ReadLine();
            //    for (int i = 0; i < kartlar.Length; i++)
            //    {
            //        if (musteriKart == kartlar[i])
            //        {
            //            Console.WriteLine("Hoşgeldin " + ogrenciler[i]+". İyi alışverişler...");
            //            
            //            break;
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sistemde kayıtlı bir karta sahip değilseniz indirimden faydalanamazsınız, iyi alışverişler.");
            //}

            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine($"{(i + 1)} ){urunler[i]} \t {fiyat[i]} TL");
            //}

            //while (secenek =="e")
            //{
            //    Console.Write("Lütfen almak istediğiniz ürünün numarasını giriniz :");
            //    int urunno = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Kaç tane alacaksınız ? :");
            //    int adet = Convert.ToInt32(Console.ReadLine());
            //    toplam += fiyat[urunno - 1];
            //    kdvtop += kdv[urunno - 1];
            //    Console.WriteLine("Alısverişe Devam Etmek İstiyor Musunuz ? (e/h)");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Ara toplam ="+(toplam-kdvtop)+" TL");
            //Console.WriteLine("KDV = "+kdvtop+" TL");
            //Console.WriteLine("Toplam = "+(toplam+kdvtop + " TL"));

            #endregion

            #region Ürün alımı isimli sorgu

            //string secim = "e";
            //string[] urunler = { "domates", "biber", "patlıcan", "yumurta", "ekmek", "doritos", "kola" };
            //double[] fiyat = { 28.90, 33.40, 24.10, 3.10, 7, 40, 45 };
            //double[] kdv = { (fiyat[0] * 1 / 100), (fiyat[1] * 1 / 100), (fiyat[2] * 1 / 100), (fiyat[3] * 1 / 100), (fiyat[4] * 1 / 100), (fiyat[5] * 1 / 100), (fiyat[6] * 8 / 100) };
            //double toplam = 0;
            //double kdvtop = 0;

            //Console.WriteLine("WahitShop'a Hoşgeldinizzz...");

            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine($"{(i + 1)} ){urunler[i]} \t {fiyat[i]} TL");
            //}

            //while (secim =="e")
            //{
            //    Console.WriteLine("Ne Almak İstersiniz ? ");
            //    string musterisecim = Console.ReadLine();
            //    for (int i = 0; i < urunler.Length; i++)
            //    {
            //        if (musterisecim == urunler[i])
            //        {
            //            toplam += fiyat[i];
            //            kdvtop += kdv[i];
            //        }
            //    }
            //    Console.WriteLine("Alışverişe devam etmek istiyor musunuz ?");
            //    secim = Console.ReadLine();

            //}
            //Console.WriteLine("Ara toplam = "+(toplam-kdvtop)+" TL");
            //Console.WriteLine("KDV Toplamı = "+ kdvtop + " TL");
            //Console.WriteLine("Toplam = "+toplam+" TL");

            #endregion

            #region İsimli-Birimli satın alım uygulaması

            //string secim = "e";
            //string[] urunler = { "domates", "biber", "patlıcan", "yumurta", "ekmek", "doritos", "kola" };
            //string[] birim = { "kg", "kg", "kg", "adet", "adet", "paket", "şişe" };
            //double[] fiyat = { 28.90, 33.40, 24.10, 3.10, 7, 40, 45 };
            //double[] kdv = { (fiyat[0] * 1 / 100), (fiyat[1] * 1 / 100), (fiyat[2] * 1 / 100), (fiyat[3] * 1 / 100), (fiyat[4] * 1 / 100), (fiyat[5] * 1 / 100), (fiyat[6] * 8 / 100) };
            //double toplam = 0;
            //double kdvtop = 0;

            //Console.WriteLine("WahitShop'a Hoşgeldinizzz...");

            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine($"{(i + 1)} ){urunler[i]} \t {fiyat[i]} TL");
            //}

            //while (secim == "e")
            //{
            //    Console.WriteLine("Ne Almak İstersiniz ? ");
            //    string musterisecim = Console.ReadLine();
            //    for (int i = 0; i < urunler.Length; i++)
            //    {
            //        if (musterisecim == urunler[i])
            //        {
            //            Console.WriteLine($"Kaç {birim[i]} Almak İstersiniz ?");
            //            int adet = Convert.ToInt32(Console.ReadLine());
            //            toplam += adet*fiyat[i];
            //            kdvtop += adet*kdv[i];
            //        }
            //    }
            //    Console.WriteLine("Alışverişe devam etmek istiyor musunuz ?");
            //    secim = Console.ReadLine();

            //}
            //Console.WriteLine("Ara toplam = " + (toplam - kdvtop) + " TL");
            //Console.WriteLine("KDV Toplamı = " + kdvtop + " TL");
            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region Market Uygulamasında Alınan Her Şeyi Listeye Doldur

            string secim = "e";
            string[] urunler = { "domates", "biber", "patlıcan", "yumurta", "ekmek", "doritos", "kola" };
            string[] birim = { "kg", "kg", "kg", "adet", "adet", "paket", "şişe" };
            double[] fiyat = { 28.90, 33.40, 24.10, 3.10, 7, 40, 45 };
            double[] kdv = { (fiyat[0] * 1 / 100), (fiyat[1] * 1 / 100), (fiyat[2] * 1 / 100), (fiyat[3] * 1 / 100), (fiyat[4] * 1 / 100), (fiyat[5] * 1 / 100), (fiyat[6] * 8 / 100) };
            double toplam = 0;
            double kdvtop = 0;
            string sepet = "";
            Console.WriteLine("WahitShop'a Hoşgeldinizzz...");

            #region satın aldırma
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{(i + 1)} ){urunler[i]} \t {fiyat[i]} TL");
            }

            while (secim == "e")
            {
                Console.WriteLine("Ne Almak İstersiniz ? ");
                string musterisecim = Console.ReadLine();
                for (int i = 0; i < urunler.Length; i++)
                {
                    if (musterisecim == urunler[i])
                    {
                        Console.WriteLine($"Kaç {birim[i]} Almak İstersiniz ?");
                        int adet = Convert.ToInt32(Console.ReadLine());
                        toplam += adet * fiyat[i];
                        kdvtop += adet * kdv[i];
                        sepet += urunler[i] + " " + adet + birim[i] +  "\n";
                    }
                }
                Console.WriteLine("Alışverişe devam etmek istiyor musunuz ?");
                secim = Console.ReadLine();

            }

            #region fis
            Console.WriteLine("Alışveriş Sepetiniz :\n" + sepet);
            Console.WriteLine("Ara toplam = " + (toplam - kdvtop) + " TL");
            Console.WriteLine("KDV Toplamı = " + kdvtop + " TL");
            Console.WriteLine("Toplam = " + toplam + " TL");
            #endregion

            #endregion

            #endregion

            #region Konsoldan alınan sayı asal mı ?

            //Console.WriteLine("Sayınızı giriniz :");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool asalcheck = true;
            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi % i ==0)
            //    {
            //        asalcheck = false;
            //    }

            //}
            //if (asalcheck == true)
            //{
            //    Console.WriteLine("sayi asal");
            //}
            //else
            //{
            //    Console.WriteLine("sayi asal deil");
            //}
            #endregion

            #region Konsoldan alınan kelime polindrom mudur
            //while (true)
            //{
            //    bool pol = false;

            //    Console.WriteLine("Lütfen kelimeyi yazınız : ");
            //    string word = Console.ReadLine(); //kabak k a b a k
            //    0 1 2 3 4
            //    char[] charWord = word.ToCharArray();
            //    for (int i = 0; i < charWord.Length; i++)
            //    {
            //        for (int z = ((charWord.Length - 1)); z >= 0; z--)
            //        {
            //            if (charWord[i] == charWord[z])
            //            {
            //                pol = true;
            //            }
            //            else
            //            {
            //                pol = false;
            //            }
            //        }
            //    }
            //    if (pol == true)
            //    {
            //        Console.WriteLine("Kelimeniz polindrom kelimedir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kelimeniz polindrom kelime değildir.");
            //    }

            //}

            #endregion

            #region İkiz asallar(aralarında asal olmayan 1 sayı barındıran asallar) 11-13
            //123 (4) 5 (6) 789 (10) 11 (12) 1314151617 (18) 1920


            #endregion

            #region İçi boş tam baklava BİTMEDİ !!!

            //   *
            //  * *
            // *   *
            //*     *
            // *   *
            //  * *
            //   *




            #endregion
        }
    }

}

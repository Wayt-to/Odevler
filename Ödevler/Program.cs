using System;
using System.Collections.Generic;
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


        }
    }
}

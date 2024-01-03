using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security;
using System.Transactions;

namespace GaziKararYapılarıApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try-catch kullanımı
            //try
            //{
            //    Console.WriteLine("sayıyı giriniz");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("rakamla giriniz");

            //}












            //Console.WriteLine("hava nasıl");
            //string cevap = Console.ReadLine().ToLower().Trim();
            //if (cevap == "güzel" || cevap == "iyi")
            //{
            //    Console.WriteLine("kaç derece?");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece <= 15)
            //    {
            //        Console.WriteLine("soğuk evde otur");
            //    }
            //    //exception handling -try-catch



            //}
            //else if (cevap == "kötü" || cevap == "kapalı")
            //    {
            //        Console.WriteLine("dışarı çıkma");
            //    }

            //    else
            //    {
            //        Console.WriteLine("hatalı işlem yaptınız");
            //    }





            //Console.WriteLine("enter the firt number");
            //double s1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the second number");
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("please select transaction:+,-,/,*");
            //Console.WriteLine("dil seçiniz/select language(TR/EN)");
            //String ceavp = Console.ReadLine();
            //string msg1, msg2, msg3, msg4;
            //if( ceavp =="TR")
            //{
            //    msg1 = "1. sayıyı girinş-iz:";
            //    msg2 = "2. sayıyı giriniz:";
            //    msg3 = "işlem seçiniz:";
            //    msg4 = "işlemin sonucu:";
            //}
            //else
            //{
            //    msg1 = "enter yhe first number:";
            //    msg2 = "enter the second number:";
            //    msg3 = "select operation:";
            //    msg4 = "result:";

            //}

            //Console.WriteLine("1.sayıyı giriniz");
            //  double s1 =double. Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz");
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("işlem seçiniz:+,-,/,*");
            //char islem = char.Parse(Console.ReadLine());
            //string msg = "işlemin sonucu:";
            //if (islem == '+')
            //{
            //    Console.WriteLine($"{msg}{s1 + s2}");
            //}

            //else if (islem == '-')
            //{
            //    Console.WriteLine($"{msg}{s1 - s2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{msg}{s1 * s2}");
            //}

            //else if (islem=='/')
            //{
            //    Console.WriteLine($"{msg}{s1 / s2}");
            //}




            //if (s1 > s2)
            //{
            //    Console.WriteLine("sayı1 büyüktür");
            //}
            //else

            //{
            //    Console.WriteLine("sayı2 büyüktür");
            //}

            //try
            //{
            //    checked
            //    {
            //        Random rnd = new Random();
            //        byte sayi = (byte)rnd.Next(5, 500);
            //        Console.WriteLine(sayi);

            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("rakamla giriniz");
            //    Console.ReadKey();
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arasında bir sayı giriniz");
            //    Console.ReadKey();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("beklenmedik bir hata oluştu");


            //    }
            //Console.WriteLine("bir sayı giriniz");
            //byte sayi = Byte.Parse(Console.ReadLine());
            //if (sayi == 1)
            //{
            //    Console.WriteLine("Bir");
            //}
            //else if (sayi == 2)
            //{
            //    Console.WriteLine("iki");
            //}
            //else if (sayi == 3)
            //{
            //    Console.WriteLine("üç");
            //}

            //switch (sayi)
            //{
            //    case 1:
            //        Console.WriteLine("Bir");
            //        break;
            //    case 2:
            //        Console.WriteLine("iki");
            //        break;
            //    case 3:
            //        Console.WriteLine("üç");
            //        break;
            //    default:
            //        break;
            //}
            //Console.ReadKey();


            //value types
            //Console.WriteLine("Berat");
            //int number1 = 200001142;
            //long number2 = 95665515153515355;
            //short number3 = 32767;
            //byte number4 = 255;
            //bool condition=false-true;
            //char character = 'a';
            //double number5 = 10.5;

            //Console.WriteLine(character);
            //Console.WriteLine("number1 is {0}",number1);
            //Console.WriteLine("number2 is {0}",number2);
            //Console.WriteLine("number3 is {0}", number3);
            //Console.WriteLine("number4 is {0}", number4);
            //Console.WriteLine("number5 is {0}", number5);

            //Console.ReadLine();



            //TRY - CATCH KULLANIMI
            //    Console.WriteLine("lütfen sınav notunu giriniz");
            //try
            //{
            //    checked
            //    {
            //        int not = Convert.ToInt32(Console.ReadLine());
            //        if (not >= 0 && not <= 50)
            //        {
            //            Console.WriteLine("daha çok çalışmalısın");
            //        }
            //        else if (not >= 51 && not <= 69)
            //        {
            //            Console.WriteLine("daha iyi olabilir");
            //        }
            //        else if (not >= 70 && not <= 100)
            //        {
            //            Console.WriteLine("başarılı");
            //        }
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("lütfen rakamla giriniz");
            //}
            //catch (OverflowException) 
            //{
            //    Console.WriteLine("LÜTFEN GEÇERLİ BİR SAYI GİRİNİZ");
            //}
            //catch(Exception ) 
            //{
            //    Console.WriteLine("İŞLEMİNİZ GERÇEKLEŞTİRİLEMEDİ.");
            //}






            //checked: veriyi korumak için kullanılır 

            //STRİNG VERİ TİPİ=> metinleri tutmak için kullanılan veri tipidir
            //string isim = "berat";
            //string soyisim = "özdas";
            //string kı = "hoşgeldiniz";

            //Console.WriteLine(isim);
            //Console.WriteLine(soyisim);
            //Console.WriteLine(kı);
            //Console.ReadLine();

            //BOOL VERİ TİPİ=> iki ihtimalin olduğu veri tiplerinde kullanılır
            //örn=>doğru/yanlış
            //bool kontrol = false;
            //bool kontrol2 = true;

            //bool sonuc = 5 > 10;
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            //CONST KULLANIMI=>bir değişkenin değerinin program boyunca sabit kalması için kullanılır
            //ÖRN=> pi sayısı



            //ÖRNEKLER===>
            //int sayi1, sayi2, toplam;
            //Console.WriteLine("1.sayıyı giriniz:");
            //sayi1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //toplam=sayi1+sayi2;
            //Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
            //Console.ReadKey();

            //double yazili1, yazili2, yazili3, ortalama;
            //Console.Write("1. Yazılı : ");
            //yazili1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Yazılı : ");

            //yazili2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("3. Yazılı : ");
            //yazili3 = Convert.ToDouble(Console.ReadLine());

            //ortalama = (yazili1 + yazili2 + yazili3) / 3;
            //Console.WriteLine("ortalamanız" + ortalama);
            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("geçtiniz");
            //}
            //else
            //{
            //    Console.WriteLine("kaldınız");
            //}



            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi < 0)
            //{
            //    Console.WriteLine("sayı negatif");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("sayı sıfırdır");
            //}
            //else
            //{
            //    Console.WriteLine("sayı pozitiftir");
            //}



            //int sayi;
            //Console.Write("sayıyı giriniz:");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi>0 && sayi<100 ) 
            //{
            //    Console.WriteLine("sayı 100 ile 0 arasındadır");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı sayı girdiniz");
            //}



            //double alis, satis, karoran;
            //Console.WriteLine("sayıyı giriniz:");
            //alis=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("kâr oranını giriniz:");
            //karoran =Convert.ToDouble(Console.ReadLine());
            //satis = alis + (alis * karoran / 100);
            //Console.WriteLine("satış fiyati:{0}", satis);
            //Console.ReadKey();

            //int sayı;
            //sayı=Convert.ToInt32(Console.ReadLine());
            //bool durum = sayı == 3;







            //TÜR DÖNÜŞÜMLERİ

            //int veri tipini byte veri tipine dönüştürme=>
            // int a = 5;
            // byte b = (byte)a;


            // Console.WriteLine(b);
            //Console.ReadLine();


            //string veri tipini int veri tipine dönüştürme

            //string sayı1 = "1";
            //string sayı2 = "2";
            //int a = int.Parse(sayı1);
            //int b=int.Parse(sayı2 );


            //Console.WriteLine(a+b);
            //Console.ReadLine();

            //2.yol===>
            //int a = Convert.ToInt32(sayı1);
            //int b = Convert.ToInt32(sayı2);
            //Console.WriteLine(a+b);
            //Console.ReadLine();

            //int veri tipinden string veri tipine dönüştürme

            //int sayı1 = 10;
            //int sayı2 = 5;
            //string a=sayı1.ToString();
            //string b=sayı2.ToString();
            //Console.WriteLine(a+b);
            //Console.ReadLine();

            //double veri tipinden int veri tipine nasıl dönüştürülür==>

            //double sayi = 5.22;
            //int a = Convert.ToInt32(sayi);       //int veri tipi tamsayıları tutar noktadan sonrasını atar
            //Console.WriteLine(a);               //double veri tipi ondalık sayıları tutar.
            //Console.ReadLine();                



            //KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR.
            //Console.WriteLine("LÜTFEN YAŞINIZI GİRİNİZ");
            //string kullanıcı_yas=Console.ReadLine();

            //int kullanıcı_yasInt = int.Parse(kullanıcı_yas);
            //int kulllanıcı_yas = Convert.ToInt32(kullanıcı_yas);
            //Console.WriteLine(kullanıcı_yasInt);
            //Console.WriteLine(kullanıcı_yas);
            //Console.ReadLine() ;

            //kulaanıcıdan iki tane sayı alan ve ikisinin toplamını ekrana yazdırsn programı yazınız.
            //Console.WriteLine("birinci sayıyı giriniz");
            //string sayi1=Console.ReadLine();
            //int aInt=int.Parse(sayi1);
            //Console.WriteLine("ikinci sayıyı giriniz");
            //string sayi2 = Console.ReadLine();
            //int bInt = int.Parse(sayi2);   



            //Console.WriteLine("iki sayının toplamı :" +(aInt+bInt));
            //Console.ReadLine();


            //Console.WriteLine("birinci sayıyı giriniz");
            //double s1=double.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz");
            //double s2=double.Parse(Console.ReadLine());
            //Console.WriteLine("islem seçiniz /,+,-,*");
            //char islem=char.Parse(Console.ReadLine());
            //Console.WriteLine("işlemin sonucu");



            //if (islem == '+')
            //{
            //    Console.WriteLine(s1 + s2);
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine(s1 - s2);
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine(s1 * s2);
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine(s1 / s2);
            //}

            //else
            //{
            //    Console.WriteLine("hatalı işlem yaptınız");
            //}


            //int sayi1, sayi2;
            //Console.Write("1.sayı:");
            // sayi1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayı:");
            //sayi2= Convert.ToInt32(Console.ReadLine()); 

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("1.sayı büyüktür");
            //}
            //else if (sayi1 < sayi2)
            //{
            //    Console.WriteLine("2. sayı bütüktür");
            //}
            //else
            //{
            //    Console.WriteLine("sayılar eşittir");
            //}

            //try-catch yaplanması-HATA PARAMETRELERİ
            //çalışma zamanında alınan hataya dair bizlere bilgi veren/taşıyan parametrelerdir.

            //SWİTCH-CASE ÖRNEKLERİ==>


            //ATM UYGULAMASI
            //int bakiye = 10000;
            //Console.WriteLine("ATM'ye HOŞGELDİNİZ.");
            //Console.WriteLine("lütfen bir islem seçiniz.");
            //Console.WriteLine("1 - bakiye görüntüle");
            //Console.WriteLine("2 - para çek");
            //Console.WriteLine("3 - para yatır");
            //Console.WriteLine("4 - çıkış yap");

            //string secim = Console.ReadLine();
            //switch (secim)
            //{
            //    case "1":
            //        Console.WriteLine("bakiyeniz:" + bakiye);
            //        Console.ReadLine();
            //        break;
            //    case "2":
            //        Console.WriteLine("çekmek istediğiniz tutarı giriniz:");
            //        int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
            //        if (cekilecek_tutar > bakiye)
            //        {
            //            Console.WriteLine("yetersiz bakiye");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("kalan bakiyeniz:" + (bakiye - cekilecek_tutar)); Console.ReadLine();
            //        }
            //        break;
            //    case "3":
            //        Console.WriteLine("yatırmak istediğiniz tutarı giriniz:");
            //        int yatırılacak_tutar = Convert.ToInt32((Console.ReadLine()));
            //        Console.WriteLine("yeni bakiyeniz:" + (bakiye + yatırılacak_tutar)); Console.ReadLine();
            //        break;
            //    case "4":
            //        Console.WriteLine("hesabınızdan çıkış yapılıyor iyi günler");
            //        Console.ReadLine();
            //        break;
            //    default:
            //        Console.WriteLine("LÜTFEN GEÇERLİ BİR İŞLEM GİRİNİZ");
            //        break;


                    //GÜVENLİK KİlİDİ YAPIMI

                    //Console.WriteLine("isminizi giriniz:");
                    //string isim = Convert.ToString(Console.ReadLine());
                    //Console.WriteLine("soyisminizi giriniz:");
                    //string soyisim = Convert.ToString(Console.ReadLine());
                    //Console.WriteLine("güvenlik kodunu giriniz:");
                    //int sifre = Convert.ToInt32(Console.ReadLine());
                    //if (sifre == 3737)
                    //{
                    //    Console.WriteLine("güvenlik kilidi aşıldı");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("tekrar deneyin");
                    //}

                    //double sayi1, sayi2, toplam, fark, carpim, bolum;
                    //Console.Write("1. Sayı : ");
                    //sayi1 = Convert.ToDouble(Console.ReadLine());
                    //Console.Write("2. Sayı : ");
                    //sayi2 = Convert.ToDouble(Console.ReadLine());
                    //toplam = sayi1 + sayi2;
                    //fark = sayi1 - sayi2;
                    //carpim = sayi1 * sayi2;
                    //bolum = sayi1 / sayi2;
                    //Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
                    //Console.WriteLine("{0} ve {1} Sayısının Farkı : {2}", sayi1, sayi2, fark);
                    //Console.WriteLine("{0} ve {1} Sayısının Çarpımı : {2}", sayi1, sayi2, carpim);
                    //Console.WriteLine("{0} ve {1} Sayısının Bölümü : {2}", sayi1, sayi2, bolum);
                    //Console.ReadKey();
















            }













        }




    }







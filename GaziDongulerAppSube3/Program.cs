using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime;
using System.Xml.Schema;

namespace GaziDongulerAppSube3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Console.WriteLine("isminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("kaç kere yazılsın");
            //int tekrar = int.Parse(Console.ReadLine());






            //for (int i = 0; i < tekrar; i++)
            //{



            //    Console.WriteLine($"{i + 1}.{isim}");
            //}




            //Console.WriteLine("1. sayıyı giriniz");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int bit = int.Parse(Console.ReadLine());
            //Console.WriteLine("tek/çift?");
            //string cvp= Console.ReadLine();


            //    for (int i = bas; i <= bit; i++)
            //    {
            //    if(i % 2 ==(cvp == "tek" ? 1:0))
            //    {
            //        Console.WriteLine(i);
            //        sonuc += i;
            //    }

            //    }









            //int sonuc = 0;
            ////bas = 7 bit = 5
            //if (bas > bit)
            //{
            //    int temp = bas;
            //    bas = bit;
            //    bit = temp;
            //}








            //for (int i = bas; i <= bit; i++)
            //{
            //    Console.WriteLine(i);
            //    //sonuc = sonuc + i;
            //    sonuc += i;
            //}
            //Console.WriteLine($"sayıların toplamı:{sonuc}");








            //Console.WriteLine("birinci sayıyı giriniz:");
            //int sayı1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz:");
            //int sayı2 = int.Parse(Console.ReadLine());
            //for (int i = sayı2; i < sayı1; i++)
            //{
            //    Console.WriteLine($"{sayı1}+{sayı2}");
            //}
            //int sonuc = 1;
            //for (int i = 0; i < üs; i++) ;
            //{
            //    sonuc *= taban;

            //}
            //Console.WriteLine(sonuc);
            //Console.WriteLine("taban değeri giriniz");
            //int taban=int.Parse(Console.ReadLine());
            //Console.WriteLine("üs değeri giriniz");
            //int üs=int.Parse(Console.ReadLine());
            //üs = 3;
            //taban = 2;
            //for (int i = taban ; i < üs ; i++)
            //{

            //}
            //Console.WriteLine("sayı giriniz");
            //int sayi=int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i < sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);


            //Console.WriteLine("sayı giriniz");
            //int sayi=int.Parse(Console.ReadLine());
            //int sayac = 0;
            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("çift sayı girdiniz");
            //    return;
            //}

            //for(int i = 2; i <= (sayi/2); i++)
            //{

            //    if (sayi % i == 0) 
            //    {
            //        sayac++;
            //        break;//döngüden çıkan komut.
            //    }

            //}
            //Console.WriteLine(sayac == 0 ? "sayı asaldır " : "sayı asal değildir");

            //for (; ; )
            //{
            //    Console.WriteLine("kullanıcı adı giriniz:");
            //    string user=Console.ReadLine();
            //    Console.WriteLine("şifre giriniz");
            //    string password=Console.ReadLine();
            //    if (user=="berat" && password = "123")
            //{
            //        Console.WriteLine("giriş başarılı");
            //        break;
            //}
            //    else
            //    {
            //        Console.WriteLine("hatalı giriş yaptınız");
            //    }
            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //for (; ;)
            //{
            //    Console.Write("sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    sayac++;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    Console.WriteLine("devam etmek istiyor musunuz?:");
            //    string cvp=Console.ReadLine();
            //    if (cvp == "H")
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max}\nSayıların toplamı:{toplam}");
            // for (int i = 0; i < 4; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}



            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter row count");
            //int row=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter coulmn count");
            //int coulmn=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //      Console.Write((i+j) %2 ==0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}
            //SORU=
            //abcd=4*dcba
            //abcd=?

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 10; k++)
            //        {
            //            for (int i1 = 0; i1 < 10; i1++)
            //            {
            //                if (1000 * i + 100 * j + 10 * k + 1 * i1 == 4 * (1000 * i1 + 100 * k + 10 * j + 1 * i))
            //                {
            //                    Console.WriteLine($"{i}{j}{k}{i1}");

            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            //for (int i = 1; i < 100; i++)
            //{
            //    for(int j = 1; j < 100; j++)
            //    {
            //        for (int k = 1; k < 100; k++)
            //        {
            //            if (i * i + j * j == k * k)
            //            {
            //                Console.WriteLine($"{i}-{j}-{k}");
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("enter starting number");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter end number");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = start; j < end; j++)
            //    {
            //        count++;
            //        break;
            //    }
            //    Console.WriteLine(count == 0 ? $"{i}-Is Prime" : $"{i}-Is Not Prime");
            // }
            //while döngüsü=>

            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine("gazi");
            //    count++;

            //}
            //int i = 0;
            //for (; i < 5; )
            //{
            //    Console.WriteLine("gazi");
            //    i++;
            //}
            //do
            //{

            //} while (false);

            //{
            //    Console.WriteLine("kullanıcı adı giriniz:");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("şifre giriniz");
            //    string password = Console.ReadLine();
            //    if (user == "berat" && password == "123")
            //    {
            //        Console.WriteLine("giriş başarılı");

            //    }
            //    else
            //    {
            //        Console.WriteLine("hatalı giriş yaptınız");
            //    }
            //    int max = int.MinValue;
            //    double toplam = 0;
            //    double sayac = 0;
            //    for (; ; )
            //    {
            //        Console.Write("sayı giriniz:");
            //        int sayi = int.Parse(Console.ReadLine());
            //        toplam += sayi;
            //        sayac++;
            //        if (sayi > max)
            //        {
            //            max = sayi;
            //        }
            //        Console.WriteLine("devam etmek istiyor musunuz?:");
            //        string cvp = Console.ReadLine();
            //        if (cvp == "H")
            //        {
            //            break;
            //        }

            //    }
            //    Console.WriteLine($"Girilen en büyük sayı:{max}\nSayıların toplamı:{toplam}");
            //    for (int i = 0; i < 4; i++)
            //    {

            //    }

            //Random rnd = new Random();
            //int number = rnd.Next();
            //while (true)
            //{
            //    Console.WriteLine("guess the number");
            //    int unumber = int.Parse(Console.ReadLine());
            //    if (number == unumber)
            //    {
            //        Console.WriteLine("you won");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("try again");
            //        break;
            //    }

            //}
            //seviye kolay orta zor
            //puan 



























            //for (int i = 0; i < 1; i++)
            //{
            //    Random rnd = new Random();
            //    int number = rnd.Next(1);
            //    Console.WriteLine(number);
            //}

            //int sayi = 0;
            //if(sayi==1)
            //{
            //    Console.WriteLine("sayi başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("tekrar deneyiniz");
            //}





            try
            {
                Random rnd= new Random();
            int sayi = rnd.Next(0,9);

                
                for (int i = 0; i < 3; i++)


                {

                    Console.WriteLine("lütfen sayı giriniz");
                    int sayikullanici = Convert.ToInt32(Console.ReadLine());
                    if (sayi==sayikullanici)
                    {
                        Console.WriteLine("başarılı giriş");
                    }
                   

                }  
                
            }
            catch (FormatException)
            {
                Console.WriteLine("lütfen rakamla giriniz");
            }
            catch (OverflowException)
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR SAYI GİRİNİZ");
            }
            catch (Exception)
            {
                Console.WriteLine("İŞLEMİNİZ GERÇEKLEŞTİRİLEMEDİ.");
            }

















        }


    }
    }

namespace HelloWorld
{
    internal class Program
    {
        //static int oyuncusayi = 500;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            //int sayı = 30;
            //string adım ="berat";
            //byte a = 30;
            //double d = 40;
            //const double Pi = 3.14;  //sonradan değerini değiştirmek istemediğin sabit değerlerin başına const getirilir.
            // var sayı = 50;
            //string isim = "ahmet", soyad = "mehmet";
            //Console.WriteLine($"merhaba" + isim + " " + soyad);
            //Console.WriteLine("merhaba{0} {1}", isim, soyad);

            // byte yas;
            // Console.WriteLine(yas)  //( kod çalışmaz)
            //byte = 8 bitlik işaretsiz sayılar için kullanılır değer aralığı 0-255 arasındadır

            // Bit:0-1
            //8bit=1 byte
            //1024byte=1 kilobyte
            //1024kb=1MB
            //1024MB=1GB

            //Console.WriteLine("isminizi giriniz");
            //string isim = Console.ReadLine();
            //Console.WriteLine("soyadınızı giriniz");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Hoşgeldin {isim}  {soyad}");

            //Console.WriteLine("yaşınızı giriniz:");
            //string yas = Console.ReadLine();



            //kendi kendine dönüşen türlere implicit type casting denir
            //console.writeline   
            //TÜR DÖNÜŞÜMLERİ (TYPE CASTİNG)
            //C# programlama dili,tip güvenliği(type safety)sağlayan bir dildir.örn.byte bir veriye string bir değer atanamaz.
            //ancak atadığımız değeri istediğimiz veri tipine dönüştürerek atama gerçeklerştirebiliriz.
            //checked: veriyi korumak için kullanılır

            //byte sayi = 10;
            //int number = sayi;//İmplicit type casting

            //{
            //    int sayi = 257;
            //    byte number = (byte)sayi;//Explicit Type Casting
            //    Console.WriteLine(number);
            //}
            //RİSK=eğer atanmak istenen değer ,atanacak veri tipinden büyükse veri kaybı olur.Bunun önüne geçmek için checked blokları ku.
            //bu blok risk durumunda hata vererek atama yapılmasını





            //; Console.ReadKey();








            Console.WriteLine("ilk sayıyı giriniz");
            int sayi1 = int.Parse (Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());







            int sayı1 = 5, sayı2 = 10;
            string sonuc = sayi1 > sayı2 ? "sayı 1 büyüktür" :
                "sayı 2 büyük ya da sayılar eşit";
            Console.WriteLine(sonuc);
            Console.ReadKey();

            // byte a= 30, b;
            // b=40;

            // byte a, b;
            //b=40;  a=30;

            //int=32 bitlik işaretli sayılar için kullanılır.
            //sbyte(8 bit)=-128 ile +127 arasında yer alır
            //short(16 bit)
            //ushort(16 bit) işaretsiz
            //long 64 bit
            //ulong 64 bit (işaretsiz)
            // float=32 bitlik reel sayıları saklamak için kullanılır
            //double 64 bitlik reel sayıları saklamak için kullanılır.double a=3,12;  
            //decimal=128 bitlik reel değerleri saklamak için kullanılır."m"kullanır

            //bool=doğru veya yanlış değerlerini saklamak için kullanılır.karşılaştırmma  işlemlerinde kulanılır
            //bool sonuc= false;
            //char=tek bir karakter saklamak için kullanılır.16 bitlik alan kaplar.char 16 bitlik'A' şekinde yazılır
            //string = metinsel verileri saklamak için kullanıln değişken titpidir
            //çift tırnak içinde yazılır. string isim "ahmet"
            // int= değer tipi
            // string= referans tipi
            //değer tipleri stack bölgesinde saklanır

        }


        //Namespace(İsim Uzayı): İçerisinde classları bulunduran blok yapılardır.
        //Class: İçinde metotları barındıran yapılardır.
        //Main metodu olmazsa program çalışmaz.
        //Metod: İş yapan kod bloklarıdır.
        //{ }: Scope(Blok) yapısıdır.
        //İntelliSense: Kod yazım yayardımcı penceresi.
        //İntelliCode: Yapay zeka destekli kod yazım yayardımcısı.
        //Syntax: Kod yazım kurallarına denir.
        //Solution: İçerisinde projeleri tutan yapılardır.
        //Compile(Derleme): C# ---> Derleme ---> MS-IL(exe) ---> Runtime(Derleme) ---> Makine Dili(0,1)
        //MS-IL: Microsoft Intermediate Language.
        //.NET: MC tarafından geliştirilmiş bir yazılım geliştirme ortamıdır. Bunlara Framework de denir:
        //Programlama dilleri: C#, VB,F#
        //Compiler(Derleyici)-Runtime 
        //Hiyerarşiyi düzeltmek için Ctrl + K + D
        // Ctrl+K+C Yorum satırına dönüştür.
        //Ctrl+K+UYorum satırını normale dönüştür.
        // int= değer tipi
        // string= referans tipi
        //değer tipleri stack bölgesinde saklanır

        //OPERATÖRLER=
        //ARİTMATİKSEL OPERATÖRLER:

        //MANTIKSAL OPERATÖRLER



        //int sayı1 = 5, sayı2 = 10;
        //string sonuc = sayı1 > sayı2 ? "sayı 1 büyüktür" :
        //  "sayı 2 büyük yada sayılar eşit";

        //Console.Writeline(sonuc);




            
    }
}
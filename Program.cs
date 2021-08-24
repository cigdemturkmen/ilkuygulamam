using System;

namespace helloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz");
            string ad = Console.ReadLine();

            Console.WriteLine("soyad gir");
            string soyad = Console.ReadLine();

            Console.WriteLine("Adınız: {0} Soyadınız: {1}", ad, soyad);
            Console.WriteLine($"Adınız: {ad} Soyadınız: {soyad}");

   
        }
    }
}

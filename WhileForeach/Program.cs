using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den baslayasrak
            //konsola girilen sayıya kadar sayı dahil
            //ortalama hesapla
            Console.WriteLine("sayı giriniz");
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayı)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam);
            Console.WriteLine(toplam / sayı);

            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("*******foreach *******");

            string[] arabalar = { "bmw", "ford", "toyota" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }






        }
    }
}

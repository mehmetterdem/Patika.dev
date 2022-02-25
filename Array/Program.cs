using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi taanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kus", "kedi", "kopek", "tavuk" };
            int[] dizi;
            dizi = new int[5];
            //deger atma ve erişim

            renkler[0] = "mavı";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //dongulerle dizi kullanımı
            //klavyeden girilen sayının ortalamasını hesaplayan 
            Console.WriteLine("lütfen diziniin elemman sayısını girinz");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDdizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("lütfen {0}.sayıyı giriniz", i + 1);
                sayiDdizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayiDdizisi)
            {
                toplam += item;
               
            }
            Console.WriteLine("ortalama :"+toplam/diziuzunlugu);




        }
    }
}

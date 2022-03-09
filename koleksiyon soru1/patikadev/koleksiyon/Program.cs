using System;
using System.Collections;

namespace koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayılar = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            ArrayList asal = new ArrayList();
            
                for (int i = 0; i < 5; i++)
                {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n > 0)
                    {
                        sayılar.Add(n);
                    }
                    else
                    {
                        i -= 1;
                        Console.WriteLine("lütfen pozitif sayı giriniz");
                    }
                }
                catch (FormatException)
                {
                    i -= 1;
                    Console.WriteLine("lütfen gecerli bir sayı giriniz");
                }


                }

            

            
            

            foreach (int item in sayılar)
            {
                int sayac = 0;
                for (int i = 2; i < item; i++)
                {
                    if (item%i==0)
                    {
                        sayac++;
                    }
                }
                if (sayac==0)
                {
                    asal.Add(item);
                }
                else
                {
                    asaldegil.Add(item);
                }
            }
            foreach (int item in asaldegil)
            {
                Console.WriteLine("asal olmayan"+item);
            }
            foreach (int item in asal)
            {
                Console.WriteLine("asal sayılar"+item);
            }
            Console.WriteLine("**********sıralama**********");
            asal.Sort();
            asal.Reverse();
            asaldegil.Sort();
            asaldegil.Reverse();
            Console.WriteLine("asal sıralama");
            foreach (int item in asal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("asal olmayanları sıralama");
            foreach (int item in asaldegil)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****eleman sayısı ve ortalaması");
            int asaladeti = asal.Count;
            Console.WriteLine("asal eleman sayısı"+asal.Count);
            int asaldeğiladeti = asaldegil.Count;
            Console.WriteLine("asla değil eleman sayısı"+asaldegil.Count);

            int toplam = 0;
            foreach (int item in asal)
            {
                toplam += item;
            }
            Console.WriteLine("asal toplam"+toplam);
            int asalortalama = toplam / asaladeti;
            Console.WriteLine("asalortalama: "+asalortalama);
            int tp = 0;
            foreach (int item in asaldegil)
            {
                tp += item;
            }
            int asaldegilortalama = tp / asal.Count;
            Console.WriteLine("asaldeğilortalama: "+asaldegilortalama);
         




        }


    }
}

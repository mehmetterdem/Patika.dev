using System;
using System.Collections;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            Console.WriteLine("metin giriniz");
            string metin = Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
               if(sesli.Contains(metin[i]))
                {
                    sayac++;
                    dizi.Add(metin[i]);
                }        
            }

            dizi.Sort();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

        }
    }
}

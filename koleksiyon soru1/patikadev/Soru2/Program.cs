using System;
using System.Collections;
using System.Collections.Generic;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayılar = new ArrayList();
            int[] sayılaar = new int[20];
            for(int i = 0; i < 20; i++)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    sayılar.Add(n);
                    
                }
                catch (FormatException)
                {
                    i -= 1;
                    Console.WriteLine("lütfen gecerli bir sayı giriniz");
                }


            }
            sayılar.Sort();
            int sayac = 1;
            ArrayList enbuyuk = new ArrayList();
            ArrayList enkucuk = new ArrayList();
            foreach (int item in sayılar)
            {
                if (sayac==1||sayac==2||sayac==3)
                {
                    enkucuk.Add(item);
                }
                else if (sayac==18||sayac==19||sayac==20)
                {
                    enbuyuk.Add(item);
                }
                sayac++;
            }
            int kucukortalama = 0;
            int buyukortalama = 0;
            foreach (int item in enkucuk)
            {
               kucukortalama+= item;
            }
            foreach (int item in enbuyuk)
            {
                buyukortalama += item;
            }

            Console.WriteLine(kucukortalama/3);
            Console.WriteLine(buyukortalama/3);
            Console.WriteLine("toplamları"+((kucukortalama/3)+(buyukortalama/3)));




            
            
           
        }
    }
}

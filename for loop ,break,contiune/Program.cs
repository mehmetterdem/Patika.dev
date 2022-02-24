using System;

namespace for_loop__break_contiune
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("sayı giriniz");
            //int sayac = int.Parse(Console.ReadLine());
            //for (int i = 1; i <=sayac; i++)
            //{
            //    if (i%2==1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int tektoplam = 0;
            //int cifttoplam = 0;

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        tektoplam += i;
            //    }
            //    else
            //        cifttoplam += i;
            //}
            //Console.WriteLine("tektoplam: "+tektoplam+"\ncifttoplam: "+cifttoplam);

            ////break,contiune
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==4)
            //    {
            //        continue;

            //    }
            // Console.WriteLine(i);
            //}
            Console.WriteLine("sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j>= i; j++)
                {
                   if(j<a)
                    Console.Write("#");
                  
                    else
                        Console.WriteLine("%");
                }
            }










        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sıralama
            int[] sayıdizisi = { 23, 12, 4, 72, 3, 11, 17 };
            foreach (var item in sayıdizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("sıralı dizi");
            Array.Sort(sayıdizisi);
            foreach (var item in sayıdizisi)
            {
                Console.WriteLine(item);
            }
            //clear
            Console.WriteLine("array clear");
            Array.Clear(sayıdizisi, 2, 2);
            foreach (var item in sayıdizisi)
            {
                Console.WriteLine(item);
            }
            //reverse,
            Console.WriteLine("array reverse");
            Array.Reverse(sayıdizisi);
            foreach (var item in sayıdizisi) 
            {
                Console.WriteLine(item);
            }

            //indexOf
            Console.WriteLine("arrayindexOf");
            Console.WriteLine(Array.IndexOf(sayıdizisi,23));

            //resize

            Console.WriteLine("array size");
            Array.Resize<int>(ref sayıdizisi, 9);
            sayıdizisi[8] = 99;
            foreach (var item in sayıdizisi)
            {
                Console.WriteLine(item);
            }



        }
    }
}

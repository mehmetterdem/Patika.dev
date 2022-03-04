using System;
using System.Collections;
using System.Collections.Generic;

namespace KoleksiyonlarArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //içerisindeki verilere erişim

            //Console.WriteLine(liste[0]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}


            //addrange
            Console.WriteLine("*****addrange*****");
            //string[] renkler = { "kırmızı", "mavi", "sarı" };
            List<int> ayılar = new List<int>() { 1, 5, 6, 9, 7 };
            //liste.AddRange(renkler);
            liste.AddRange(ayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort
            Console.WriteLine("********sort********");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //binary search
            Console.WriteLine("*****binary search*****");
            Console.WriteLine(liste.BinarySearch(9));
            //reverse

            Console.WriteLine("*****reverse******");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear
            Console.WriteLine("*******clear**********");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


        }
    }
}

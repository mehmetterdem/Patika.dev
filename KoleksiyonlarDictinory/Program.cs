using System;
using System.Collections.Generic;

namespace KoleksiyonlarDictinory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "ayse yılmaz");
            kullanıcılar.Add(12, "ahmet yılmaz");
            kullanıcılar.Add(18, "deniz arda");
            kullanıcılar.Add(20, "ozcan cossar");

            //dizinin elemanlarına eriişim

            Console.WriteLine("***elemanları erişim****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //count;
            Console.WriteLine(kullanıcılar.Count);

            //contains
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("mehmet erdem"));

            //remove

            Console.WriteLine("********remove******");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
            }

            //keys
            Console.WriteLine("***keyss****");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}

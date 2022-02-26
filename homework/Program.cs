using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region soru1
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n)
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


            //    Console.WriteLine("bir sayı giriniz");
            //tekrar:
            //    int N = Convert.ToInt32(Console.ReadLine());
            //    if (N < 0)
            //    {
            //        goto tekrar;

            //    }
            //    Console.WriteLine(N);
            //    Console.WriteLine($"{N} adet pozitif sayı giriniz");
            //    int[] sayılar = new int[N];
            //    for (int i = 0; i < sayılar.Length; i++)
            //    {

            //        int a = Convert.ToInt32(Console.ReadLine());
            //        if (a > 0)
            //        {
            //            sayılar[i] = a;
            //        }
            //        else
            //        {
            //            i = i - 1;


            //        }





            //    }
            //    foreach (var item in sayılar)
            //    {
            //        {
            //            if (item % 2 == 0)
            //                Console.Write("-" + item);
            //        }

            //    }


            #endregion
            #region soru2
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            //int n, m;
            //Console.WriteLine("iki adat pozitif tam sayı giriniz");
            //tekrar:
            //n = Convert.ToInt32(Console.ReadLine());
            //m = Convert.ToInt32(Console.ReadLine());
            //if (n<0||m<0)
            //{
            //    goto tekrar;
            //}
            //Console.WriteLine($"{n} adet pozitif sayı giriniz");
            //int[] sayılar = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    sayılar[i] = Convert.ToInt32(Console.ReadLine());
            //    if (sayılar[i]<0)
            //    {
            //        Console.WriteLine("negatif sayı girdiniz");
            //        i = i - 1;

            //    }
            //}
            //foreach (var item in sayılar)
            //{
            //    if (item==m||item%m==0)
            //    {
            //        Console.Write("-"+item);
            //    }
            //}








            #endregion
            #region soru3
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            //tekrar:
            //    Console.WriteLine("pozitif bir sayı giriniz");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    if (n < 0)
            //    {
            //        goto tekrar;
            //    }
            //    string[] kelimeler = new string[n];
            //    Console.WriteLine($"{n} adet kelime giriniz");
            //    for (int i = 0; i < n; i++)
            //    {
            //        kelimeler[i] = Console.ReadLine();
            //    }
            //    Array.Reverse(kelimeler);
            //    foreach (var item in kelimeler)
            //    {

            //        Console.WriteLine(item);
            //    }











            #endregion
            #region soru4

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("bir seyler yazın");
            string a = Console.ReadLine();
            string[] kelimeler = a.Split(" ");
            Console.WriteLine("kelime sayı: "+kelimeler.Length);
            string bosluksil = a.Replace(" " , "");
            Console.WriteLine("harf sayısı: "+bosluksil.Length);










            #endregion


























        }
    }
}


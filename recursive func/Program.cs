using System;

namespace recursive_func
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif-özyinelemeli
            //3^4=3*3*3*3
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
                Console.WriteLine(result);

            }
            Islemler instance = new Islemler();
            Console.WriteLine(instance.expo(3,4));

            //extension metotlar
            string ifade = "mehmet erdem";
            bool sonuc = ifade.checkspaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.removeWhiteSpaces());
                Console.WriteLine(ifade.makeuppercase());
                Console.WriteLine(ifade.makelowercase());
            
            }
            int[] dizi = { 54, 12, 33, 6, 5, 7, 99 };

            dizi.arraysort();
            dizi.ekranayaz();
            int sayı = 5;
            sayı.iseven();
            Console.WriteLine(sayı.iseven());
            Console.WriteLine(ifade.getfirstcharacter());
        }
    }


    public class Islemler
    {

        public int expo(int sayı,int üs)
        {
            if (üs<2)
            {
                return sayı;
            }

            return expo(sayı, üs - 1) * sayı;
        }
        



    }

    public static class extension
    {
        public static bool checkspaces(this string param)
        {
           return param.Contains(" ");
        }

        public static string removeWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("--",dizi);
        }
        public static string makeuppercase(this string param)
        {
            return param.ToUpper();
        }
        public static string makelowercase(this string param)
        {
            return param.ToLower();
        }
        public static int[] arraysort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void ekranayaz(this int[]param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool iseven(this int param)
        {
            return param % 2 == 0;
        }
        public static string getfirstcharacter(this string param)
        {
          return  param.Substring(0,5);
        }




    }

}










using System;

namespace HazırMetodlar_1_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken = "Dersimiz6 cSharp,Hosgeldi5niz";
            string degisken2 = " cSharp";
            ////length:
            //Console.WriteLine(degisken.Length);

            ////toUpper  ToLower

            //Console.WriteLine(degisken.ToLower());
            //Console.WriteLine(degisken.ToUpper());

            ////concat

            //Console.WriteLine(string.Concat(degisken,"merhaba"));

            ////compare-compareto

            //Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            //Console.WriteLine(string.Compare(degisken,degisken2,true));
            //Console.WriteLine(string.Compare(degisken, degisken2,false));
            ////contains

            //Console.WriteLine(degisken.Contains(degisken2));
            //Console.WriteLine(degisken.StartsWith("Hosgeldiniz"));
            //Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));

            ////indexof
            //Console.WriteLine(degisken.IndexOf("cS"));
            //Console.WriteLine(degisken.IndexOf("mehmet"));
            //Console.WriteLine(degisken.LastIndexOf("i"));
            ////insert
            //Console.WriteLine(degisken.Insert(0,"mehmet"));
            ////padleft,PadRight
            //Console.WriteLine(degisken+degisken2.PadLeft(30));
            //Console.WriteLine(degisken + degisken2.PadLeft(30,'-'));
            //Console.WriteLine(degisken.PadRight(40)+degisken2);
            //Console.WriteLine(degisken.PadRight(40,'*') + degisken2);

            ////remove
            //Console.WriteLine(degisken.Remove(10));
            //Console.WriteLine(degisken.Remove(5,3));
            //Console.WriteLine(degisken.Remove(0,1));

            ////replace
            //Console.WriteLine(degisken.Replace("cSharp","C#"));
            //Console.WriteLine(degisken.Replace(" ","-"));

            ////split
            //Console.WriteLine(degisken.Split(" ")[0]);

            ////substring
            //Console.WriteLine(degisken.Substring(4));
            //Console.WriteLine(degisken.Substring(4,6));




            string s;
                int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                 s = Console.ReadLine();
                result(s);
            }




        }
        static void result(string s)
        {
            string cift = "";
            string tek = "";


            for (int i = 0; i<s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    cift += s[i];
                }
                else
                {
                    tek += s[i];
                }



            }
            Console.WriteLine($"{cift} {tek}");
        }




    }
}

using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int sonuc = topla(a, b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();
            ornek.ekranaYaz(Convert.ToString( sonuc));
            int sonuc2 = ornek.arttırVeTopla(a,b);
            ornek.ekranaYaz(Convert.ToString(sonuc2));
            ornek.ekranaYaz(Convert.ToString(a + b));
        
        }


        
         static int topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }





    }
    class metotlar
    {
        public void ekranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }

        public int arttırVeTopla(int deger1, int deger2)
        {
            deger1 +=1;
            deger2 += 1;
            return deger1 + deger2;
        }




    }



} 

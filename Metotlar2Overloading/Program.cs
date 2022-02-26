using System;

namespace Metotlar2Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayı = "999";
            bool sonuc= int.TryParse(sayı, out int outsayı);
            if(sonuc)
            {
                Console.WriteLine("basaralı");
                Console.WriteLine(outsayı);
            }
            else
            {
                Console.WriteLine("başarsız");
            }
            metotlar instance = new metotlar();
            instance.topla(4, 5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            int ifade = 99;
            instance.ekranaYaz(ifade);
        }
    }

    class metotlar
    {
        public void topla(int a,int b,out int toplam)
        {
            toplam = a + b;
        }
        public void ekranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYaz(int veri)
        {
            Console.WriteLine(veri);
        }
        


    }

}

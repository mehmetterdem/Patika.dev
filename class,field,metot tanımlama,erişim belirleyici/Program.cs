using System;

namespace class_field_metot_tanımlama_erişim_belirleyici
{
    class Program
    {
        static void Main(string[] args)
        {
            Calısan calısan1 = new Calısan();
            calısan1.ad = "mehmet";
            calısan1.Soyad="erdem";
            calısan1.No = 1;
            calısan1.Departman = "developer";
            calısan1.calısanbilgileri();
            Console.WriteLine("*******************************");
            Calısan calısan2 = new Calısan();
            calısan2.ad = "deniz";
            calısan2.Soyad = "arda";
            calısan2.No = 2;
            calısan2.Departman = "satın alma";
            calısan2.calısanbilgileri();
        
        
        
        
        
        
        }
    }
    class Calısan
    {
        public string ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void calısanbilgileri()
        {
            Console.WriteLine("Calısan Adı:{0}",ad);
            Console.WriteLine("Calısan Soyadı{0}",Soyad);
            Console.WriteLine("Calısan numarası:{0}",No);
            Console.WriteLine("Calısan Departman:{0}",Departman);

        }


    }
}

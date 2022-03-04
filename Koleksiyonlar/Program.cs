using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılistesi = new List<int>();
            sayılistesi.Add(29);
            sayılistesi.Add(10);
            sayılistesi.Add(4);
            sayılistesi.Add(5);
            sayılistesi.Add(52);
            sayılistesi.Add(34);

            List<string> renklistesi = new List<string>();
            renklistesi.Add("kırmızı");
            renklistesi.Add("sarı");
            renklistesi.Add("turuncu");
            renklistesi.Add("yeşil");


            //count

            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayılistesi.Count);

            foreach (var item in sayılistesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renklistesi)
            {
                Console.WriteLine(item);

            }

            sayılistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));



            //listeden eleman cıkarma

            sayılistesi.Remove(4);
            renklistesi.Remove("yeşil");

            sayılistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));

            sayılistesi.RemoveAt(0);
            renklistesi.RemoveAt(1);
            sayılistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));

            //liste içerisinde arama

            if (sayılistesi.Contains(10))
            {
                Console.WriteLine("10 listede bulundu");
            }


            //diiziyi listeye cevirme

            string[] hayvanlar = { "kedi", "köpek", "kus" };
            List<string> hayvanlistesi = new List<string>(hayvanlar);


            //liste temizleme

            hayvanlistesi.Clear();
            //list içerisinde nesne tutma

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "mehmet";
            kullanıcı1.Soyisim = "erdem";
            kullanıcı1.Yas = 27;


            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "ali";
            kullanıcı2.Soyisim="yılmaz";
            kullanıcı2.Yas = 23;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniliste = new List<Kullanıcılar>();

            yeniliste.Add (new Kullanıcılar()
            {
                Isim = "mehmet",
                Soyisim ="erdem",
                Yas = 22,

            });
            foreach (var item in yeniliste)
            {
                Console.WriteLine("kullanıcı adı:"+item.Isim);
                Console.WriteLine("kullanıcı soyadı:"+item.Soyisim);
                Console.WriteLine("kullanıcı yası"+item.Yas);
            }






        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get=>isim; set=>isim=value; }

        public string Soyisim { get=>soyisim; set=>soyisim=value; }

        public int Yas { get=>yas; set=>yas=value; }

    }




}

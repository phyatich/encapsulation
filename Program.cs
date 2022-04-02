using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";            
            ogrenci.Soyisim = "Yılmaz";            
            ogrenci.OgrenciNo = 293;            
            ogrenci.Sinif = 3;            
            ogrenci.OgrenciBilgileriniGetir();
            Console.WriteLine();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            Console.WriteLine();

            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        {
            get{ return isim; } 
            set{ isim = value; } 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Öğrenci Adı      : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı   : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No       : {0}", this.ogrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;            
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;            
        }
    }
}

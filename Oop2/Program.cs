using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.ID = 1;
            musteri1.MusteriNo = "12323";
            musteri1.Adi = "Muhammet";
            musteri1.Soyadi = "Yıldırım";
            musteri1.TcNo = "12312312312";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "1231234";
            musteri2.VergiNo = "54312";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustumerManager custumerManager = new CustumerManager();
            custumerManager.Add(musteri3);
            custumerManager.Add(musteri4);

        }
    }
}

// Not Ortalaması Hesaplama ve Değerlendirme Uygulaması
using System;
using System.Collections.Generic;

class Program
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public int Not1 { get; set; }
        public int Not2 { get; set; }
        public int Not3 { get; set; }

        public double Ortalama => (Not1 + Not2 + Not3) / 3.0;
    }

    static void Main(string[] args)
    {
        Console.Write("Kaç öğrenci gireceksiniz? ");
        int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

        List<Ogrenci> ogrenciler = new List<Ogrenci>();

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.WriteLine($"\n{i + 1}. öğrenci bilgileri:");
            Ogrenci o = new Ogrenci();

            Console.Write("Ad: ");
            o.Ad = Console.ReadLine();

            o.Not1 = NotAl("1. not: ");
            o.Not2 = NotAl("2. not: ");
            o.Not3 = NotAl("3. not: ");

            ogrenciler.Add(o);
        }

        Console.WriteLine("\n--- Öğrenci Ortalamaları ---");
        double toplamOrtalama = 0;
        Ogrenci enBasarili = null;

        foreach (var ogr in ogrenciler)
        {
            Console.WriteLine($"{ogr.Ad} - Ortalama: {ogr.Ortalama:F2}");

            toplamOrtalama += ogr.Ortalama;

            if (enBasarili == null || ogr.Ortalama > enBasarili.Ortalama)
            {
                enBasarili = ogr;
            }
        }

        double sinifOrt = toplamOrtalama / ogrenciler.Count;
        Console.WriteLine($"\nSınıf Ortalaması: {sinifOrt:F2}");
        Console.WriteLine($"En Başarılı Öğrenci: {enBasarili.Ad} ({enBasarili.Ortalama:F2})");
    }

    static int NotAl(string mesaj)
    {
        int not;
        while (true)
        {
            Console.Write(mesaj);
            string girdi = Console.ReadLine();

            if (int.TryParse(girdi, out not) && not >= 0 && not <= 100)
            {
                return not;
            }
            else
            {
                Console.WriteLine("Lütfen 0 ile 100 arasında bir not girin.");
            }
        }
    }
}



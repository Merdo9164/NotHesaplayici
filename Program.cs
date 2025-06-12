// Not Ortalaması Hesaplama ve Değerlendirme Uygulaması
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Öğrenci adını girin: ");
        string ad = Console.ReadLine();

        // Notları al
        int not1 = NotAl("1. notu girin: ");
        int not2 = NotAl("2. notu girin: ");
        int not3 = NotAl("3. notu girin: ");

        // Ortalama hesapla
        double ortalama = (not1 + not2 + not3) / 3.0;

        // Sonucu yazdır
        Console.WriteLine($"\n{ad} adlı öğrencinin ortalaması: {ortalama}");

        if (ortalama < 50)
        {
            Console.WriteLine("Durum: Kaldı");
        }
        else if (ortalama < 70)
        {
            Console.WriteLine("Durum: Geçti");
        }
        else
        {
            Console.WriteLine("Durum: Başarılı");

            if (ortalama >= 90)
            {
                Console.WriteLine("Tebrikler, onur belgesi kazandınız!");
            }
        }
    }

    // Not alma fonksiyonu (0–100 kontrolü içerir)
    static int NotAl(string mesaj)
    {
        int not;
        while (true)
        {
            Console.Write(mesaj);
            string girdi = Console.ReadLine();

            if (int.TryParse(girdi, out not) && not >= 0 && not <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçerli bir not girin (0–100 arası).");
            }
        }

        return not;
    }
}


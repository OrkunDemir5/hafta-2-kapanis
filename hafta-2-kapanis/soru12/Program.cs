// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int Enbuyugu()
{
    int sayac = 1;
    int sayi;
    bool sonuc = true;
    int enBuyuk = int.MinValue;

    while (sonuc)
    {
        Console.Write($"Sayı {sayac}");
        string cevap = Console.ReadLine();
        sonuc = int.TryParse(cevap, out sayi);

        if (sonuc)
        {
            enBuyuk = Math.Max(enBuyuk, sayi);
        }
    }

    return enBuyuk;
}

int buyuk = Enbuyugu();
Console.WriteLine("En Büyük Sayı: " + buyuk);
Console.ReadKey();
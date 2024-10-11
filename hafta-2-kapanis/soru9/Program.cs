// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Birinci sayıyı giriniz.");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz.");
        int sayi2 = int.Parse(Console.ReadLine());

        // metodu çağırıyoruz
        int toplam = Topla(sayi1, sayi2);
        // Sonucu yazdırıyoruz
        Console.WriteLine($"Toplam: {toplam}");
    }

    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
}

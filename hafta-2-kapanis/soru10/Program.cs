// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen true ya da false yazınız: ");
        bool kullaniciGirisi = bool.Parse(Console.ReadLine());

        // metodu çağırıyoryz
        string sonuc = DegerDodnur(kullaniciGirisi);

        Console.WriteLine($"Sonuç: {sonuc}");
    }

    // true / false değer dönen metod
    static string DegerDodnur(bool deger)
    {
        if (deger)
        {
            return "Girilen değer true, doğru";
        }
        else
        {
            return "Girilen değer false, yanlış";
        }

    }
}
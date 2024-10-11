// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Random rastgele = new Random();
int sayi = rastgele.Next() % 2;

Console.WriteLine($"Kalan: {sayi}");


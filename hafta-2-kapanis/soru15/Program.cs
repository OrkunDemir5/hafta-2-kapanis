// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

double AlinanYol(double hiz, double sure)
{
    return hiz * sure;
}

Console.WriteLine("saatteki 100km/sa olan bir araç 3 saatte ne kadar yol gider");
Console.WriteLine(AlinanYol(100,3));

Console.ReadKey();

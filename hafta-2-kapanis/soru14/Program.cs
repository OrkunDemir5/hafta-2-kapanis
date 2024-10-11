// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

bool CiftMi(int sayi)
{
    return sayi % 2 == 0;
}
Console.Write("Bir sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(sayi) ? "Çift" : "Tek");

Console.ReadKey();

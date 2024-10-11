// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.WriteLine("Yaşınızı Griniz.");

int yas = int.Parse(Console.ReadLine());

if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

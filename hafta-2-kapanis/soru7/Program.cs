// 7- Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("1. İsmi Giriniz");
string birinciIsim = Console.ReadLine();

Console.WriteLine("2. İsmi Giriniz");
string ikinciIsim = Console.ReadLine();

Console.WriteLine($"isimler: {birinciIsim}, {ikinciIsim}");

// yerleri değiştiriyoruz

string temp = birinciIsim;
birinciIsim = ikinciIsim;
ikinciIsim = temp;

// Değiştirilimiş isimleri ekrana yazdırıyoruz
Console.WriteLine($"Yerleri değiştirildi: {birinciIsim}, {ikinciIsim}");
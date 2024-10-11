// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
int YaslarinEnbuyugu(int y1, int y2, int y3)
{
    return Math.Max(Math.Max(y1, y2), y3);
}

Console.WriteLine(YaslarinEnbuyugu(65, 18, 44)); 
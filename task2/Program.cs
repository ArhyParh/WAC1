// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Main();
void Main()
{
    Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine()!);
    int b = SumOfNumber(a);
    Console.WriteLine(b);

}
int SumOfNumber(int n)
{
    int res = 0;
    int last = 0;
    while (n > 0)
    {
        last = n % 10;
        res = res += last;
        last = 0;
        n /= 10;
    }
    return res;
}
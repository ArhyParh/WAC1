// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Main();
void Main()
{
    Console.WriteLine("Введите 2 числа...");
    int a = int.Parse(Console.ReadLine()!);
    int b = int.Parse(Console.ReadLine()!);
    int c = NumberX(a,b);
    Console.WriteLine(c);
}
int NumberX(int first, int second)
{
    int res = 1;
    int i = 0;
    while (i < second)
    {
        res = res * first;
        i++;

    }
 return res;
}
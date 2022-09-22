// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа. 456 -> 5

Console.Clear();
Console.Write("Введите число, ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 1000)
{
    Console.Write("Ты издеваешься, введите заново");
int n1 = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine((n / 10) % 10);
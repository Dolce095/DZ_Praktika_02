// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным. 6 -> да; 7 -> да; 1 -> нет

Console.Clear();
Console.Write("Введите число, обозначающее день недели,  ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 5 && n >= 1)
{
    Console.Write("Нет");
int n1 = Convert.ToInt32(Console.ReadLine());
}
else 
{
Console.Write("Да");
}

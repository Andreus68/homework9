/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число M");
int userNumberStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int userNumberEnd = Convert.ToInt32(Console.ReadLine());


void SumNumber(int Start, int End, int sum)
{
    if (Start > End)
    {
        Console.WriteLine($"Сумма элементов от M до N: {sum}");
        return;
    }
    sum = sum + (Start++);
    SumNumber(Start, End, sum);
}
SumNumber(userNumberStart, userNumberEnd, 0);

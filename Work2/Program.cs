// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());

void NumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}
NumberSum(numberM, numberN, 0);
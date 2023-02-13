// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Я Вас попросил ввести положительное число)");
    return;
}

int Ackermann(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if ((numberM != 0) && (numberN == 0))
        return Ackermann(numberM - 1, 1);
    else
        return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
}

int result = Ackermann(numberM, numberN);
Console.Write(result);
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 21

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

int getSumDigitsInNumber(int number)
{
    int result = 0;
    int k;
    string numberStr = Convert.ToString(number);
    while (numberStr != "" && numberStr != "-")
    {
        k = int.Parse(Convert.ToString(numberStr[numberStr.Length - 1]));
        result += k;
        numberStr = numberStr.Remove(numberStr.Length - 1);
    }
    return result;
}

int number = getNumber("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number} равна - {getSumDigitsInNumber(number)}");
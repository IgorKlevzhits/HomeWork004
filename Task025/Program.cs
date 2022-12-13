// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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
int number = getNumber("Введите число возводимое в степень: ");
int degree = getNumber("Введите степень в которую нужно возвести число: ");
Console.WriteLine($"Число {number} возведенное в {degree}-ую степень равно - {Math.Pow(number, degree)}");
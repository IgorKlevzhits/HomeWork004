/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && (result > 0))
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

int[] getArray(int number)
{
    Random rnd = new Random();
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

void showArray(int[] array)
{
    Console.Write($"[{array[0]}");
    if (array.Length > 1)
    {
        for (int i = 1; i < array.Length; i++)
        {
            Console.Write($", {array[i]}");
        }
    }
    Console.WriteLine("]");
}
int number = getNumber("Введите размер массива: ");
int[] array = getArray(number);
Console.Write("Ваш массив - ");
showArray(array);
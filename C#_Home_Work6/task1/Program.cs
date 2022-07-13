/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int GetQuantity()
{
    int result = 0;
    Console.WriteLine("Введите количество чисел");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не натурально число. Введите корректное число ");
        }
    }
    return result;
}


int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите числo");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не натурально число. Введите корректное число ");
        }
    }

    return result;
}

int quantity = GetQuantity();

int result = 0;

for (int i = 1; i <= quantity; i++)
{
    int number = GetNumber();
    if (number > 0)
        result ++;
}

Console.WriteLine($"Количество чисел больше 0 = {result}");
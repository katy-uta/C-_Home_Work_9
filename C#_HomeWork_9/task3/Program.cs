/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/ 

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите число M");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int m = int.Parse(Console.ReadLine());

int functionAkkerman = Akkerman(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");
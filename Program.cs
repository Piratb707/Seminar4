/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16");

int a, b;
int result = 1;
Console.WriteLine("Введите знаение a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знаение b: ");
b = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= b; i++)
{
    result *= a;
}
Console.WriteLine("{0}^{1} = {2}", a, b, result);
Console.WriteLine("Нажмите любую кнопку для перехода к следующей задаче");
Console.ReadKey();



/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11 82 -> 10 9012 -> 12");

int num, sum = 0;
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
while (num != 0)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine("Сумма цифр в числе: " + sum);
Console.WriteLine("Нажмите любую кнопку для перехода к следующей задаче");
Console.ReadKey();


/*
Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1,
 33]
*/
Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 6, 1, 33 -> [6, 1, 33]");

int m;
Console.WriteLine("Введите размер массива: ");
m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите элемент {0}: ", i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
for (int i = 0; i < m; i++)
{
    Console.Write(arr[i] + ", ");
}
Console.Write("\b\b]");
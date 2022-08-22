// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// "Напишите ЦИКЛ" значит возводить в степень нужно циклом, а не методом Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Программа для возведения чисел в степень");
// Console.WriteLine("Введите число ");
// string? numberString1 = Console.ReadLine();
// int a = int.Parse(numberString1!);

// Console.WriteLine("Введите степень, в которую нужно ввести число");
// string? numberString2 = Console.ReadLine();
// int b = int.Parse(numberString2!);

// int degree = a;

// for (int i = 1; i < b; i++)
// {
//     degree = degree * a;
// }
// Console.WriteLine("Результат возведения в степень =" + degree);

Console.WriteLine("Программа для возведения чисел в степень");
int Degree(int numberA, int numberB)
{
    int summ = 1;
    for (int i = 1; i <= numberB; i++)
    {
        summ = summ * numberA;
    }
    return summ;
}

Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно ввести число");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numberA, numberB);
Console.WriteLine("Результат возведения в степень =" + degree);
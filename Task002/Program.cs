// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

/* Console.WriteLine("Программа для вычисления суммы цифр в числе");

Console.WriteLine("Введите число ");
string? numberString1 = Console.ReadLine();
int a = int.Parse(numberString1!);
int sum = 0;
if (a < 0) //Небольшая защита от "дурака"
{
    a = a * (-1);
}

while (a > 0)
{
    int num = a % 10;
    a = a / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма цифр в числе =" + sum); */

Console.WriteLine("Программа для вычисления суммы цифр в числе");
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int number)
{
    int count = Convert.ToString(number).Length;
    int step = 0;
    int sum = 0;
    if (number < 0)
    {
        number = number * (-1);
    }
    for (int i = 0; i < count; i++)
    {
        step = number % 10;
        sum = sum + step;
        number = number / 10;
    }
    return sum;
}

int sumNum = SumNum(number);
Console.WriteLine("Сумма цифр в числе: " + sumNum);


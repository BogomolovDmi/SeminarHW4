// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива"); 
int X = int.Parse(Console.ReadLine()!); 
 
int[] createArray() 
{ 
    var random = new Random(); 
 
    var result = new int[X]; 
 
    for (long i = 0; i < result.Length; i++) 
    { 
        result[i] = random.Next(-9, 10); 
    } 
 
    return result; 
} 
 
void printArray1(int[] array) 
{ 
    Console.Write("["); 
 
    for (var i = 0; i < array.Length; i++) 
    { 
        Console.Write(array[i]); 
 
        if (i != array.Length - 1) 
            Console.Write(", "); 
    } 
 
    Console.Write("]"); 
    Console.WriteLine(); 
} 
 
var array = createArray(); 
printArray1(array);
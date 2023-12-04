// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.
Random rnd = new Random();
Double [] arr = new Double[10];

for (int i = 0; i < arr.Length;i++){
    arr[i] = rnd.NextDouble() * 100 - 20;
    Console.WriteLine($"{arr[i]}");
}

double min = arr[0];
double max = arr[0];

for (int i = 0; i < arr.Length;i++){
    min = (arr[i] < min) ? arr[i] : min;
    max = (arr[i] > max) ? arr[i] : max;
}

Console.WriteLine($"Минимальное элемент массива: {min}");
Console.WriteLine($"Максимальное элемент массива: {max}");
Console.WriteLine($"Разница между максимальным и минимальным: {max - min}");
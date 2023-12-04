// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int [] arr = new int[10];
int n_count = 0;
Random rnd = new Random();

for (int i = 0; i < arr.Length;i++){
    arr[i] = rnd.Next(1,100);
    if (arr[i] >=20 && arr[i] <= 90){
        n_count++;
    } 
}
Console.WriteLine(string.Join(",", arr));
Console.WriteLine($"Чисел от 20 до 90: {n_count}");
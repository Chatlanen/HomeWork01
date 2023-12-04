// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.


int num = new Random().Next(1,100000);
int n_count = num.ToString().Length;

Console.WriteLine($"Num: {num}");

int [] arr = new int [n_count];
for (int i = n_count-1; i >= 0; i--){
    arr[i] = num % 10;
    num = num /10;
}
Console.WriteLine(string.Join(",", arr));


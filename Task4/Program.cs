// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[]  array  = new int[123];
int    sum    = 0;               // сюда сложим сумму элементов из отрезка [10,99]. Количество элементов [10,99] равно 89.
int    length = array.Length;
Random rnd    = new Random();

for (int i = 0; i < length; i++) // Заполним массив случайными значениями
    array[i] = rnd.Next(-1000,1000);
    
for (int j = 9; j < 99; j++)     // Посчитаем сумму в отрезке
    sum =+ array[j];


Console.WriteLine($"Сумма элементов в отрезке 10 - 99 равна {sum}");
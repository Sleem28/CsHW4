// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();
uint[]  uArray = new uint[100];
uint    even   = 0;
uint    odd    = 0;
int     length = uArray.Length;
Random  rnd    = new Random();

for (int i = 0; i < length; i++) // Заполним и проверим в одном цикле
{
    uArray[i] = (uint)rnd.Next(100,1000);
    if(uArray[i]%2 == 0) even++;
    else                 odd++;
}

Console.WriteLine($"Количество четных чисел равно {even}.\nКоличество нечетных чисел равно {odd}.");
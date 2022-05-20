//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();
int[]  array        = new int[12];
int    length       = array.Length;
int    posVeluesSum = 0;
int    negValuesSum = 0; // переменнаяя останется без изменений т.к. диапазон заполнения положителен
Random rnd          = new Random(); 

for (int i = 0; i < length; i++) // заполним массив значениями от 0 до 9
    array[i] = rnd.Next(0,10);

for (int j = 0; j < length; j++) // проверим на положbтельные и отрицательные. Просуммируем.
{
    if(array[j] > 0) posVeluesSum += array[j];
    else if(array[j] < 0) negValuesSum += array[j];
}

Console.WriteLine($"Сумма положительных элементов массива равна {posVeluesSum}.\nСумма отрицательных элементов массива равна {negValuesSum}.");
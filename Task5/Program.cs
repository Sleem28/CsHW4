// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
int[]  mainArray      = new int[100];
int[]  multArray      = new int[50];
int    mainLength     = mainArray.Length;
int    multLength     = multArray.Length;  
int    reverseCounter = mainLength-1;
Random rnd            = new Random();

for (int i = 0; i < mainLength; i++) // Заполним массив случайными значениями
    mainArray[i] = rnd.Next(-1000,1000);

for (int j = 0; j < multLength; j++) // Умножим противоположные элементы, и сложим их в доп массив 
{
    multArray[j] = mainArray[j] * mainArray[reverseCounter];
    reverseCounter--;
}

foreach (var item in multArray) // Напечатаем доп массив
    Console.Write(item + " ");

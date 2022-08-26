// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] array = {1, 2, 3, 4, 5};
int [] arr = new int [array.Length];

for (int i = 0; i < array.Length; i++)
{
    arr[i] = array[i];
}
Console.WriteLine($"Исходный массив {string.Join (", ", array)}");
Console.WriteLine($"Новый массив {string.Join (", ", arr)}");
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// const int NUMBER = 2;
// int number = NUMBER;
// int size = (int)Math.Log2(number)+1;
// int[] array = new int[size];

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = number % 2;
//     number = number / 2;
// }


// void ReverceArray (int[] array)
// {
//     for (int i = 0; i <array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// ReverceArray(array);
// Console.WriteLine($"Число {NUMBER} в двоичной системе равно {string.Join ("", array)}");


Console.WriteLine ("Введите десятичное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
GetBinaryView(number);

void GetBinaryView(int num)
{
    if(num == 0) return;
    GetBinaryView (num / 2);
    Console.Write(num % 2);
}


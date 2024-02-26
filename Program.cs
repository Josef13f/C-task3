//Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.
// [5, 6, 8, 7, 3, 0] => 5 6 8 7 3 0

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[] { 5, 6, 8, 7, 3, 0 };
        PrintReverseArray(array, array.Length - 1);
    }

    static void PrintReverseArray(int[] array, int j)
    {
        if (j < 0) 
        {
            return;
        }

        Console.Write(array[j] + " "); 

        PrintReverseArray(array, j - 1); 
    }
}
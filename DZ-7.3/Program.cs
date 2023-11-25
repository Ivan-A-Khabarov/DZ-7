/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/

int[] array = {1, 2, 3, 4, 5};
PrintArrayElements(array, array.Length - 1);

void PrintArrayElements(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayElements(array, index - 1);
    }
}
Console.WriteLine();

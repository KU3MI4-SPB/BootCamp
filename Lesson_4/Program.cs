// int n = Random.Shared.Next(1000000);

// double s = 0;

// for (int n = 0; n < 15; n++)
// {
//     int count = 0;
//     int i = n;
//     while (i > 0)
//     {
//         count++;
//         s += i;
//         i = i / 2;
//     }
//     Console.WriteLine($"n:{n}  count:{count}");
// }


// <summary>
// Сортировка методом выбора
// </summary>
// <param name="collection">Исходный массив</param>
// <returns>Отсортированный массив массив</returns>

int[] SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}

var arr = new int[] { 9, 6, 0, 5, 7, 3, 1, 2};
Console.WriteLine(string.Join(" ", arr));
SortSelection(arr);
Console.WriteLine(string.Join(" ", arr));
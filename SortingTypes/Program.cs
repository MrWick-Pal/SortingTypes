﻿void SortSelection (int [] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection [j] < collection [i]) pos = j;
        }
        int temp = collection [i];
        collection [i] = collection [pos];
        collection [pos] = temp;
    }
}

int [] array = {7, 2, 3, 4, 5, 1, 2, 3 };

Console.WriteLine($"[{String.Join(',', array)}]");
SortSelection(array);
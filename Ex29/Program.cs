int[] GetArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}

int[] Array = new int[8];

for(int i = 0; i < Array.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

Array = GetArray (8, Array);


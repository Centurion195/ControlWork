string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateAndFillArray()
{
    int length = int.Parse(ReadInt("Введите длину массива: "));
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = ReadInt($"Введите значение #{i + 1}/{array.Length}: ");
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}\t");
    Console.WriteLine();
}

string[] EditArray(string[] array)
{
    int length = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) length++;
    string[] array2 = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}

Console.Clear();
string[] array = CreateAndFillArray();
PrintArray(array);
string[] array2 = EditArray(array);
PrintArray(array2);
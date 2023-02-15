string[] array = { "кто", "чтобы", "они", "когда", "хоть", "бы", "иногда", "и", "вот", "всегда" };
int symbols = 3;

string[] GetNewArray(string[] array)
{
    string[] result = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        string r = array[i];

        if (r.Length <= symbols) result[i] = r;
    }
    return result;
}

string[] FinalArray(string[] array)
{
    string str = string.Join(",", array.ToArray());

    string[] separatingString = { ",", " " };

    string[] arr = str.Split(separatingString, System.StringSplitOptions.RemoveEmptyEntries);

    string[] result = new string[arr.Length];

    if (arr.Length > 0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[i];
        }
    }
    else
    {
        Console.WriteLine("В начальном массиве нет элементов, удовлетворяющих условию задачи");
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array.Length == 1) Console.Write($"[{array[i]}]");

        else if (i == 0) Console.Write($"[{array[i]}, ");

        else if (i == array.Length - 1) Console.Write($"{array[i]}]");

        else Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

PrintArray(array);
Console.WriteLine($"Размерность исходного массива = {array.Length}");

string[] newArray = GetNewArray(array);

Console.WriteLine();

string[] a = FinalArray(newArray);

PrintArray(a);
Console.WriteLine($"Размерность нового массива = {a.Length}");
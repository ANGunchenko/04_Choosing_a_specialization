
Console.Clear();

string[] array = CreateArray();

Console.WriteLine();

Console.Write("Введённые значения: ");
PrintArray(array);

Console.WriteLine();

Console.Write("Обработанные значения: ");
PrintArray(FillNewArrayProcessedValues(array));

Console.ReadLine();

string[] CreateArray()
{
    int count = 0;
    string value = String.Empty;
    string[] secondArray = new string[30];

    Console.WriteLine($"Вводите не более 30 значений");
    Console.WriteLine();
    Console.WriteLine($"Введите 'end' чтобы завершить ввод значений");
    Console.WriteLine();

    for (count = 0; value != "end"; count++)
    {
        if (count > 29)
        {
            break;
        }

        value = InputValue($"Введите {count + 1}-ое значение ");

        if (value != "end")
        {
            secondArray[count] = value;
        }

    }

    string[] array = new string[count - 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = secondArray[i];
    }
    return array;
}

string[] FillNewArrayProcessedValues(string[] array)
{
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[index] = array[j];
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

string InputValue(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}

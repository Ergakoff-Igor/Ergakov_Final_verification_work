

string[] inputArray = InputArray();
Console.Write("Введите лимит длины элементов: ");
int Limit = int.Parse(Console.ReadLine()!);
string[] resultArray = FillArray(inputArray, Limit);
Console.WriteLine($" Изначальный массив: [{string.Join(", ", inputArray)}]");
Console.WriteLine($" Массив элементов, длина которых <= {Limit} -> [{string.Join(", ", resultArray)}]");

//Метод заполнения первоначального массива:
string[] InputArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine()!.Split(" ");
}

// Метод для определения длины итогового массива, чтобы не было пустых элементов:
int CountIndex(string[] input, int lim)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= lim)
        {
            count++;
        }
    }

    return count;
}

// Метод заполнения итогового массива элементами, удовлетворяющими некоторому условию:
string[] FillArray(string[] inputArr, int limit)
{
    string[] outputArr = new string[CountIndex(inputArr, limit)];
    for (int i = 0, j = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= limit)
        {
            outputArr[j] = inputArr[i];
            j++;
        }
    }
    return outputArr;
}

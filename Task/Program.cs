string[] InputArray = new string[4] {"hello", "2", "world", ":-)"};
string[] ResultArray = new string[InputArray.Length];
Console.WriteLine("Изначальный массив: ");
PrintArray(InputArray);

//Метод вывода массива:
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        if (i == array.Length-1) Console.Write($"{array[i]}] ");
    }
    Console.WriteLine();
}

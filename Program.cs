// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string [] arrayOne ;
Console.WriteLine("Введите через пробел массив строк");
    string text = Console.ReadLine();
    arrayOne = text.Split(' ');
    int size = arrayOne.Length;
Console.WriteLine("Исходный массив:");
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine("Новый массив, содержащий элементы, размер которых не более 3:");

if(GetSecondSize(arrayOne) == 0)   //Если нет элементов с 3 символами
{
    Console.WriteLine("Элементов, длина которых меньше 3 символов в данном массиве нет");
}
else
{
    string [] arrayTwo = NewArray(arrayOne);
    PrintArray(arrayTwo);
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSecondSize(string[] arr)    // Размер нового массива
{
     int SecondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= 3)
            {
            SecondSize ++;
            }
    }
    return SecondSize;
}

string[] NewArray(string[] arr)     // создание нового массива из первого
{
    string[] arrayTwo = new string[GetSecondSize(arrayOne)];
    for (int i = 0, j =0; i < size; i++)
    {
        if (arr[i].Length <= 3)
            {
            arrayTwo[j] = arr[i];
            j++;
            }
    }
    return arrayTwo;
}


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

string FindSumRows (int [,] value)
{
    int result = 0;
    int count = 1;
    for (int i = 0; i < value.GetLength (0); i++)
    {
        int sum = 0;
        for (int j = 0; j < value.GetLength(1); j++)
        {
            sum += value [i, j];
        }
        //Console.Write(sum + " ");
        if (i == 0)
        {
            result = sum;
            count = i + 1;
        }
        if (i > 0 && sum < result)
        {
            result = sum;
            count = i + 1;
        }
    }
    return "строка " + count.ToString();
}

Console.WriteLine("Input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of min");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of max");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateArray(m, n, minValue, maxValue);
ShowArray(myarray);
Console.WriteLine();
FindSumRows(myarray);
Console.WriteLine(FindSumRows(myarray));

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
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

void Sequence(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1)-1-k; j++)
            {
                if(array[i,j] < array[i,j+1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of min");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of max");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] myarray = CreateRandomArray(m, n, minValue, maxValue);
ShowArray(myarray);
Sequence(myarray);
Console.WriteLine();
ShowArray(myarray);


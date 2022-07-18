// Заполните спирально массив 4 на 4.

int a = 4;
int b = 4;

int[,] CreateArray()
{
    int[,] newArray = new int[a, b];

    int number = 1;
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            if (newArray[i, j] < 17)
            {
                newArray[i, j] = number;
                number++;
            }


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

int[,] Spiral(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)        //
        {
            array[0,0] = 1;
            array[0,1] = 2;
            array[0,2] = 3;
            array[0,3] = 4;

            array[1,3] = 5;
            array[2,3] = 6;
            array[3,3] = 7;

            array[3,2] = 8;
            array[3,1] = 9;
            array[3,0] = 10;

            array[2,0] = 11;
            array[1,0] = 12;

            array[1,1] = 13;
            array[1,2] = 14;

            array[2,2] = 15;

            array[2,1] = 16;
        }
    return array;
}

// int[,] Spiral(int[,] array)
// {
//     int SpiralNumber = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0 && j <= 3) // 1 строка
//             {
//                 SpiralNumber++;
//                 array[i, j] = SpiralNumber;
//             }
//             if (i > 0 && j == 3)      // 4 столбец
//             {
//                 SpiralNumber++;
//                 array[i, j] = SpiralNumber;
//             }
//             if (i == 3 && j < 3)     // 4 строка
//             {
//                 int temp = SpiralNumber + i - j + 1;
//                 array[i, j] = temp;
//             }
//             if (i > 0 && i < 3 && j == 0)              // 1 столбец
//             {
//                 int temp = SpiralNumber;
//                 temp = temp + 7;
//                 array[i, j] = temp;
//             }
//         }
//     return array;
// }


int[,] myarray = CreateArray();

ShowArray(myarray);
Spiral(myarray);
Console.WriteLine();
ShowArray(myarray);
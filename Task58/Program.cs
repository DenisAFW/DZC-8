// Заполните спирально массив 4 на 4.

int[,] CreateArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    int number = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            if (newArray[i, j] < rows * columns)
            {
                newArray[i, j] = number;
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


void Spiral(int[,] array)
{
    int CurrentNum = 1;
    int StopNum = array.GetLength(0) * array.GetLength(1);
    int PosRow = 0;
    int PosCol = 0;

    while (CurrentNum <= StopNum)
    {
        while (CurrentNum <= StopNum && PosCol < array.GetLength(1) && array[PosRow, PosCol] == 0)
            array[PosRow, PosCol++] = CurrentNum++;
        PosCol--; PosRow++;

        while (CurrentNum <= StopNum && PosRow < array.GetLength(0) && array[PosRow, PosCol] == 0)
            array[PosRow++, PosCol] = CurrentNum++;
        PosRow--; PosCol--;

        while (CurrentNum <= StopNum && PosCol >= 0 && array[PosRow, PosCol] == 0)
            array[PosRow, PosCol--] = CurrentNum++;
        PosRow--; PosCol++;

        while (CurrentNum <= StopNum && PosRow >= 0 && array[PosRow, PosCol] == 0)
            array[PosRow--, PosCol] = CurrentNum++;
        PosRow++; PosCol++;
        
    }
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateArray(a,b);

ShowArray(myarray);
Spiral(myarray);
Console.WriteLine();
ShowArray(myarray);





// int[,] Spiral(int[,] array)
// {
//     int number = 1;
//     for (int j = 0; j < array.GetLength(1); j++) array[0, j] = number++; // 1 строка
//     for (int i = 1; i < array.GetLength(0); i++) array[i, array.GetLength(1) - 1] = number++; // 4 столбец
//     for (int j = array.GetLength(1) - 2; j >= 0; j--) array[array.GetLength(0) - 1, j] = number++; // 4 строка
//     for (int i = array.GetLength(0) - 2; i > 0; i--) array[i, array.GetLength(0) - 4] = number++; // 1 столбец
//     for (int j = array.GetLength(1) - 3; j>0&& j<3;j++) array[array.GetLength(1)-3,j] = number++; // 2 строка
//     for (int j = array.GetLength(1) - 2; j<3 && j>0;j--) array[array.GetLength(1)-2,j] = number++;

//     return array;
// }


// int[,] Spiral(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)        //
//         {
//             array[0,0] = 1;
//             array[0,1] = 2;
//             array[0,2] = 3;
//             array[0,3] = 4;

//             array[1,3] = 5;
//             array[2,3] = 6;
//             array[3,3] = 7;

//             array[3,2] = 8;
//             array[3,1] = 9;
//             array[3,0] = 10;

//             array[2,0] = 11;
//             array[1,0] = 12;
// 0 1 2 3
//             array[1,1] = 13;
//             array[1,2] = 14;

//             array[2,2] = 15;

//             array[2,1] = 16;
//         }
//     return array;
// }
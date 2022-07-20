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
    int number = 1;
    for (int j = 0; j < array.GetLength(1); j++) array[0, j] = number++; // 1 строка
    for (int i = 1; i < array.GetLength(0); i++) array[i, array.GetLength(1) - 1] = number++; // 4 столбец
    for (int j = array.GetLength(1) - 2; j >= 0; j--) array[array.GetLength(0) - 1, j] = number++; // 4 строка
    for (int i = array.GetLength(0) - 2; i > 0; i--) array[i, array.GetLength(0) - 4] = number++; // 1 столбец
    for (int j = array.GetLength(1) - 3; j>0&& j<3;j++) array[array.GetLength(1)-3,j] = number++; // 2 строка
    for (int j = array.GetLength(1) - 2; j<3 && j>0;j--) array[array.GetLength(1)-2,j] = number++;

    return array;
}


int[,] myarray = CreateArray();

ShowArray(myarray);
Spiral(myarray);
Console.WriteLine();
ShowArray(myarray);


// int[,] Spiral2dArray(int a, int b)
// {
//     int[,] array = new int[a, b];

//     int start = 1;
//     int changeX = 0;
//     int changeY = 0;
//     int rememberY = 0;
//     int rememberX = 0;

//     while (start < a * b)
//     {
//         for (int side = 0; side < 4; side++)
//         {
//             if (side == 0)
//             {
//                 for (int y = 0; y < array.GetLength(1) - changeY; y++, rememberY++)
//                 {
//                     array[a + changeY, y] = start;
//                     start++;
//                 }
//             }

//             if (side == 1)
//             {
//                 for (int x = 0; x < array.GetLength(0) - changeX; x++,rememberX++)
//                 {
//                     array[x, rememberY] = start;
//                     start++;
//                 }
//             }

//             if (side == 2)
//             {
//                 for (int y = rememberY; y > 0 + changeY; y--, rememberY--)
//                 {
//                     array[rememberX, y - 1] = start;
//                     start++;
//                 }
//             }

//             if (side == 3)
//             {
//                 for (int x = rememberX; x > 0 + changeX; x--,rememberX--)
//                 {
//                     array[x - 1, rememberY] = start;
//                     start++;
//                 }
//             }

//             changeY++;
//             changeX++;

//         }
//     }
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
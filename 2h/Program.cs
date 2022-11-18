
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Введите количество строк и столбцов, так чтоб количество элементов было четное");
Console.ResetColor();
Console.WriteLine("Введите количество строк");
int rows;
while (!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите количество строк");
}

Console.WriteLine("Введите количество столбцов");
int columns;
while (!int.TryParse(Console.ReadLine()!, out columns) || columns <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.WriteLine("Введите количество столбцов");
}

if (rows * columns % 2 != 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Количество элементов в матрице не четное, перезапустите программу");
    Console.ResetColor();
    return;
}

int[,] matrix = new int[rows, columns];
var random = new Random();

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(-100, 101);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(12, 16);
            if (matr[i, j] == 100) Console.Write($"{matr[i, j]}     ");
            else if (matr[i, j] == -100) Console.Write($"{matr[i, j]}    ");

            else if (matr[i, j] < 100 && matr[i, j] >= 10) Console.Write($"{matr[i, j]}      ");

            else if (matr[i, j] > -100 && matr[i, j] <= -10) Console.Write($"{matr[i, j]}     ");

            else if (matr[i, j] > 0 && matr[i, j] <= 10) Console.Write($"{matr[i, j]}       ");

            else if (matr[i, j] >= -10 && matr[i, j] < 0) Console.Write($"{matr[i, j]}      ");

            else Console.Write($"{matr[i, j]}       ");

            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

void Sorted(int[,] matr)
{
    int[,] matrix2 = new int[1, rows * columns];
    int a = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix2[0, a] = matr[i, j];
            a++;
        }
    }

    // Console.WriteLine();
    // Console.WriteLine("Матрица переведенная в одномерный массив: ");
    // PrintArray(matrix2);

    int p = 0;
    int p1 = 0;

    int[,] matrix3 = matrix2;
    int[] arr = new int[matrix2.GetLength(1)];
    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        arr[i] = matrix2.GetLength(1);
    }

    for (int i = 0; i < matrix2.GetLength(1) / 2;)
    {
        p = random.Next(0, matrix2.GetLength(1));
        p1 = random.Next(0, matrix2.GetLength(1));

        int j;
        for (j = 0; j < matrix2.GetLength(1); j++)
        {
            if (p == p1) break;
            if (p == arr[j]) break;
            if (p1 == arr[j]) break;
        }
        if (j == matrix2.GetLength(1))
        {
            arr[i] = p;
            arr[matrix2.GetLength(1) - 1 - i] = p1;

            int temp = matrix2[0, p];
            matrix3[0, p] = matrix2[0, p1];
            matrix3[0, p1] = temp;

            i++;
        }
    }

    // Console.WriteLine("Перемешанный одномерный массив: ");
    // PrintArray(matrix3);
    // Console.WriteLine("Проверка на повторяемый индексы: ");
    // PrintArray2(arr);

    int a3 = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matrix2[0, a3];
            a3++;
        }
    }

    Console.WriteLine();
    Console.WriteLine("Перемешанная матрица: ");
    PrintArray(matr);
}

Console.WriteLine();
FillArray(matrix);
Console.WriteLine("Матрица: ");
PrintArray(matrix);
Sorted(matrix);
Console.WriteLine();

// void PrintArray2(int[] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         Console.ForegroundColor = (ConsoleColor)random.Next(12, 16);
//         if (matr[i] == 100) Console.Write($"{matr[i]}     ");
//         else if (matr[i] == -100) Console.Write($"{matr[i]}    ");

//         else if (matr[i] < 100 && matr[i] >= 10) Console.Write($"{matr[i]}      ");

//         else if (matr[i] > -100 && matr[i] <= -10) Console.Write($"{matr[i]}     ");

//         else if (matr[i] > 0 && matr[i] <= 10) Console.Write($"{matr[i]}       ");

//         else if (matr[i] >= -10 && matr[i] < 0) Console.Write($"{matr[i]}      ");

//         else Console.Write($"{matr[i]}       ");

//         Console.ResetColor();
//     }
// }

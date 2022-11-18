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

    for (int j = 0; j < matrix2.GetLength(1) - 1; j++)
    {
        for (int i = 0; i < matrix2.GetLength(1) - 1; i++)
        {
            if (matrix2[0, i] > matrix2[0, i + 1])
            {
                int temp = matrix2[0, i + 1];
                matrix2[0, i + 1] = matrix2[0, i];
                matrix2[0, i] = temp;
            }
        }
    }

    int a2 = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matrix2[0, a2];
            a2++;
        }
    }

    Console.WriteLine();
    Console.WriteLine("Отсортированнная матрица: ");
    PrintArray(matr);
}

Console.WriteLine();
FillArray(matrix);
Console.WriteLine("Матрица: ");
PrintArray(matrix);
Sorted(matrix);
Console.WriteLine();
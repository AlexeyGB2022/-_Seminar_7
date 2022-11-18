var random = new Random();
int [,] matrix = new int [random.Next(4, 6), random.Next(4, 6)];

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           matr[i, j] = random.Next(1, 25);
        } 
    }
}

void PrintArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(12, 16);
            if (matr[i, j]==100) Console.Write($"{matr[i, j]}     ");
            else if (matr[i, j]==-100) Console.Write($"{matr[i, j]}    ");

            else if (matr[i, j]<100 && matr[i, j]>=10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}    ");
            

            else if (matr[i, j]>-100 && matr[i, j]<=-10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}   ");
             

            else if (matr[i, j]>0 && matr[i, j]<=10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}     ");
            

            else if (matr[i, j]>=-10 && matr[i, j]<0 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}    ");
            

            else Console.Write($"{matr[i, j]}       ");

            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

void ArMeanColumn(int[,] matr)
{
    for (int j=0; j<matr.GetLength(1); j++)
    {
        double armean = 0;
        for (int i=0; i<matr.GetLength(0); i++)
        {
            armean = armean + matr[i, j];
        } 
        Console.Write($"{armean/matr.GetLength(0)}     ");
    } 
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца:");
ArMeanColumn(matrix);
Console.WriteLine();

Console.WriteLine("Введите количество строк");
int rows;
while (!int.TryParse(Console.ReadLine()!, out rows) || rows<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите количество строк");   
}

Console.WriteLine("Введите количество столбцов");
int columns;
while (!int.TryParse(Console.ReadLine()!, out columns) || columns<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите количество столбцов");   
}

double [,] matrix = new double [rows, columns];
var random = new Random();

void FillArray(double[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           matr[i, j] = random.NextDouble()*random.Next(-100, 101);
           matr[i, j] = Math.Round(matr[i, j], 1, MidpointRounding.AwayFromZero);
        } 
    }
}

void PrintArray(double[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(12, 16);
            if (matr[i, j]==100) Console.Write($"{matr[i, j]}   ");
            else if (matr[i, j]==-100) Console.Write($"{matr[i, j]}  ");

            else if (matr[i, j]<100 && matr[i, j]>=10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}      ");
            else if (matr[i, j]<100 && matr[i, j]>=10 && matr[i, j]*10%10!=0) Console.Write($"{matr[i, j]}    ");

            else if (matr[i, j]>-100 && matr[i, j]<=-10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}     ");
            else if (matr[i, j]>-100 && matr[i, j]<=-10 && matr[i, j]*10%10!=0) Console.Write($"{matr[i, j]}   ");  

            else if (matr[i, j]>0 && matr[i, j]<=10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}       ");
            else if (matr[i, j]>0 && matr[i, j]<=10 && matr[i, j]*10%10!=0) Console.Write($"{matr[i, j]}     ");

            else if (matr[i, j]>=-10 && matr[i, j]<0 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}      ");
            else if (matr[i, j]>=-10 && matr[i, j]<0 && matr[i, j]*10%10!=0) Console.Write($"{matr[i, j]}    ");

            else Console.Write($"{matr[i, j]}       ");

            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

    

Console.WriteLine("Введите искомое значение");
int number;
while (!int.TryParse(Console.ReadLine()!, out number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите искомое значение");   
}

var random = new Random();
int [,] matrix = new int [random.Next(4, 6), random.Next(4, 6)];

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           matr[i, j] = random.Next(1, 6);
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

            else if (matr[i, j]<100 && matr[i, j]>=10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}      ");
            

            else if (matr[i, j]>-100 && matr[i, j]<=-10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}     ");
             

            else if (matr[i, j]>0 && matr[i, j]<=10 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}       ");
            

            else if (matr[i, j]>=-10 && matr[i, j]<0 && matr[i, j]*10%10==0) Console.Write($"{matr[i, j]}      ");
            

            else Console.Write($"{matr[i, j]}       ");

            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

void SearchNumbers(int[,] matr, int numb)
{
    bool check = false;
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           if (matr[i, j] == numb)
           { 
            check = true;
            Console.WriteLine($"Искомое значение имеет индексы [{i};{j}]");
           }
        } 
    } 
    if (check==false) Console.WriteLine("В массиве нет искомого значения");
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SearchNumbers(matrix, number);

    

// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
void FillArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = Math.Round(new Random().NextDouble() *10, 3);
}
}
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void ReplacingSString(double[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
{
    double temp = matr[0,j];
    matr[0,j] = matr[(matr.GetLength(1))-1,j];
    matr[(matr.GetLength(1))-1,j]= temp;

}

}

int m =ReadInt("Введите количество строк: ");
int n =ReadInt("Введите количество столбцов: ");

double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReplacingSString(matrix);
PrintArray(matrix);



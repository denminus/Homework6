// Показать двумерный массив размером m×n заполненный вещественными числами
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

int m =ReadInt("Введите количество строк: ");
int n =ReadInt("Введите количество столбцов: ");

double[,] matrix = new double[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void PrintArray(int[,] matr)
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
void FillArray(int[,] matr)//Aₘₙ = m+n
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i,j] = i+j;
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


int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
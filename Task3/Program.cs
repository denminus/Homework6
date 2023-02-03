// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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
void FillArrayizm(int[,] matr)// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
int a=new Random().Next(1,10);
if (i%2==0 && j%2==0)
{
    a= a*a;
}

matr[i,j] = a;
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


FillArrayizm(matrix);

PrintArray(matrix);

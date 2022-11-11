// Найти произведение двух матриц
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(min, max);
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
int ReadIntegerMessage(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int k = 0; k < matrix2.GetLength(1); k++)
    {
        for(int i = 0; i < matrix1.GetLength(0); i++)
        {
            int p = 0;
            for(int j = 0; j < matrix1.GetLength(1); j++)
                p = p + matrix1[i, j] * matrix2[j, k];
            product[i, k] = p;
        }
    }
    return product;
}

int rows1 = ReadIntegerMessage("Введите количество строк в первой матрице: ");
int columns1 = ReadIntegerMessage("Введите количество столбцов в первой матрице: ");
int rows2 = ReadIntegerMessage("Введите количество строк во второй матрице: ");
int columns2 = ReadIntegerMessage("Введите количество столбцов во второй матрице: ");
int min = ReadIntegerMessage("Введите начало диапазона чисел матриц: ");
int max = ReadIntegerMessage("Введите конец диапазона чисел матриц: ");
int[,] first = CreateMatrix(rows1, columns1, min, max);
int[,] second = CreateMatrix(rows2, columns2, min, max);
Console.WriteLine("Первая матрица: ");
PrintMatrix(first);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(second);
if(columns1 == rows2)
{
    int[,] product = ProductMatrix(first, second);
    Console.WriteLine("Произведение матриц: ");
    PrintMatrix(product);
}
else
{
    Console.WriteLine("Такие матрицы невозможно умножить, количество столбцов первой не равняется количеству строк второй");
}

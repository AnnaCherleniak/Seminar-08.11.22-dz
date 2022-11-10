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


int rows = ReadIntegerMessage("Введите количество строк в матрице: ");
int columns = ReadIntegerMessage("Введите количество столбцов в матрице: ");
int min = ReadIntegerMessage("Введите начало диапазона чисел матрицы: ");
int max = ReadIntegerMessage("Введите конец диапазона чисел матрицы: ");
int[,] first = CreateMatrix(rows, columns, min, max);
int[,] second = CreateMatrix(rows, columns, min, max);
int[,] product = new int[rows, columns];
Console.WriteLine("Первая матрица: ");
PrintMatrix(first);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(second);
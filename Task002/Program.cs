//В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
int[] IndexMinElementMatrix(int[,] matrix)
{
    
    int[] index = new int[2];
    int min = matrix[0, 0];
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            if(matrix[i, j] < min)
            {
                min = matrix[i, j];
                index[0] = i;
                index[1] = j;
            }
    return index;
}
int[,] DeletionRow(int[,] matrix, int row)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; j < row; i++)
            newMatrix[i, j] = matrix[i, j];
        for(int i = row; i < newMatrix.GetLength(0); i++)
            newMatrix[i, j] = matrix[i + 1, j]; 
    }
    return newMatrix;
}
int[,] DeletionColumn(int[,] matrix, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
    for(int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < column; j++)
            newMatrix[i, j] = matrix[i, j];
        for(int j = column; j < newMatrix.GetLength(1); j++)
            newMatrix[i, j] = matrix[i, j + 1]; 
    }
    return newMatrix;
}

int rows = ReadIntegerMessage("Введите количество строк в матрице: ");
int columns = ReadIntegerMessage("Введите количество столбцов в матрице: ");
int min = ReadIntegerMessage("Введите начало диапазона чисел матрицы: ");
int max = ReadIntegerMessage("Введите конец диапазона чисел матрицы: ");
int[,] matrix = CreateMatrix(rows, columns, min, max);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(matrix);
int[] index = IndexMinElementMatrix(matrix);
int row = index[0];
int column = index[1];
int [,] newMatrix = DeletionRow(matrix, row);
newMatrix = DeletionColumn(newMatrix, column);
Console.WriteLine("Новая матрица: ");
PrintMatrix(newMatrix);
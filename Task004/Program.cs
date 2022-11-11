// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
void Pascal(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }
    for(int i = 2; i < matrix.GetLength(0); i++)
        for(int j = 1; j <= i; j++)
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
    
    //for(int i = 1; i < matrix.GetLength(0); i++)
    //{
      //  for(int j = n + 1; j < matrix.GetLength(1); j++)
        //{
          //  matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
        //}
    //}
}


int[,] matrix = new int[8, 8];
Pascal(matrix);
PrintMatrix(matrix);
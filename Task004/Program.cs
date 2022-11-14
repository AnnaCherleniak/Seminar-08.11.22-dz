// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
/*void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            if(matrix[i, j] != 0)
                Console.Write($"{matrix[i, j], -5} ");
        Console.WriteLine();
    }
}*/
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
//Console.WriteLine("Введите количество строк в треугольнике Паскаля: ");
//int rows = int.Parse(Console.ReadLine() ?? "0");
int rows = 8;
int[,] matrix = new int[rows, rows];
Pascal(matrix);
Console.WriteLine("Треугольник Паскаля: ");
//PrintMatrix(matrix);
int cellWidth = 3;
int col = cellWidth * rows;
for(int i = 0; i < rows; i ++)
{
    for(int j = 0; j <= i; j++)
    {
        Console.SetCursorPosition(col, i + 1);
        if(matrix[i, j] != 0)
            Console.Write($"{matrix[i, j], -2}");
        col += cellWidth * 2;
    }
    col = cellWidth * rows - cellWidth * (i + 1);
    Console.WriteLine();
}


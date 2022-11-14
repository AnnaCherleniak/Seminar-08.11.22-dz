// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
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

}
void PrintTrianglePascal(int[,] matrix)
{
    int cellWidth = 3;
    int rows = matrix.GetLength(0);
    int col = cellWidth * rows;
    for(int i = 0; i < rows; i ++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 4);
            if(matrix[i, j] != 0)
                Console.Write($"{matrix[i, j]}");
            col += cellWidth * 2;
        }
        col = cellWidth * rows - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в треугольнике Паскаля: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[rows, rows];
Pascal(matrix);
Console.WriteLine("Треугольник Паскаля: ");
PrintTrianglePascal(matrix);

//Сформировать трехмерный массив двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

int[,,] CreateMatrix(int i, int j, int k, int min, int max)
{
    int[,,] matrix= new int[i, j, k];
    Random random = new Random();
    for(i = 0; i < matrix.GetLength(0); i++)
        for(j = 0; j < matrix.GetLength(1); j++)
            for(k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = random.Next(min, max);
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            for(int k = 0; k < matrix.GetLength(2); k++)
                Console.WriteLine($"{i},{j},{k} = {matrix[i, j, k]}");    
}
Console.WriteLine("Введите начало диапазона чисел массива:");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите конец диапазона чисел массива:");
int max = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix = CreateMatrix(3, 3, 3, min, max);
Console.WriteLine("Элементы трехмерного массива: ");
PrintMatrix(matrix);
// // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
// // округлёнными до одного знака.
// // m = 3, n = 4.

// // 0,5  7    -2   -0,2
// // 1   -3,3   8   -9,9
// // 8    7,8  -7,1  9


 void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    double[,] numbers = new double[rows, columns];

   FillArray(numbers);
   PrintArray(numbers);

}

void FillArray(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-50, 50) + random.NextDouble();        }
    }
}
void PrintArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(numbers[i,j],1) +  " \t" );
        }
        Console.WriteLine();

    }
}
Zadacha47();


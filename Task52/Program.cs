// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        double rezult = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];

        }
        rezult = sum / rows;
        Console.WriteLine($" Среднее арифметическое {j+1} столбца = "+ Math.Round(rezult, 1) );

    }

}

    void FillArray(int[,] numbers)
    {
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = random.Next(0, 11);
            }
        }
    }
    void PrintArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();

        }
    }


Zadacha52();

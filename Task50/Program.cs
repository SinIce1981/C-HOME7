// Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

 void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

   FillArray(numbers);
   PrintArray(numbers);
   Console.WriteLine ("Введите индекс элемента массива в формате [i]");
   int indexI = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine ("Введите индекс элемента массива в формате [j]");
   int indexJ = Convert.ToInt32(Console.ReadLine());
   if (indexI<0 | indexI > numbers.GetLength(0)-1 | indexJ<0 | indexJ >  numbers.GetLength(1)-1)

   { 
    Console.WriteLine ($" {indexI}{indexJ} Такого элемента не существует");
   }
   else
   {
    Console.WriteLine (numbers[indexI,indexJ]);
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
Zadacha50();
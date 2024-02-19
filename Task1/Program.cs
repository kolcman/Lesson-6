// Task 1

showArray(CreateArray(3, 5));


int[,] CreateArray(int rowCount, int columsCount)
{
    int[,] table = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);
        }
    }
    return table;
}

void showArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            System.Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

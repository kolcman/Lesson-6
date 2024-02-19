// Task2

findNumbers(createMatrix(3,5));


void findInterestingNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (((matrix[i,j] / 1000) + ((matrix[i,j] / 100) % 10) + ((matrix[i,j] / 10) % 10) + (matrix[i,j] % 10)) % 2 == 0)
            {
                System.Console.Write($"{matrix[i,j]} ");
            }
        }
    }

}

int[,] createMatrix(int rowCount, int columCount)
{
    int[,] matrix = new int[rowCount, columCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 1001);
        }
    }
    return matrix;
}

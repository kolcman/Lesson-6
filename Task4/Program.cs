void Main()
{
    int[,] matrix = GenerateMatrix(3, 5, 0, 10);
    printMatrix(matrix);
    System.Console.WriteLine();

    changeMatrix(matrix);
    printMatrix(matrix);
}

void printMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void changeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
        }
    }

}

int[,] GenerateMatrix(int rowCount, int columCount, int leftRange, int rightRange)
{
    int[,] myMatrix = new int[rowCount, columCount];
    Random rand = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return myMatrix;
}

Main();
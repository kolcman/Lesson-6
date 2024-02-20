void Main()
{
    int[,] matrix = GenerateMatrix(5, 5, 0, 10);
    printMatrix(matrix);
    System.Console.WriteLine();
    System.Console.WriteLine(sumOnDiag(matrix));
}

int sumOnDiag(int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
        sum += matrix[i,i];

    return sum;    
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
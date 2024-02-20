void Main()
{
    int[,] matrix = GenerateMatrix(4, 4, 0, 10);
    printMatrix(matrix);
    System.Console.WriteLine();
    double[] averages = getRowAverage(matrix);
    printArray(averages);
}

void printArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] getRowAverage(int[,] matrix)
{
    double[] averageArray = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                temp += matrix[i,j];      
        }
        averageArray[i] = temp / matrix.GetLength(1);
    }
    return averageArray;
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
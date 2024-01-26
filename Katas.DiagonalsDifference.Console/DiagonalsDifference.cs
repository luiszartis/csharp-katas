namespace Katas.DiagonalsDifference.Console;

public static class DiagonalsDifference
{
    public static int Calculate(int[,] matrix)
    {
        if (!MatrixManager.IsSquare(matrix))
        {
            throw new Exception("Not a Matrix");
        }

        return Difference(matrix);
    }

    private static int Difference(int[,] matrix)
    {
        int firstOne = 0, secondOne = 0;
        var side = matrix.GetLength(0);
        for (var i = 0; i < side; i++)
        {
            firstOne += matrix[i, i];
            var mirrorIndex = side - (i + 1);
            secondOne += matrix[i, mirrorIndex];
        }

        return Math.Abs(firstOne - secondOne);
    }
}

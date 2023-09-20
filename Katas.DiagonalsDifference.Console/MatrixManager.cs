namespace Katas.DiagonalsDifference.Console;

public class MatrixManager
{
    private const int IntGap = 20;
    public static int[,] Create(int rows, int cols)
    {
        var rnd = new Random();
        var result = new int[rows, cols];
        for (var i = 0; i < rows; ++i)
        {
            for (var j = 0; j < cols; ++j)
            {
                result[i, j] = rnd.Next(IntGap);
            }
        }
        return result;
    }

    public static bool IsSquare(int[,] matrix)
    {
        return matrix.GetLength(0) == matrix.GetLength(1);
    }
}

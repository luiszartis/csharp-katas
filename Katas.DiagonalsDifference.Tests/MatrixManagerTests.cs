using FluentAssertions;
using Katas.DiagonalsDifference.Console;
using Xunit;

namespace Katas.DiagonalsDifference.Tests;

public class MatrixManagerTests
{
    [Theory]
    [InlineData(4, 5, false)]
    [InlineData(3, 3, true)]
    public void IsSquare_WhenPassedAllScenarios_ReturnsWhatIsExpected(int rows, int cols, bool expected)
    {
        // arrange
        var matrix = MatrixManager.Create(rows, cols);

        // act
        var result = MatrixManager.IsSquare(matrix);

        // assert
        result.Should().Be(expected);
    }
}

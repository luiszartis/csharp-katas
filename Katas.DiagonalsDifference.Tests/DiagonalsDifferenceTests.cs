using AutoFixture;
using FluentAssertions;
using Katas.DiagonalsDifference.Console;
using Xunit;

namespace Katas.DiagonalsDifference.Tests;

public class DiagonalsDifferenceTests
{
    private readonly Console.DiagonalsDifference _sut;

    public DiagonalsDifferenceTests()
    {
        IFixture fixture = new Fixture();
        _sut = fixture.Create<Console.DiagonalsDifference>();
    }

    [Fact]
    public void Calculate_WhenMatrixIsNotSquare_RaisesException()
    {
        // arrange
        const int rows = 7;
        const int cols = 4;
        var matrix = MatrixManager.Create(rows, cols);

        // act
        var action = () => Console.DiagonalsDifference.Calculate(matrix);

        // assert
        var ex = action.Should().Throw<Exception>();
        ex.WithMessage("Not a Matrix");
    }

    [Fact]
    public void Calculate_WhenMatrixIsFine_ReturnsPositive()
    {
        // arrange
        const int rows = 5;
        const int cols = 5;
        var matrix = MatrixManager.Create(rows, cols);

        // act
        var result = Console.DiagonalsDifference.Calculate(matrix);

        // assert
        result.Should().BePositive();
    }

    [Theory]
    [MemberData(nameof(MatrixData))]
    public void Calculate_WhenMatrixIsFine_ReturnsExactDifference(int[,] matrix, int expected)
    {
        // act
        var result = Console.DiagonalsDifference.Calculate(matrix);

        // assert
        result.Should().Be(expected);
    }

    public static TheoryData<int[,], int> MatrixData
    {
        get
        {
            var levelFourMatrix = new TheoryData<int[,], int>
            {
                {
                    new int[,]
                    {
                        { 1, 2, 3, 4, 8 },
                        { 6, 1, 4, 3, 10 },
                        { 4, 0, 2, 2, 9 },
                        { 4, 2, 0, 1, 5 },
                        { 7, 2, 9, 4, 1 },
                    },
                    16
                },
                {
                    new int[,]
                    {
                        { 1, 2, 3, 4 },
                        { 0, 1, 4, 3 },
                        { 4, 0, 2, 2 },
                        { 4, 2, 0, 1 },
                    },
                    7
                },
                {
                    new int[,]
                    {
                        { 1, 2, 3 },
                        { 0, 1, 4 },
                        { 4, 0, 2 },
                    },
                    4
                }
            };
            return levelFourMatrix;
        }
    }
}

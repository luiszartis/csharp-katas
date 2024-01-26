using System.Numerics;
using FluentAssertions;
using Xunit;

namespace Katas.SumBigIntegers.Tests;

public class SumIntegerTests
{
    [Fact]
    public void Sum_WhenSizeDifferentFromTheList_RaisesException()
    {
        // arrange
        var list = new List<BigInteger>() { 2, 4, 4 };

        // act
        var action = () =>  Console.SumBigIntegers.Sum(list, list.Count + 1);

        // assert
        var ex = action.Should().Throw<Exception>();
        ex.WithMessage("Stack over flow");
    }

    [Fact]
    public void Sum_WhenSizeIsSameAsList_ReturnSum()
    {
        // arrange
        var list = new List<BigInteger>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

        // act
        var result = Console.SumBigIntegers.Sum(list, list.Count);

        // assert
        result.Should().Be(list.Aggregate(BigInteger.Add));
        result.Should().Be(5000000015);
    }
}

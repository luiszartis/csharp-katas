using AutoFixture;
using FluentAssertions;
using Katas.SumIntegers.Console;
using Xunit;

namespace Katas.SumIntegers.Tests;

public class SumIntegerTests
{
    private readonly SumInteger _sut;

    public SumIntegerTests()
    {
        IFixture fixture = new Fixture();
        _sut = fixture.Create<SumInteger>();
    }

    [Fact]
    public void Sum_WhenSizeDifferentFromTheList_RaisesException()
    {
        // arrange
        var list = new List<int>() { 2, 4, 4 };

        // act
        var action = () =>  _sut.Sum(list, list.Count + 1);

        // assert
        var ex = action.Should().Throw<Exception>();
        ex.WithMessage("Stack over flow");
    }

    [Fact]
    public void Sum_WhenSizeIsSameAsList_ReturnSum()
    {
        // arrange
        var list = new List<int>() { 1, 2, 3 };

        // act
        var result = _sut.Sum(list, list.Count);

        // assert
        result.Should().Be(list.Sum());
    }
}

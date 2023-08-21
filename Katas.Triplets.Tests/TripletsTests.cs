using FluentAssertions;
using Xunit;

namespace Katas.Triplets.Tests;

public class TripletsTests
{
    private readonly Console.Triplets _sut = new();

    [Fact]
    public void Compare_WhenTheListHaveSameOneValues_ThenReturnZeroScore()
    {
        // arrange
        var bobList = (new [] { 1, 1, 1 }).ToList();
        var aliceList = (new [] { 1, 1, 1 }).ToList();

        // act
        var response = _sut.Compare(bobList, aliceList);

        // assert
        response.Count.Should().Be(2);
        response[0].Should().Be(0);
        response[1].Should().Be(0);
    }

    [Fact]
    public void Compare_WhenTheListsHaveDifferentValues_ThenReturnBobWins()
    {
        // arrange
        var bobList = (new [] { 2, 1, 1 }).ToList();
        var aliceList = (new [] { 1, 1, 1 }).ToList();

        // act
        var response = _sut.Compare(bobList, aliceList);

        // assert
        response.Count.Should().Be(2);
        response[0].Should().Be(1);
        response[1].Should().Be(0);
    }
    [Fact]
    public void Compare_WhenTheListsHaveDifferentValues_ThenReturnAliceWins()
    {
        // arrange
        var bobList = (new [] { 1, 1, 1 }).ToList();
        var aliceList = (new [] { 2, 1, 1 }).ToList();

        // act
        var response = _sut.Compare(bobList, aliceList);

        // assert
        response.Count.Should().Be(2);
        response[0].Should().Be(0);
        response[1].Should().Be(1);
    }

    [Fact]
    public void Compare_WhenTheListsHaveDifferentValues2_ThenReturnBobWins()
    {
        // arrange
        var bobList = (new [] { 2, 2, 2 }).ToList();
        var aliceList = (new [] { 1, 1, 1 }).ToList();

        // act
        var response = _sut.Compare(bobList, aliceList);

        // assert
        response.Count.Should().Be(2);
        response[0].Should().Be(3);
        response[1].Should().Be(0);
    }
}

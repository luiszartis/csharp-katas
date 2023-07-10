using AutoFixture;
using FluentAssertions;
using WebAPIClient.Model;
using Xunit;

namespace WebAPIClient.Tests;

public class CompareTripletsTests
{
    private readonly CompareTriplets _sut;

    public CompareTripletsTests()
    {
        IFixture fixture = new Fixture();
        _sut = fixture.Create<CompareTriplets>();
    }

    [Fact]
    public void Sum_ShouldReturnIntegerList()
    {
        var alice = new List<int>() { 1, 2, 3 };
        var bob = new List<int>() { 2, 2, 2 };
        var result = _sut.Compare(alice, bob);
        result.Should().BeAssignableTo(typeof(List<int>));
    }
    
    [Fact]
    public void Sum_ShouldReturnsOneAndOne()
    {
        var alice = new List<int>() { 1, 2, 3 };
        var bob = new List<int>() { 2, 2, 2 };
        var result = _sut.Compare(alice, bob);
        result.Should().BeEquivalentTo(new List<int>() { 1, 1 });
    }
    
    [Fact]
    public void Sum_ShouldReturnsTwoAndZero()
    {
        var alice = new List<int>() { 3, 2, 3 };
        var bob = new List<int>() { 2, 2, 2 };
        var result = _sut.Compare(alice, bob);
        result.Should().BeEquivalentTo(new List<int>() { 2, 0 });
    }
    
    [Fact]
    public void Sum_ShouldReturnsOneAndTwo()
    {
        var alice = new List<int>() { 3, 2, 3 };
        var bob = new List<int>() { 5, 8, 2 };
        var result = _sut.Compare(alice, bob);
        result.Should().BeEquivalentTo(new List<int>() { 1, 2 });
    }
    
    [Fact]
    public void Sum_ShouldRaiseException_WhenBadSizePassedAlong()
    {
        var alice = new List<int>() { 1, 2 };
        var bob = new List<int>() { 2, 2 };
        var action = () =>  _sut.Compare(alice, bob);
        var ex = action.Should().Throw<NotEqualCountException>();
        ex.WithMessage("Count of Triplets must be 3");
    }

    [Fact]
    public void Sum_ShouldRaiseException_WhenDifferentSizesPassedAlong()
    {
        var alice = new List<int>() { 1, 2, 3 };
        var bob = new List<int>() { 2, 2 };
        var action = () =>  _sut.Compare(alice, bob);
        var ex = action.Should().Throw<NotEqualCountException>();
        ex.WithMessage("Alice and Bob have different counts");
    }
}

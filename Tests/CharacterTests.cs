using AutoFixture;
using FluentAssertions;
using WebAPIClient.Model;
using Xunit;

namespace WebAPIClient.Tests;

public abstract class BaseTest
{
    protected readonly IFixture Fixture;
    protected ICharacter? Sut;

    protected BaseTest()
    {
        Fixture = new Fixture();
    }

    [Fact]
    public void TestOfLife()
    {
        Assert.True(true);
    }
}

public class WarriorTests : BaseTest
{
    public WarriorTests() : base()
    {
        Sut = Fixture.Build<Warrior>().Create();
    }

    [Fact]
    public async Task Move_ShouldReturnTrue()
    {
        var result = await Sut!.Move();
        result.Should().BeTrue();
    }

    [Fact]
    public async Task Attack_ShouldReturnTrue()
    {
        var result = await Sut!.Attack();
        result.Should().BeTrue();
    }
}

public class ArcherTests : BaseTest
{
    public ArcherTests() : base()
    {
        Sut = Fixture.Build<Archer>().Create();
    }
    
    [Fact]
    public async Task Move_ShouldReturnTrue()
    {
        var result = await Sut!.Attack();
        result.Should().BeFalse();
    }

    [Fact]
    public async Task Attack_ShouldReturnTrue()
    {
        var result = await Sut!.Attack();
        result.Should().BeFalse();
    }
}

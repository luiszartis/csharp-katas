using AutoFixture;
using FluentAssertions;
using WebAPIClient.Model;
using Xunit;

namespace WebAPIClient.Tests;

public class EnumCalculatorTests
{
    private readonly SampleEnum _sut;

    public EnumCalculatorTests()
    {
        IFixture fixture = new Fixture();
        _sut = fixture.Create<SampleEnum>();
    }

    [Fact]
    public void GetValuesFirstRecord_ShouldReturnInformation()
    {
        var result = _sut.GetValues();
        var first = result.First();
        const SampleEnumType information = SampleEnumType.Information;

        first.Value.Should().Be(1.ToString());
        first.Name.Should().Be("Information");
        first.Id.Should().Be(information);
    }

    [Fact]
    public void GetValuesLastRecord_ShouldReturnFreeTrial()
    {
        var result = _sut.GetValues();
        var last = result.Last();
        const SampleEnumType freeTrial = SampleEnumType.FreeTrial;

        last.Value.Should().Be(3.ToString());
        last.Name.Should().Be("Free Trial");
        last.Id.Should().Be(freeTrial);
    }
}

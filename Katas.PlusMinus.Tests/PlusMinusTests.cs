using FluentAssertions;
using Katas.PlusMinus.Console;
using Xunit;

namespace Katas.PlusMinus.Tests;

public class PlusMinusTests
{
    [Theory]
    [MemberData(nameof(IntArrayData))]
    public void CalculateRatios_ReturnsProperData_WhenProperArgs(int[] numbers, CalculationResponse expected)
    {
        // act
        var result = Console.PlusMinus.CalculateRatios(numbers);

        // assert
        result.Should().BeEquivalentTo(expected);

    }

    public static TheoryData<int[], CalculationResponse> IntArrayData
    {
        get
        {
            var array = new TheoryData<int[], CalculationResponse>
            {
                {
                    new[]
                    {
                        0, 0, 0
                    },
                    new CalculationResponse
                    {
                        Positives = 0,
                        Negatives = 0,
                        Zeroes = 1,
                    }
                },
                {
                    new[]
                    {
                        1, 0, 0, -5
                    },
                    new CalculationResponse
                    {
                        Positives = (decimal)0.25000,
                        Negatives = (decimal)0.25000,
                        Zeroes = (decimal)0.50000,
                    }
                }
            };
            return array;
        }
    }
}

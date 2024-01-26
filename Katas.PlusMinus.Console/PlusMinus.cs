using Katas.Core.Core.Extensions;

namespace Katas.PlusMinus.Console;

public static class PlusMinus
{
    public static CalculationResponse CalculateRatios(int[] integers)
    {
        var positiveOnes = 0;
        var negativeOnes = 0;
        var zeroOnes = 0;

        foreach (var num in integers)
        {
            switch (num)
            {
                case > 0:
                    positiveOnes ++ ;
                    break;
                case < 0:
                    negativeOnes ++;
                    break;
                default:
                    zeroOnes ++;
                    break;
            }
        }

        var count = integers.Length;
        var posRatio = CalculateRatios(positiveOnes, count);
        var negativeRatio = CalculateRatios(negativeOnes, count);
        var zeroRatio = CalculateRatios(zeroOnes, count);
        var response = BuildResponse(posRatio, negativeRatio, zeroRatio);

        return response;
    }

    private static decimal CalculateRatios(int ones, int count)
    {
        var result = (decimal)ones / count;
        return result.RoundedTo(Settings.RatioPrecisions);
    }

    private static CalculationResponse BuildResponse(decimal positiveRatio, decimal negativeRatio, decimal zeroRatio)
    {
        return new CalculationResponse
        {
            Positives = positiveRatio,
            Negatives = negativeRatio,
            Zeroes = zeroRatio,
        };
    }
}

namespace Katas.Core.Core.Extensions;

public static class DecimalExtensions
{
    public static decimal RoundedTo(this decimal value, int precision = 3)
    {
        return Math.Round(value, precision);
    }
}
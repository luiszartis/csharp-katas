using System.Numerics;

namespace Katas.SumBigIntegers.Console;

public static class SumBigIntegers
{
    public static BigInteger Sum(List<BigInteger> list, int size)
    {
        if (list.Count != size)
        {
            throw new Exception("Stack over flow");
        }
        return list.Aggregate(BigInteger.Add);
    }
}

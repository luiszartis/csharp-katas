using Katas.SumIntegers.Console;

namespace Katas.Console.Application;

public static class Program
{
    public static void Main(string[] args)
    {
        SumIntegers();
        CompareTriplets();
    }

    private static void SumIntegers()
    {
        var sum = new SumInteger();
        var result = sum.Sum(new List<int>() { 15, 22, 38 }, 3);
        System.Console.WriteLine(result);
    }

    private static void CompareTriplets()
    {
        var triplets = new Triplets.Console.Triplets();
        var alice = new List<int>() { 17, 28, 30 };
        var bob = new List<int>() { 99, 16, 8 };
        var result = triplets.Compare(alice, bob);
        var winner = result[0] > result[1] ? "alice" : "bob";
        winner = result[0] == result[1] ? "No one" : winner;
        System.Console.WriteLine(winner);
    }
}

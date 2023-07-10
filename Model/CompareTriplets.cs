using Xunit.Sdk;

namespace WebAPIClient.Model;

public class CompareTriplets
{
    public List<int> Compare(List<int> alice, List<int> bob)
    {
        if (alice.Count != bob.Count)
        {
            throw new NotEqualCountException("Alice and Bob have different counts");
        }
        if (alice.Count != 3 || bob.Count != 3)
        {
            throw new NotEqualCountException("Count of Triplets must be 3");
        }

        var result = new List<int> { 0 , 0 };
        for (int i = 0; i < alice.Count; i++)
        {
            if (alice[i] > bob[i]) result[0] += 1;
            if (alice[i] < bob[i]) result[1] += 1;
        }

        return result;
    }
}

public class NotEqualCountException : Exception
{
    public NotEqualCountException(string? message) : base(message) {}
}
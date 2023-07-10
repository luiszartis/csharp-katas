using Xunit.Sdk;

namespace WebAPIClient.Model;

public class Tdd
{
    public List<int> Compare(List<int> bob, List<int> alice)
    {
        var scoreBob = 0;
        var scoreAlice = 0;

        for (int i = 0; i < 3; i++)
        {
            var bobElement = bob[i];
            var aliceElement = alice[i];

            if (bobElement > aliceElement)
            {
                scoreBob ++;
            }

            if (bobElement < aliceElement)
            {
                scoreAlice ++;
            }
        }

        return new int[2] { scoreBob, scoreAlice }.ToList();
    }
}
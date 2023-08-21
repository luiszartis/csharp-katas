namespace Katas.SumIntegers.Console;

public class SumInteger
{
    public int Sum(List<int> list, int size)
    {
        if (list.Count != size)
        {
            throw new Exception("Stack over flow");
        }
        return list.Sum();
    }
}
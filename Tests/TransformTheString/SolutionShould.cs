using TransformTheString;
using Xunit;

namespace Tests.TransformTheString;

public class SolutionShould
{
    [Theory]
    [InlineData('a', 'b', 1)]
    [InlineData('b', 'a', 1)]
    [InlineData('h', 'v', 12)]
    [InlineData('r', 'm', 5)]
    [InlineData('a', 'z', 1)]
    public void CalculateDistance(char a, char b, int distance)
    {
        int len = Solution.CalculateDistance(a, b);

        Assert.Equal(len, distance);
    }
}

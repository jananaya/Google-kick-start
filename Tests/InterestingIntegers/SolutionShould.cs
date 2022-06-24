using InterestingIntegers;
using Xunit;

namespace Tests.InterestingIntegers;

public class SolutionShould
{
    [Theory]
    [InlineData(new long[] { 451, 453, 456, 459, 460 }, true)]
    [InlineData(new long[] { 452, 434, 454, 455, 457, 458, 459 }, false)]
    public void ValidateInterestingIntegers(long[] interestings, bool isInteresting)
    {
        bool isValid = true;

        foreach (var num in interestings)
        {
            isValid = isValid && Solution.IsInteresting(num);
        }

        Assert.Equal(isInteresting, isValid);
    }
}

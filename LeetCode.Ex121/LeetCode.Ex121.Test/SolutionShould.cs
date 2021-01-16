using Should;
using Xunit;

namespace LeetCode.Ex121.Test
{
    public class SolutionShould
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 1, 2 }, 1)]
        public void ShouldReturnCorrectResultWhenSolutionExists(int[] input, int expectedResult)
        {
            var solution = new Solution();
            var actualResult = solution.MaxProfit(input);

            actualResult.ShouldEqual(expectedResult);
        }
    }
}

using FluentAssertions;

namespace HashingProblems;

public class Intersection_of_Multiple_Arrays
{
    [Fact]
    public void Case1()
    {
        int[][] nums = new int[][]
        {
            new int[] { 3, 1, 2, 4, 5 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 3, 4, 5, 6 }
        };
        List<int> expectedAnswer = new List<int> { 3, 4 };

        var ans = Intersection(nums);

        ans.Should().BeEquivalentTo(expectedAnswer);
    }

    [Fact]
    public void Case2()
    {
        int[][] nums = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 }
        };
        List<int> expectedAnswer = new List<int>();

        var ans = Intersection(nums);

        ans.Should().BeEquivalentTo(expectedAnswer);
    }

    public IList<int> Intersection(int[][] nums)
    {
        Dictionary<int, int> charsCount = new Dictionary<int, int>();
        int n = nums.Count();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < nums[i].Count(); j++)
            {
                if (charsCount.TryGetValue(nums[i][j], out int curr))
                {
                    charsCount[nums[i][j]] = curr + 1;
                }
                else
                {
                    charsCount.Add(nums[i][j], 1);
                }
            }
        }
        List<int> ans = new List<int>();
        foreach (var item in charsCount)
        {
            if (item.Value >= n)
            {
                ans.Add(item.Key);
            }
        }

        ans.Sort();

        return ans;
    }
}
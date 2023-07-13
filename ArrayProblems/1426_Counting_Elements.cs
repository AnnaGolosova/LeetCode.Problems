using FluentAssertions;

namespace ArrayProblems;

public class Counting_Elements
{
    [Fact]
    public void Counting_Elements_Test()
    {
        int[] nums = new int[13] { 1, 1, 2, 3, 3, 5, 5, 6, 7, 7, 8, 8, 8 }; // Input array

        int ans = CountElements(nums);

        ans.Should().Be(8);
    }

    public int CountElements(int[] arr)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();

        foreach (int n in arr)
        {
            uniqueNumbers.Add(n);
        }

        int maxCount = 0;
        for (int i = 0; i < arr.Count(); i++)
        {
            if (uniqueNumbers.Contains(arr[i] + 1))
            {
                maxCount++;
            }
        }

        return maxCount;
    }
}
using Xunit;

public class ArrayTests
{
    [Fact]
    public void Test()
    {
        int[] nums = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }; // Input array
        int[] expectedNums = new int[10] { 0, 1, 2, 3, 4, 2, 2, 3, 3, 4 }; // The expected answer with correct length

        int k = RemoveDuplicates(nums); // Calls your implementation

        Assert.Equal(expectedNums.Length, k);
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }

    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Count();
        int[] uniquePositions = new int[n];
        uniquePositions[0] = 0;

        int lastPosition = 0;
        for (int i = 1; i < n; n++)
        {
            if (nums[i] != nums[uniquePositions[lastPosition]])
            {
                uniquePositions[++lastPosition] = i;
            }
        }

        for (int i = 0; i < lastPosition + 1; i++)
        {
            nums[i] = nums[uniquePositions[i]];
        }
        return lastPosition + 1;
    }
}
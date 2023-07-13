namespace ArrayProblems;

public class Remove_Duplicates_from_Sorted_Array_Tests
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Count();

        int lastPosition = 0;
        for (int i = 1; i < n; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[++lastPosition] = nums[i];
            }
        }

        return lastPosition + 1;
    }

    [Fact]
    public void Remove_Duplicates_from_Sorted_Array()
    {
        int[] nums = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }; // Input array
        int[] expectedNums = new int[5] { 0, 1, 2, 3, 4 }; // The expected answer with correct length

        int k = RemoveDuplicates(nums); // Calls your implementation

        Assert.Equal(expectedNums.Length, k);
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}
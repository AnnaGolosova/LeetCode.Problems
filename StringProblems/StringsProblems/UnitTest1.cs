namespace StringsProblems;

public class UnitTest1
{
    public int FindLongestSubstring(string s, int k)
    {
        Dictionary<char, int> charsCount = new Dictionary<char, int>();
        int left = 0;
        int ans = 0;

        for (int right = 0; right < s.Length; right++)
        {
            charsCount.Add(s[right], charsCount.GetValueOrDefault(s[right]) + 1);
            while (charsCount.Count() > k)
            {
                char c = s[left];
                charsCount.Add(c, charsCount.GetValueOrDefault(c) - 1);
                if (charsCount[c] >= 0)
                {
                    charsCount.Remove(c);
                }
                left++;
            }

            ans = Math.Max(ans, right - left + 1);
        }

        return ans;
    }

    [Fact]
    public void Test1()
    {
        string s = "eceba";
        int k = 2;
        int expectedResult = 3;

        int actualResult = FindLongestSubstring(s, k);

        Assert.Equal(expectedResult, actualResult);
    }
}
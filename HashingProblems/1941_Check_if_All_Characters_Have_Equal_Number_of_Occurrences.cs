using FluentAssertions;

namespace HashingProblems;

public class Check_if_All_Characters_Have_Equal_Number_of_Occurrences
{
    [Theory]
    [InlineData("abcabc", true)]
    [InlineData("aaabb", false)]
    [InlineData("a", true)]
    [InlineData("aaaaabbbbbccccc", true)]
    public void Cases(string s, bool expectedAnswer)
    {
        var ans = AreOccurrencesEqual(s);

        ans.Should().Be(expectedAnswer);
    }

    public bool AreOccurrencesEqual(string s)
    {
        if (s.Length == 1)
        {
            return true;
        }

        Dictionary<char,int> charsCount = new Dictionary<char,int>();
        foreach (var currChar in s)
        {
            if (charsCount.ContainsKey(currChar))
            {
                charsCount[currChar]++;
            } 
            else
            {
                charsCount.Add(currChar, 1);
            }
        }

        var discCount = charsCount.Select(_ => _.Value).Distinct().Count();

        return discCount == 1;
    }
}
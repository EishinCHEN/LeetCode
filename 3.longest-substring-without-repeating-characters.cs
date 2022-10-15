/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] sArray = s.ToCharArray();
        Console.WriteLine(sArray);
        int index = 0;
        foreach (var item in sArray)
        {
            sArray.Check(item, index+1);
        }
    }

    public void Check(this char[] array, string ch, int index)
    {
        int i = Array.IndexOf(array, ch);
    }
}
// @lc code=end


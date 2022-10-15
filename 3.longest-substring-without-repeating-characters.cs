/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] sArray = s.ToCharArray();
        int index = 0;
        
        for(int index = 0; index <= sArray.Length; index++)
        {
            if(sArray.Check(item, index) == sArray.Length)
            {

            }
        }
    }

    public int Check(this char[] array, string ch, int index)
    {
        int i = Array.LastIndexOf( array, array[index]);
        if(index != i )
        {
            return array.Length;
        }
    }
}
// @lc code=end


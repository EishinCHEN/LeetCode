/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        bool result = false;
        if( x >= 0 && x <= 9)
        {
            result = true;            
        }
        else if( x > 0 )
        {
            char[] num = x.ToString().ToCharArray();

            int helf = num.Length / 2 ;

            string leftString = string.Join("", num.Take(helf));
            char[] right = (num.Length % 2 == 0) ? num.Skip(helf).ToArray() : num.Skip(helf+1).ToArray();
            Array.Reverse(right);
            string rightString = string.Join("", right).ToString();

            result = (leftString == rightString) ? true : false;
        }    
        return result;    
    }
}
// @lc code=end


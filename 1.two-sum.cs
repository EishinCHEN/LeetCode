/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new List<int>();
        int index = 0;
        foreach (var n in nums)
        {
            var plusNum = target - n;
            var plusIdx = Array.IndexOf(nums, plusNum, index+1);

            if(plusIdx == -1)
            {
                index++;
                continue;
            }
            else
            {
                result.Add(index);
                result.Add(plusIdx);

                if(result.Count == 2 )
                {
                    break;
                }
                else
                {
                    index++;
                };
            }
        }
        return result.ToArray();
    }
}
// @lc code=end


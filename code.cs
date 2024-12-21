public class Solution {
    public int MajorityElement(int[] nums) {
        int freq = 0, ans = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(freq == 0) // if freq = 0, that means that all the previous elements can's be the answer
            {
                ans = nums[i]; // so let ans = current element
            }
            if(ans == nums[i]) // is current elemet is same as ans, than freq++
            {
                freq++;
            } else {
                freq --; // if not, than reduce the freq
            }
        }
        return ans;
    }
}

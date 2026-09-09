public class Solution {
    public bool hasDuplicate(int[] nums) {
        int numLen = nums.Length;
        if (numLen <= 1) return false;
        HashSet<int> dupeCheck = new HashSet<int>{};
        for (int i = 0; i <= numLen - 1; i++){
            if (!dupeCheck.Add(nums[i])) return true;
        }
        return false;
    }
}
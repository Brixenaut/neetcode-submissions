public class Solution {
    public bool hasDuplicate(int[] nums) {
        int numLen = nums.Length;
        if (numLen <= 1) return false;
        HashSet<int> dupeCheck = new HashSet<int>{};
        foreach (int i in nums) {
            if (!dupeCheck.Add(i)) return true;
        }
        return false;
    }
}
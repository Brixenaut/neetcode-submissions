public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 1) return false;
        HashSet<int> dc = new HashSet<int>{};
        foreach (int i in nums) {
            if (!dc.Add(i)) return true;
        }
        return false;
    }
}
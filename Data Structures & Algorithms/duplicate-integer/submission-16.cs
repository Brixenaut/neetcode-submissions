public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dc = new();
        foreach (int i in nums) {
            if (!dc.Add(i)) return true;
        }
        return false;
    }
}
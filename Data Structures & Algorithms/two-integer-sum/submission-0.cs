public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> known = new();
        for (int i = 0; i <= nums.Length; i++){
            int searchNum = target - nums[i];
            if (known.ContainsKey(searchNum)) {
                return new int[] {known[searchNum], i};
            }
            known[nums[i]] = i;
        }
        return nums;
    } 
}
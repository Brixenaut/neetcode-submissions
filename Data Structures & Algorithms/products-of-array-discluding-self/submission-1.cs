public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        List<int> zeroes = new List<int>();
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] != 0) product *= nums[i];
            else zeroes.Add(i);
        }

        int[] final = new int[nums.Length];
        if (zeroes.Count > 1) {
                return new int[nums.Length];
            }
        if (zeroes.Count == 1) {
            final[zeroes[0]] = product;
            return final;
        }
        for (int j = 0; j < nums.Length; j++){
            final[j] = product / nums[j];
        }
        return final;
    }
}

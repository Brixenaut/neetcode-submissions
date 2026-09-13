public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numFreqs = new();
        foreach (int i in nums){
            if (!numFreqs.ContainsKey(i)){
                numFreqs[i] = 0;
            }
            numFreqs[i]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        
        foreach (var num in numFreqs){
            if (buckets[num.Value] == null) {
                buckets[num.Value] = new List<int>();
            }
            buckets[num.Value].Add(num.Key);
        }

        int[] finale = new int[k];
        int index = 0;

        for (int i = buckets.Length - 1; i >= 0 && index < k; i--) {
            if (buckets[i] == null) {
                continue;
            }
            
            foreach (int num in buckets[i]) {
                finale[index] = num;
                index++;
                
                if (index == k) {
                    return finale;
                }
            }
        }

        return finale;
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        // 1. Quick length optimization
        if (s.Length != t.Length) return false;

        // 2. Convert to char arrays and sort them
        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);

        // 3. Compare the sorted collections for structural equality
        return sArr.SequenceEqual(tArr);
    }
}

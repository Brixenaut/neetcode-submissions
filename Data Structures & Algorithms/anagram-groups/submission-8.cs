public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> sortAnns = new();
        for (int i = 0; i < strs.Length; i++){
            char[] strArr = strs[i].ToArray();
            Array.Sort(strArr);
            string keyStr = string.Join(",", strArr);
            if(!sortAnns.ContainsKey(keyStr)){
                sortAnns[keyStr] = new List<string>();
                sortAnns[keyStr].Add(strs[i]);  
            } 
            else {
                sortAnns[keyStr].Add(strs[i]);  
            }
        }
        return new List<List<string>>(sortAnns.Values);
    }
}
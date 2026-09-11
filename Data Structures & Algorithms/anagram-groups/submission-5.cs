public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> sortedAnns = new();
        foreach (string str in strs){
            char[] annCheck = new char[26];
            foreach (char c in str){
                annCheck[c - 'a']++;
            }
            string freqString = new string(annCheck);
            if(!sortedAnns.ContainsKey(freqString)){
                sortedAnns[freqString] = new List<string>();
                sortedAnns[freqString].Add(str);
            }
            else {
                sortedAnns[freqString].Add(str);
            }
        }
        return new List<List<string>>(sortedAnns.Values);
    }
}

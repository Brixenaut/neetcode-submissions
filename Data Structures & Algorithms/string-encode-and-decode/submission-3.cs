public class Solution {

    public string Encode(IList<string> strs) {
        // Fix 1: Check if the count is 0, then return a unique marker
        if (strs.Count == 0){
            return "\u00fe";
        }
        string encoded = string.Join("\u00ff", strs);
        return encoded;
    }

    public List<string> Decode(string s) {
        // Fix 2: If it matches the marker, return the empty list
        if (s == "\u00fe"){
            return new List<string>();
        }
        List<string> decoded = new List<string>(s.Split("\u00ff"));
        return decoded;
   }
}


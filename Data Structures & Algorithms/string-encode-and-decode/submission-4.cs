public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0){
            return "\u00fe";
        }
        string encoded = string.Join("\u00ff", strs);
        return encoded;
    }

    public List<string> Decode(string s) {
        if (s == "\u00fe"){
            return new List<string>();
        }
        List<string> decoded = new List<string>(s.Split("\u00ff"));
        return decoded;
   }
}


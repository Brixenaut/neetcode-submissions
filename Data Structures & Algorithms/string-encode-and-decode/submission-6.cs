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

// There are four methods in the industry on how to solve this problem, each with tradeoffs that are not perfected for any option, so if an interviewer pushes back wanting a "better" solution, make them define what "better" means.

/*
Name of methodology | Data Usage | Time Complexity | Chance to Error
--------------------------------------------------------------------
Fixed Buffering     |   High     |      Low        |    Low
Rarity Tag          |   Medium   |      Low        |    Low
Count + Tag         |   Low      |      Low        |    Medium
Escape Stuffing     |   Low      |      Medium     |    Low
*/
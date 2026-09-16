public class Solution {
    public bool IsAnagram(string s, string t) {
        var sorteds = new string(s.OrderBy(c => c).ToArray());
        var sortedt = new string(t.OrderBy(c => c).ToArray());
        return sorteds == sortedt;
    }
}

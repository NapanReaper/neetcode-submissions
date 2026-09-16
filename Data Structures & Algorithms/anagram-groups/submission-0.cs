public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            string key = new string(str.OrderBy(c => c).ToArray());

            if (!dict.ContainsKey(key))
                dict[key] = new List<string>();

            dict[key].Add(str);
        }

        return dict.Values.Cast<List<string>>().ToList();
    }
}

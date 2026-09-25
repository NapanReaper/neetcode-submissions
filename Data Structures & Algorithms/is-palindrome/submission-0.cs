public class Solution {
    public bool IsPalindrome(string s) {
        string trimString = "";

        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                trimString += c;
            }
        }
        var t = trimString.ToLower();
         var n = t.Length;
        var result = true;
        for (int i = 0; i < n / 2; i++) {
            if (t[i] != t[n - i - 1]) {
                result = false;
            }
        }
        return result;
    }
}

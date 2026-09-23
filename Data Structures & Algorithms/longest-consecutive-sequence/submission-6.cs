public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        if (nums.Length == 1) {
            return 1;
        }
        var sorted = nums.OrderBy(x => x).ToHashSet().ToList();
        var results = new int[sorted.Count];
        var result = 1;
        for (int i = 0; i < sorted.Count - 1; i++) {
            if (sorted[i + 1] - sorted[i] == 1) {
                result++;
                results[i] = result;
            } else if (sorted[i + 1] - sorted[i] != 1 && i == sorted.Count - 1) {
                results[i] = result;
                break;
            } else if (sorted[i + 1] - sorted[i] != 1) {
                result = 1;
                results[i] = result;
            }
        }
        var maxConsecutive = results.Max();
        if (maxConsecutive > 0) {
            return results.Max();
        } else {
            return 1;
        }
    }
}

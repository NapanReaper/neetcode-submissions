public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach (var num in nums) {
            set.Add(num);
        }
        return nums.Length != set.Count;
    }
}
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!dict.ContainsKey(num))
                dict[num] = 0;

            dict[num]++;
        }

        return dict.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}

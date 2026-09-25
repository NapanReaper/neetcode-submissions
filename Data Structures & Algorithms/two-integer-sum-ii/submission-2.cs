public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var result = new int[2];
        var l = 0;
        var r = numbers.Length - 1;
        while (l < r) {
            if (numbers[l] + numbers[r] == target) {
                return new int[] { l + 1, r + 1 };
            } else if (numbers[l] + numbers[r] > target) {
                r--;
            } else {
                l++;
            }
        }
        return new int[2];
    }
}

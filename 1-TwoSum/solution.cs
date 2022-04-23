// https://leetcode.com/problems/two-sum/

// BF solution
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length - 1; ++i) {
            for (int j = i + 1; j < nums.Length; ++j)
                if (nums[i] + nums[j] == target)
                    return new int[]{i, j};
        }
        return new int[]{-1, -1};
    }
}

// Optimal solution
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i) {
            int expect = target - nums[i];
            if (dict.ContainsKey(expect))
                return new int[]{dict[expect], i};
            dict[nums[i]] = i;
        }
        return new int[]{-1, -1};
    }
}
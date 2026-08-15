public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] output = new int[n];

        int[] prefix = new int[n];
        int[] postfix = new int[n];

        prefix[0] = 1;
        for (var i = 1; i < n; i++) {
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        postfix[n-1] = 1;
        for (var i = n - 2; i >= 0; i--) {
            postfix[i] = postfix[i+1] * nums[i+1];
        }

        for (var i = 0; i < n; i++) {
            output[i] = prefix[i] * postfix[i];
        }
        return output;
    }
}

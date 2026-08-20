public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> data = [];

        foreach (var n in nums) {
            data.Add(n);
        }

        int length = 0;
        foreach (var i in data) {
            if (!data.Contains(i-1)) {
                int current = i;
                int currentLength = 1;

                while (data.Contains(current +1)) {
                    current++;
                    currentLength++;
                }

                if (length < currentLength) {
                    length = currentLength;
                }
            }
        }
        return length;
    }
}

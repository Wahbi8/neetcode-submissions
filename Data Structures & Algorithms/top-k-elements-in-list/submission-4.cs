public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>[] data = new List<int>[nums.Length + 1];
        Dictionary<int,int> dataCount = [];
        List<int> res = [];

        foreach (var i in nums) {
            if (dataCount.ContainsKey(i)) {
                dataCount[i]++;
            } else {
                dataCount[i] = 1;
            }
        }

        foreach(var count in dataCount) {
            if (data[count.Value] == null)
            {
                data[count.Value] = new List<int>();
            }

            data[count.Value].Add(count.Key);
        }

        for ( var i = data.Length - 1; i > 0; i--) {
            if (data[i] == null)
                continue;   
            
            foreach (var d in data[i]) {
                res.Add(d);

                if (res.Count == k) {
                    return res.ToArray();
                }
            }
        }  

        return res.ToArray();
    }
}

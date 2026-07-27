public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,int> set = [];
        List<List<string>> res = [];
        int i = 0;

        foreach (var s in strs) {
            var sum = new int[26];

            foreach (var c in s) {
                sum[c - 'a']++;
            }

            var key = string.Join(",", sum);

            if (set.ContainsKey(key))
            {
                res[set[key]].Add(s);
            }
            else
            {
                set[key] = res.Count;
                res.Add([s]);
            }
        }

        return res;
    }
}

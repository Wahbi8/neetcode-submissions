public class Solution {

    public string Encode(IList<string> strs) {
        string encode = string.Empty;
		foreach(var str in strs) {
			encode = encode + str.Length.ToString() + "#" + str;
		}
		return encode;
    }

    public List<string> Decode(string s) {
		List<string> decode = [];
		int i = 0;
		while (i < s.Length) {
			int j = i;
			while (s[j] != '#') {
				j++;
			}

			int length = int.Parse(s[i..j]);

			decode.Add(s[(j+1)..(j + 1 + length)]);

			i = j + 1 + length;
		}
		return decode;
   }
}

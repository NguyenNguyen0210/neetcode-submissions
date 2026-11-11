public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new();
        int l = 0, r = 0;
        int maxLen = 0;

        while (r < s.Length) {
            if (!hs.Add(s[r])) {
                while (hs.Contains(s[r])) {
                    hs.Remove(s[l]);
                    l++;
                }
                hs.Add(s[r]);
            }

            maxLen = Math.Max(maxLen, hs.Count); 
            r++;
        }

        return maxLen;
    }
}
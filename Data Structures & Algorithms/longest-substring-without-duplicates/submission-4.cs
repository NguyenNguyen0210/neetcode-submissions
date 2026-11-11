public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new();
        int res = 0;
        int l = 0;
        for(int r = 0;r<s.Length;r++){

            while(!hs.Add(s[r])){
                hs.Remove(s[l]);
                l++;
            }
            res = Math.Max(res,r - l + 1);
        }
        return res;
    }
}

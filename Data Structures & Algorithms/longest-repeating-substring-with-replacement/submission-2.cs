public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int res = 0;
        int l = 0;
        int maxfreq = 0;
        for(int r = 0;r<s.Length;r++){
            freq[s[r] - 'A']++;
            maxfreq = Math.Max(maxfreq,freq[s[r] - 'A']);
            while((r - l + 1) - maxfreq > k){
                freq[s[l] - 'A']--;
                l++;
            }
            res = Math.Max(res,r - l + 1);
        }
        return res;
    }
}

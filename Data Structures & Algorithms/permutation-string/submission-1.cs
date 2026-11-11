public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] freq1 = new int[26];
        foreach(char c in s1){
            freq1[c - 'a']++;
        }
        int[] freq2 = new int[26];
        int l = 0;
        for(int r = 0;r<s2.Length;r++){
            freq2[s2[r] - 'a']++;
            while(r - l + 1 == s1.Length){
                if(freq1.SequenceEqual(freq2)) return true;
                freq2[s2[l] - 'a']--;
                l++;
            }
        }
        return false;
    }
}

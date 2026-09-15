public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] sortS = new int[26];
        int[] sortT = new int[26];
        for(int i = 0;i<s.Length;i++){
            sortS[s[i] - 'a']++;
            sortT[t[i] - 'a']++;
        }
        for(int i = 0;i<26;i++){
            if(sortS[i] != sortT[i]) return false;
        }
        return true;
    }
}

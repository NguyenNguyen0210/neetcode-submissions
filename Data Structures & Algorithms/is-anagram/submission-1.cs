public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] numberOfs = new int[26]; 
        int[] numberOft = new int[26];
        for(int i = 0;i<s.Length;i++){
            numberOfs[(int)s[i] - 'a']++;
            numberOft[(int)t[i] - 'a']++;
        }
        for(int i = 0;i<26;i++){
            if(numberOfs[i] != numberOft[i]) return false;
        }
        return true;
    }
}

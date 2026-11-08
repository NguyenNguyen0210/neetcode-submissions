public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] countS = new int[26];
        foreach(char i in s){
            countS[(int)i - 'a']++;
        }
        int[] countT = new int[26];
        foreach(char i in t){
            countT[(int)i - 'a']++;
        }

        for(int i = 0;i<26;i++){
            if(countS[i] != countT[i]) return false;
        }
        return true;
    }
}

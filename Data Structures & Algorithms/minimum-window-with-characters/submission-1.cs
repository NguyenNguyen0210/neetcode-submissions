public class Solution {
    public string MinWindow(string s, string t) {
        int[] CountS = new int[128];
        int[] CountT = new int[128];
        foreach(char c in t) {
            CountT[c]++;
        }
        int l = 0;
        int startAt = 0;
        int size = int.MaxValue;
        for(int r = 0;r<s.Length;r++){
            CountS[s[r]]++;
            while(IsValid(CountT,CountS)){
                if(r - l + 1 < size){
                    size = r - l + 1;
                    startAt = l;
                }
                CountS[s[l]]--;
                l++;
            }
        }
        return size == int.MaxValue ? "": s.Substring(startAt,size);

    }
    private bool IsValid(int[] countT, int[] countS) {
        for (int i = 0; i < 128; i++) {
            if (countS[i] < countT[i]) return false;
        }
        return true;
    }
}

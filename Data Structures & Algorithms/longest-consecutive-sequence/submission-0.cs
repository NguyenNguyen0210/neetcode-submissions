public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>(nums);
        int res = 0;

        foreach(int num in hs){
            if(!hs.Contains(num - 1)){
                int length = 1;
                while(hs.Contains(num+length)){
                    length++;
                }
                res = Math.Max(length,res);
            }
        }
        return res;
    }
}

public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hs = new HashSet<int>();
        foreach(int i in nums){
            if(!hs.Add(i)) return true;
        }
        return false;
    }
}
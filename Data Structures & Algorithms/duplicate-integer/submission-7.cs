public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new();
        foreach(int i in nums){
            if(!hs.Add(i)) return true;
        }
        return false;
    }
}
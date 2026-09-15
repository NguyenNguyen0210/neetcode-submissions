public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new();
        foreach(int item in nums){
            if(!hs.Add(item)){
                return true;
            }
        }
        return false;
    }
}
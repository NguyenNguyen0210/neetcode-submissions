public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dict = new();
        foreach(int i in nums){
            if(!dict.Add(i)) return true;
        }
        return false;
    }
}
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();
        for(int i = 0;i<nums.Length;i++){
            int expect = target - nums[i];
            if(dict.ContainsKey(expect)){
                return [dict[expect],i];
            }
            dict.Add(nums[i],i);
        }
        return [0,0];
    }
}

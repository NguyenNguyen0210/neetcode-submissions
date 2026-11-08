public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         Dictionary<int,int> dict = new();
        for(int i = 0;i<nums.Length;i++){
            int val = target - nums[i];

            if(dict.TryGetValue(val,out int x)){
                return [x,i];
            }

            dict[nums[i]] = i;
        }
        return [0,0];
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        foreach(int i in nums){
            dict[i] = dict.GetValueOrDefault(i) + 1;
        }
        var res = dict.OrderByDescending(p => p.Value).Take(k).Select(p => p.Key).ToArray();
        return res;
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] prefix = new int[n];
        int[] suffix = new int[n];
        int[] product = new int[n];
        suffix[n-1] = 1;
        prefix[0] = 1;
        for(int i = 1; i<n;i++){
            prefix[i] = prefix[i-1] * nums[i-1];
        }
        for(int i = n-2; i>=0;i--){
            suffix[i] = suffix[i+1] * nums[i+1];
        }
        for(int i = 0; i<n;i++){
            product[i] = prefix[i] * suffix[i];
        }
        return product;
    }
}

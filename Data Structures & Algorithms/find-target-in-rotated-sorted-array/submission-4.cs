public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (nums[m] == target) return m;
            
            // Xác định nửa bên trái [l..m] đang tăng dần
            if (nums[l] <= nums[m]) {
                if (nums[l] <= target && target < nums[m]) {
                    r = m - 1;
                } else {
                    l = m + 1;
                }
            } 
            // Ngược lại, nửa bên phải [m..r] đang tăng dần
            else {
                if (nums[m] < target && target <= nums[r]) {
                    l = m + 1;
                } else {
                    r = m - 1;
                }
            }
        }
        return -1;
    }
}
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new();
        int l = 0, r = 0;
        int maxLen = 0;

        while (r < s.Length) {
            // TryGetValue vừa kiểm tra tồn tại, vừa lấy ra index cũ x trong 1 bước
            if (dict.TryGetValue(s[r], out int x)) {
                // Nhảy qua vị trí trùng cũ (x + 1), dùng Math.Max để l không bao giờ bị lùi
                l = Math.Max(l, x + 1);
            }
            
            // Cập nhật vị trí mới nhất của ký tự s[r]
            dict[s[r]] = r;

            // Độ dài cửa sổ từ l đến r là (r - l + 1)
            maxLen = Math.Max(maxLen, r - l + 1); 
            r++;
        }

        return maxLen;
    }
}
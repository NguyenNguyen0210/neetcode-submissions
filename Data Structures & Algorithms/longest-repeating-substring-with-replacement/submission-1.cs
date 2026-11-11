public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26]; // Đếm tần suất các chữ cái từ 'A' đến 'Z'
        int l = 0;
        int maxFreq = 0; // Tần suất lớn nhất của 1 ký tự trong cửa sổ
        int res = 0;

        for (int r = 0; r < s.Length; r++) {
            // BƯỚC 1: Đưa s[r] vào cửa sổ và cập nhật tần suất lớn nhất
            count[s[r] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[r] - 'A']);

            // BƯỚC 2: Chừng nào cửa sổ VI PHẠM điều kiện (số ký tự cần sửa > k) -> Thu hẹp l++
            while ((r - l + 1) - maxFreq > k) {
                count[s[l] - 'A']--;
                l++;
            }

            // BƯỚC 3: Cửa sổ hợp lệ -> Cập nhật độ dài dài nhất (ngoài while)
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
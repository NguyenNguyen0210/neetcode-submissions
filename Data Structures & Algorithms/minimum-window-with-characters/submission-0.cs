public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";

        // Dùng mảng 128 phần tử để đếm tần suất ký tự ASCII thay cho HashSet
        int[] countT = new int[128];
        int[] countS = new int[128];

        foreach (char c in t) {
            countT[c]++;
        }

        int l = 0;
        int minLen = int.MaxValue;
        int startIndex = 0; // Lưu lại vị trí bắt đầu của cửa sổ ngắn nhất

        for (int r = 0; r < s.Length; r++) {
            // BƯỚC 1: Mở rộng biên phải, thêm s[r] vào cửa sổ
            countS[s[r]]++;

            // BƯỚC 2: Chừng nào cửa sổ ĐANG ĐỦ mọi ký tự của t (Mẫu 3)
            while (IsValid(countT, countS)) {
                // Cập nhật kỷ lục NGẮN NHẤT ngay BÊN TRONG vòng while
                if (r - l + 1 < minLen) {
                    minLen = r - l + 1;
                    startIndex = l;
                }

                // BƯỚC 3: Thử thu hẹp biên trái xem cửa sổ còn đủ ký tự không
                countS[s[l]]--;
                l++;
            }
        }

        // Nếu minLen vẫn là int.MaxValue tức là không tìm được cửa sổ nào
        return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);
    }

    // Kiểm tra xem cửa sổ S đã có đủ số lượng của mọi ký tự trong T chưa
    private bool IsValid(int[] countT, int[] countS) {
        for (int i = 0; i < 128; i++) {
            if (countS[i] < countT[i]) return false;
        }
        return true;
    }
}
public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder builder = new StringBuilder();
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                builder.Append(char.ToLower(c));
            }
        }
        string newStr = builder.ToString();
        return newStr == new string(newStr.Reverse().ToArray());
    }
}
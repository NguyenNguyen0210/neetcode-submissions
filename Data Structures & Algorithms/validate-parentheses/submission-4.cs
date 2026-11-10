public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 1) return false;
        Dictionary<char,char> dict = new();
        dict['['] = ']';
        dict['{'] = '}';
        dict['('] = ')';

        Stack<char> st = new();
        for(int i = 0;i<s.Length;i++){
            if(s[i] == '[' || s[i] == '{' || s[i] == '('){
                st.Push(s[i]);
            }
            else{
                if(st.Count == 0) return false;
                char p = st.Pop();
                if(s[i] != dict[p]) return false;
            }
        }
        if(st.Count != 0) return false;
        return true;
    }
}

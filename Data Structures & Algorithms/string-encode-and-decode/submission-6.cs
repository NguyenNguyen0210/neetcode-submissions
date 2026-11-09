public class Solution {

    public string Encode(IList<string> strs) {
        string s = "";
        foreach(string c in strs){
            s = s + c + "π";
        }
        return s;
    }

    public List<string> Decode(string s) {
        List<string> strs = new();
        int start = 0;
        for(int i = 0;i<s.Length;i++){
            if(s[i] == 'π'){
                strs.Add(s.Substring(start,i - start));
                start = i+1;
            }
        }
        return strs;
   }
}

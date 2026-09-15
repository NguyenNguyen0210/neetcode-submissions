public class Solution {

    public string Encode(IList<string> strs) {
        string re = "";
        foreach(string s in strs){
            re+=s+'π';
        }
        return re;
    }

    public List<string> Decode(string s) {
        List<string> re = new();
        int index = 0;
        for(int i = 0;i<s.Length;i++){
            if(s[i] == 'π'){
                re.Add(s.Substring(index,i-index));
                index = i+1;
            }
        }
        return re;
   }
}

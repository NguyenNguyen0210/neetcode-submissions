public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        string[] sortString = new string[strs.Length];
        for(int i =0;i<strs.Length;i++){
            sortString[i] = string.Concat(strs[i].OrderBy(c => c));
        }
        Dictionary<string,List<string>> dict = new();
        for(int i = 0;i<strs.Length;i++){
            if(!dict.ContainsKey(sortString[i])){
                dict[sortString[i]] = new List<string>(){strs[i]};
                continue;
            }
            dict[sortString[i]].Add(strs[i]);

        }
        List<List<string>> res = new();
        foreach (var sublist in dict.Values)
        {
            res.Add(sublist); 
        }
        return res;
    }
}

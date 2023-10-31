public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();               

            for(int i = 0; i < strs.Length; i++)
            {
                var temp = strs[i].ToCharArray();    
                Array.Sort(temp);
                var str = new string(temp);

                if(!dict.ContainsKey(str))
                {
                    dict[str] = new List<string>();                    
                }
                dict[str].Add(strs[i]);
            }             

            return dict.Values.ToList();
    }
}

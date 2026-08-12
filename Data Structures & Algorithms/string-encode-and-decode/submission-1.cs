public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0){
            return "";
        }

        StringBuilder result = new StringBuilder();

        foreach(string str in strs){
            result.Append(str.Length).Append("#").Append(str);
        }

        return result.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length == 0) return new List<string>();

        List<string> result = new List<string>();

        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int size = int.Parse(s.Substring(i, j - i));
            j++;
            result.Add(s.Substring(j, size));
            i = j + size;
        }
        return result;
   }
}

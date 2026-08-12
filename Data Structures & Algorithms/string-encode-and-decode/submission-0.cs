public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) return "";

        List<int> sizes = new List<int>();
        StringBuilder builder = new StringBuilder();

        foreach(string str in strs){
            sizes.Add(str.Length);
        }
        foreach(int size in sizes){
            builder.Append(size).Append(",");
        }
        builder.Append("#");
        foreach(string str in strs){
            builder.Append(str);
        }
        return builder.ToString();
    }

    public List<string> Decode(string s) {
        if (s.Length == 0) {
            return new List<string>();
        }
        List<int> sizes = new List<int>();
        List<string> result = new List<string>();

        int i = 0;
        while(s[i] != '#'){
            int j = i;
            while(s[j] != ','){
                j++;
            }
            sizes.Add(int.Parse(s.Substring(i, j - i)));
            i = j + 1;
        }
        i++;
        foreach(int size in sizes){
            result.Add(s.Substring(i, size));
            i += size;
        }
        return result;
   }
}

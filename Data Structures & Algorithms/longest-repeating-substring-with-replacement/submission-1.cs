public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> freq = new Dictionary<char,int>();
        int result = 0;
        int l = 0;
        int maxfreq = 0;

        for (int r = 0; r < s.Length; r++){
            if(freq.ContainsKey(s[r])){
                freq[s[r]]++;
            } else {
                freq[s[r]] = 1;
            }
            maxfreq = Math.Max(maxfreq, freq[s[r]]);

            while((r - l + 1) - maxfreq > k){
                freq[s[l]]--;
                l++;
            }

            result = Math.Max(result, r - l + 1);
        }        

        return result;
    }
}

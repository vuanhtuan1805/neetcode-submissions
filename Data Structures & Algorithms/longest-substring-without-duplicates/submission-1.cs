public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> unique = new HashSet<char>();
        int result = 0;
        int left = 0;
        for (int i = 0; i < s.Length; i++){
            while(unique.Contains(s[i])){
                unique.Remove(s[left]);
                left++;
            }
            unique.Add(s[i]);
            result = Math.Max(result, i - left + 1);
        }
        return result;
    }
}

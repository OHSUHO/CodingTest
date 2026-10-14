public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int asc = (int)c;
            if(asc < 'A')
            {
                answer += ' ';
                continue;
            }
            if(asc >= 'A' && asc < 'Z'+1)
            {
                if(asc+n >= 'A'+26)
                {
                     answer += (char)(asc+n-26);
                }
                else{
                    answer += (char)(asc+n);
                }
            }
            else{
                if(asc+n >= 'a'+26)
                {
                     answer += (char)(asc+n-26);
                }
                else{
                    answer += (char)(asc+n);
                }
            }
        }
        
        return answer;
    }
}
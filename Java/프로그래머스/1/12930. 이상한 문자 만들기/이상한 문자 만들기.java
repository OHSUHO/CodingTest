class Solution {
    public String solution(String s) {
        String answer = "";
        StringBuilder sb = new StringBuilder();
        int index = 0;
        for(char c : s.toCharArray())
        {
            if(c == ' '){
                answer += c;
                index = 0;
            }
            else{
                if(index % 2 == 0)
                {
                    answer += Character.toUpperCase(c);
                    index++;
                }else{
                    answer += Character.toLowerCase(c);
                    index++;
                }
            }
        }
        
        
        return answer;
    }
}
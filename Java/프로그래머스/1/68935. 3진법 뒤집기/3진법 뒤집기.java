class Solution {
    public int solution(int n) {
        int answer = 0;
        String first= "";
        
        // n이 1억 이하 => 3진법의 자릿수가 최대 9자리이다.
        for(int i =0; i < 17; i++)
        {
            if(n%3 == 0)
            {
                first += "0";
            }
            else if(n%3 == 1)
            {
                first += "1";
            }
            else
            {
              first+= "2";  
            }
            
            if(n < 3)
            {
                break;
            }
            n /= 3;
            
        }
        
        
        int currentValue = 1;
        for(int i =first.length()-1; i >= 0 ; i--)
        {
           answer += currentValue * Character.getNumericValue(first.charAt(i));
           currentValue *= 3; 
        }
        
        
        return answer;
    }
}
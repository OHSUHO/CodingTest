using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int repeatNum = 2;
        while(repeatNum<=1000000)
        {
            if( (n%repeatNum) == 1) 
            {   answer = repeatNum;
                break;
            }
            
            repeatNum++;
        }
        
        
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int paintedSection = -1;
        int answer = 0;
        for(int i=0; i<section.Length; i++)
        {   
            if(paintedSection>=section[i])
            {
                continue;    
            }
            else
            {
            paintedSection = m + section[i] -1;     
            answer += 1;
            }
            
        }
        
        
        return answer;
    }
}
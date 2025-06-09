using System;

public class Solution 
{
    public int solution(string t, string p) 
    {
        int answer = 0;
        string[] partialString = new string[t.Length - (p.Length-1)];
        for(int i = 0; i < partialString.Length; i++)
        {
            partialString[i] = t.Substring(i,p.Length);
        }
        for(int i = 0; i < partialString.Length; i++)
        {
         
            if(long.Parse(p) >= long.Parse(partialString[i]))
            {
                answer++;
            }
            
        }    
        return answer;
    }
    
}


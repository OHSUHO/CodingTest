using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        Dictionary<char,int> dic_skip = new Dictionary<char,int>();
        
        for(int i= 0 ; i < skip.Length; i++)
        {
            dic_skip.Add(skip[i],i);
        }
        
       
        
        
        for(int i=0 ; i < s.Length ;i ++)
        {
            int skipInIndex = index;
            char key ='a';
            for(int j=1; j<skipInIndex+1; j++)
            {   
                key = ((int)s[i]+j) > 'z' ? (char)((int)s[i]+j-26) : (char)((int)s[i]+j) ;
                key = (int)key > 'z' ? (char)((int)key-26) : key;
             if (dic_skip.ContainsKey(key))
             {  
                skipInIndex++;
                continue;
             }   
             else
             {
                continue;   
             }
            }
            answer += key;
            
        }
        
        
        
        
        return answer;
    }
}
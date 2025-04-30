using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        Dictionary<char,int> key = new Dictionary<char,int>();
        
        int[] answer = new int[targets.Length] ;
        
        foreach(var keymaps in keymap)
        {
            for(int i=0; i < keymaps.Length; i++)
            {
                if(key.ContainsKey(keymaps[i]))
                {
                    if(key[keymaps[i]]>i+1)
                    {
                        key[keymaps[i]] = i+1;   
                    }
                }
                else
                {
                    key.Add(keymaps[i],i+1);
                    
                }
            }
        }
       
        int index=0;
        foreach(var t in targets)
        { 

           
            for(int i=0; i<t.Length;i++)
            {
                if(key.ContainsKey(t[i]))
                {
                    answer[index] += key[t[i]];
                }
                else
                {
                    answer[index] = -1;
                    break;
                }
                
            }
            index++;
            
        }

        
        
        
        
        
        return answer;
    }
}
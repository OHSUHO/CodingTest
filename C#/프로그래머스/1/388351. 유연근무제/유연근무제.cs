using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        int index = 0;
        
        foreach(int t in schedules)
        {
            bool isCorrect = true;
            
            int hour = t/100;
            int minute = t%100;
            
            int ru = (minute+10)/60;
            minute = (minute + 10)%60;
            
            hour += ru ;
            
            for(int i = 0; i<7;i++)
            {
                
                if((hour*100)+minute<timelogs[index,i])
                {   Console.WriteLine($"{hour*100+minute} : {timelogs[index,i]} : {hour+minute<timelogs[index,i]}");
                    
                 if((startday+i)%7==6 || (startday+i)%7==0 ) continue;
                    
                 isCorrect = false;
                 break;   
                    
                }
                
            }
            
            index++;
            if(isCorrect) answer++;
        }
        
        return answer;
    }
}
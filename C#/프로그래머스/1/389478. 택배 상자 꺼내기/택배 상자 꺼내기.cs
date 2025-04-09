using System;

public class Solution {
    public int solution(int n, int w, int num) {
        int answer;
        int y = ((num-1)/w)+1 ; 
        int x = ((num-1) % w);
        int raw;
        int top_y = ((n-1)/w)+1;
        
        if(y%2 == 0)
        {
            raw = w - x;
            
        }
        else
        {
            raw = x + 1;
        }
        
        int topBox = (top_y-1) * w ; 
       
        if(top_y%2 ==0)
        {
            topBox += (w+1)-raw;
        }
        else
        {
            topBox+=raw ; 
        }
         
        answer = top_y - y;
        
        if(topBox<=n){
            answer++;
            
        }
        return answer;
        
        
        
         }

    }


    
    //y가 홀 수 일때는 x가 정방향으로 놓이고 
    //y가 짝 수 일때는 x가 역방향으로 놓인다. 중요한듯?
using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        int i=1;
         
        if(common[i]-common[i-1] == common[i+1]-common[i])
            answer = common[0]+(common[i]-common[i-1])*(common.GetLength(0));
        else answer = common[common.GetLength(0)-1]*(common[i+1]/common[i]);
        return answer;
    }
}
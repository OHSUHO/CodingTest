using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int cIndex1,cIndex2,gIndex;
         string answer = "";
        cIndex1 = 0;
        cIndex2 = 0;
        gIndex = 0;
        while(gIndex!=goal.Length){
        if(cards1[cIndex1].Equals(goal[gIndex])){
            if(cIndex1 < cards1.Length-1)cIndex1++; gIndex++;}
        else if(cards2[cIndex2].Equals(goal[gIndex])){if(cIndex2 < cards2.Length-1)cIndex2++; gIndex++;}
        else { answer = "No"; return answer;}}

            answer = "Yes";
        return answer;
    }
}
public class Solution {
    public string solution(int num) {
        string answer = "";
        string[] answerStr = new string[2]{"Even","Odd"};
        if(num%2 == 0){
            answer =  answerStr[0];
        }
        else{
            answer = answerStr[1];
        }
        
        return answer;
    }
}
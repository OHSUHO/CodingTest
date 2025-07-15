using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for(int i = 1; i <= n; i*=10)
        {
            int j = i*10;
            int temp = n/j;
            temp  = n - temp * j - answer;
            temp /= i;
            answer += temp;
        }
        return answer;
    }
}
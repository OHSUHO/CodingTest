using System.Collections.Generic;

public class Solution {
    public int[] solution(long n) 
    {
        List<int> tempList = new List<int>();
        
        while (n > 0)
        {
            tempList.Add((int)(n % 10)); // 마지막 자리
            n /= 10; // 숫자 줄이기
        }

        return tempList.ToArray();
    }
}
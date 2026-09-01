class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        /*
        약수 어떻게 구할 까? 
        1부터 자기 자신까지 +1 하면서 %n 했을 때 값이 0 이면 약수임. ㅇㅋ
        */
        
        for(int i = left; i <= right; i++)
        {
            int divisorCount = 0;
            for(int n=1; n <= i; n++)
            {
                if(i%n == 0)
                {
                    divisorCount++;
                }
            }
            if(divisorCount%2==0)
            {
                answer += i;
            }
            else
            {
                answer -= i;
            }
            
        }
        return answer;
    }
}
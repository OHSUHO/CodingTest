class Solution {
    public long solution(int price, int money, int count) {
        long answer = -1;
        //그냥 count 횟수 만큼 반복하면 될 듯
        long currentPrice = price;
        long currentMoney = money;
        while(count-->0)
        {

            currentMoney -= currentPrice;
            currentPrice += price;
        }
        
        answer = Math.max(-currentMoney,0);
        
        return answer;
    }
}
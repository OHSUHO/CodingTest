using System;

public class Solution {
    public int solution(int[] cards) {
        // 가장 큰 점수를 얻을 수 있는 경우의 수?
        // 상자 그룹들 중에서 가장 큰 그룹 두 개를 골라서 곱하면 된다.
        
        // 그렇다면, 문제는 이렇게 풀 수 있을 것.
        // 1. 상자 그룹을 나눈다.
        // 1-1. 상자 그룹은 어떻게 나누지?
        // 카드의 배열의 길이와 같은 하나의 배열을 또 만들자.
        // 그리고, 해당 배열을 모두 0으로 초기화를 하자.
        // 1번 상자 그룹에 해당하면, 1로 값을 변경하자.
        // 2번 상자 그룹에 해당하면, 2로 값을 변경하자.
        // 더 나은 방법이 있을까? 해당방법은 결국 상자그룹을 나눌 때, 다시한번 배열순회가 필요하다.
        // 근데 배열순회는 사실 별로 복잡도가 안커서 괜찮을듯..ok
        
        // 2. 상자 그룹중에서 가장 큰 상자 그룹 두 개를 찾는다.
        // 3. 곱한 수를 answer에 넣어서 리턴한다.
        
        // 의문 1) 여러 개의 상자 그룹들은 항상 고정적으로 나뉘는가?
        // => 상자를 여는 순서에 따라서 그룹이 바뀔 수 있을 까?
        /*답은? no / why?) 항상 상자들의 안에 있는 카드들은 같은 상자그룹을 거치게 되어있다. 왜냐하면,
        같은 상자그룹에 속하는 상자들은 항상 서로를 지목하고 있기 때문에 같은 상자그룹에 속하면 어느 상자를 먼저 여는지에 
        상관없이 같은 그룹을 갖게 된다.*/
        int answer = 0;
        int[] boxesArray = ClassifyBox(cards);
        int[] countBox = new int[boxesArray[cards.Length]];
        for(int i = 0; i < boxesArray.Length-1; i++)
        {
            countBox[boxesArray[i]-1]++;
        }
        Array.Sort(countBox);
        answer=countBox[countBox.Length-1] * countBox[countBox.Length-2];
        
        
        return answer;
    }
    
    
    public int[] ClassifyBox(int[] cards)
    {
        int[] groupOfBox = new int[cards.Length+1];
        int groupNumber = 1;
        for(int i=0; i < cards.Length; i++)
        {
            int startIndx = i;
            if(groupOfBox[cards[startIndx]-1]==0)
            {
                while(groupOfBox[cards[startIndx]-1]==0)
                {
                    groupOfBox[cards[startIndx]-1] = groupNumber;
                    startIndx = cards[startIndx]-1;
                }
                groupNumber++;
                
            }
        }
        // 박스 그룹이 몇 개가 나왔는 지를 배열의 마지막에 넣어 출력
        groupOfBox[cards.Length] = groupNumber;
        
        return groupOfBox;
        
    }
        
        
        
        
        
}
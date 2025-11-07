using System.Collections.Generic;
using System;
//더 많은 선물을 줬으면 선물을 받는다. 그게 아니면 선물지수가 높으면 선물을 받는다.
//선물을 준 친구 공백 선물을 받은친구 => gifts

public class Solution {
    public int solution(string[] friends, string[] gifts) {
        int answer = 0;
        //다음 달에 가장 많은 선물을 받을 사람의 선물의 수
        //기프트배열을 통해서 선물지수를 먼저 계산한다.
        //친구 수 최대 50, 기프트는 최대 10000
        //하나의 인원에 대해서 기프트를 순회 > friends를 반복해서 받을 선물 개수 저장
        //50 * 10000 = 500,000번, 선물 지수 계산까지 510,000번 충분히 가능
        Dictionary<string,int> giftsIndex = new Dictionary<string,int>();
        for(int i=0; i < friends.Length; i++)
        {
            giftsIndex.Add(friends[i],0);
        }
        
        
        for(int i=0; i < gifts.Length; i++)
        {
            string[] giftsArrSplit = gifts[i].Split(" ");
            //준 사람 추가
            if(giftsIndex.ContainsKey(giftsArrSplit[0]))
            {
                giftsIndex[giftsArrSplit[0]] +=1;
            }
            else
            {
                giftsIndex.Add(giftsArrSplit[0],1);
            }
            
            //받은사람 추가
            if(giftsIndex.ContainsKey(giftsArrSplit[1]))
            {
                giftsIndex[giftsArrSplit[1]] -=1;
            }
            else
            {
                giftsIndex.Add(giftsArrSplit[1],-1);
            }
        }
        
        //선물개수 계산
        for(int i=0; i < friends.Length; i++)
        {
            string myName = friends[i];
            int gift = 0;
            Dictionary<string,int> giveAndTake = new Dictionary<string,int>();
            
            for(int j=0; j < gifts.Length; j++)
            {
                string[] giftsSplit = gifts[j].Split(" ");
                if(giftsSplit[0].Equals(myName))
                {
                    //선물 줬으면 +1, 받았으면 -1 => 이후 양수면 선물 받을 예정이고 음수면 줄 예정
                    if(giveAndTake.ContainsKey(giftsSplit[1]))
                    {
                         giveAndTake[giftsSplit[1]] +=1;
                    
                    }
                    else
                    {
                        giveAndTake.Add(giftsSplit[1],1);
                    }
                }
                
                if(giftsSplit[1].Equals(myName))
                {
                    //선물 줬으면 +1, 받았으면 -1 => 이후 양수면 선물 받을 예정이고 음수면 줄 예정
                    if(giveAndTake.ContainsKey(giftsSplit[0]))
                    {
                         giveAndTake[giftsSplit[0]] -=1;
                    
                    }
                    else
                    {
                        giveAndTake.Add(giftsSplit[0],-1);
                    }
                }

            }
 
            //다음 달 받을 선물 개수 계산
            for(int k=0; k<friends.Length; k++)
            {
                if(friends[k].Equals(myName)) continue;
                
                if(giveAndTake.ContainsKey(friends[k]))
                {
                    if(giveAndTake[friends[k]]>0) 
                    {
                        gift++;
                    }
                        
                    else if(giveAndTake[friends[k]]==0)
                    {
                       if(giftsIndex[myName] > giftsIndex[friends[k]]) {gift++;}
                    }
                }
                          
                else
                {
                    if(giftsIndex[myName] > giftsIndex[friends[k]]) {gift++;}
                }
            }
            
            if(gift>answer)
            {
                answer = gift;
            }
            
        }
        


        
        
        
        
        return answer;
    }
}
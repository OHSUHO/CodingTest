using System;
using System.Collections.Generic;


public class Solution {
    public int solution(int[,] points, int[,] routes) {
        
        //문제 이해완료
        //시간복잡도 괜찮은가?
        // => 최대 100개의 포인트, 100대의 로봇 존재. 10000까지 늘어남.
        // 만약 최대 경로로 뺑뺑이 돌 시 10000 x 100으로 1,000,000초(배열길이) 까지 늘어날 수 있음.
        
        // 시간복잡도를 가장 최소로 만들려면 어떻게 해야하는가?
        // 단순히 0초~최대 1,000,000초까지 각각의 로봇을 비교한다면 최대 100대의 로봇이 존재할 수 있으므로 복잡도는
        // 100,000,000 까지 늘어남.
        
        // 모르겠넴... 그냥 한 번 풀어나 보자.
    //================================================================================================//    
        //구현방법
        //1. 각각의 로봇의 경로를 큐에 저장
        //2. 큐에 넣어놓은 경로를 하나씩 빼내면서 겹치는 경로(충돌위험이있는경로)가 존재하는 지 확인
        //2-1. 딕셔너리로 경로를 저장하여 빠르게 계산
        //3. 만약 충돌위험이 있으면 result에 1을 추가하여 출력
        //3-1. 이미 검출된 위험경로는 다시 검출되어도 상관없지만, 다른 위험경로가 존재할 경우 result에 추가해주어야함.
        
        //딕셔너리 구성 => 키  = 1차원배열[r,c,second] / 값 = 이미 존재하는 로봇이 있는가?
        //0 => 아직 충돌위험없음 / 1 => 이미 충돌위험이 있는 자리
        int answer = 0;
        Dictionary<(int,int,int),int>  dangerousCheck = new Dictionary<(int,int,int),int>();
        Queue<int[]> routeForSec;
        for(int i=0; i <  routes.GetLength(0);i++)
        {
            //routeForSec = CalcRoute(points,routes[i]);
            int[] tempRoute = new int[routes.GetLength(1)];
            for (int j=0; j < routes.GetLength(1); j++)
            {
                tempRoute[j] = routes[i,j];
            }
            routeForSec = CalcRoute(points,tempRoute);
            int second = 0;
            while(routeForSec.Count > 0)
            {
                int[] presentPoint = routeForSec.Dequeue();
                var key = (presentPoint[0],presentPoint[1],second);
                if(!dangerousCheck.ContainsKey(key))
                {
                    dangerousCheck.Add(key,0);
                }
                else
                {
                    if(dangerousCheck[key]==0)
                    {
                        dangerousCheck[key] = 1;
                        answer++;
                    }
                }
                second++;
            }
            
        }
        
        return answer;
    }
    
    //매개변수가 크면 함수호출에 의한 부하가 커지나? 그건 모르겠음.
    public Queue<int[]> CalcRoute(int[,]points, int[]routes)
    {
        Queue<int[]> routeForSec =  new Queue<int[]>();
        for(int i = 0; i < routes.Length-1 ; i++)
        {
            int fromIdx = routes[i]-1;
            int toIdx = routes[i + 1]-1;
            int sub_R = points[toIdx, 0] - points[fromIdx, 0];
            int sub_C = points[toIdx, 1] - points[fromIdx, 1];
            int[] tempPoint = new int[points.GetLength(1)];
            for(int j = 0; j < points.GetLength(1); j++)
            {
                tempPoint[j] = points[fromIdx,j];
            }
            int[] presentPoint = tempPoint;
            if( i == 0)
            {
                routeForSec.Enqueue((int[])presentPoint.Clone());
            }
            
            while(sub_R != 0)
            {
                if(sub_R > 0)
                {
                    //presentPoint += dir_R;
                    presentPoint[0] += 1;
                    sub_R--;
                    routeForSec.Enqueue((int[])presentPoint.Clone());
                }
                else if(sub_R<0)
                {
                    presentPoint[0] -= 1;
                    sub_R++;
                    routeForSec.Enqueue((int[])presentPoint.Clone());
                }
            }
            while(sub_C != 0)
            {
                if(sub_C > 0)
                {
                    //presentPoint += dir_R;
                    presentPoint[1] += 1;
                    sub_C--;
                    routeForSec.Enqueue((int[])presentPoint.Clone());
                }
                else if(sub_C<0)
                {
                    presentPoint[1] -= 1;
                    sub_C++;
                    routeForSec.Enqueue((int[])presentPoint.Clone());
                }
            }
            
        }
        return routeForSec;
        
        
    }
    
    
}
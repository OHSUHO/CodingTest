using System.Collections.Generic;
using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) 
    {
        int[]currentPoint = new int[]{0,0};
        Dictionary<(int,int),bool> maze = new Dictionary<(int,int),bool>();
        
        for(int i = 0; i < park.Length; i++)
        {
            for(int j=0; j < park[i].Length; j++)
            {
                switch(park[i][j])
                {
                    case 'S':
                        currentPoint = new int[]{i,j};
                        maze.Add((i,j),true);
                        break;
                    case 'O':
                        maze.Add((i,j),true);
                        break;
                    case 'X':
                        maze.Add((i,j),false);
                        break;
                        
                }
            }
        }
        
        for(int i = 0; i < routes.Length; i++)
        {
            string move = routes[i].Replace(" ",string.Empty);
            int repeat = int.Parse(move[1].ToString());
            int[] totalMove = new int[2];
            int[] direction = new int[2];
            switch(move[0])
            {   
                case 'S':
                    totalMove = new []{repeat,0};
                    direction = new []{1,0};
                    break;
                case 'N':
                    totalMove = new []{-repeat,0};
                    direction = new []{-1,0};
                    break;
                case 'E':
                    totalMove = new []{0,repeat};
                    direction = new []{0,1};
                    break;
                case 'W':
                    totalMove = new []{0,-repeat};
                    direction = new []{0,-1};
                    break;
            }
            
            if(maze.ContainsKey((currentPoint[0]+totalMove[0],currentPoint[1]+totalMove[1])) && maze[(currentPoint[0]+totalMove[0],currentPoint[1]+totalMove[1])])
            {
                
                bool isObstacle  = false;
                int[]tempPoint=new[]{0,0};
                for(int k = 1; k < repeat+1; k++)
                {
                   tempPoint =new int[]{currentPoint[0]+direction[0]*k,currentPoint[1]+direction[1]*k};
                    if(!maze[(tempPoint[0],tempPoint[1])])
                    {
                        isObstacle = true;
                    }
                }
                if(!isObstacle)
                {
                    currentPoint = tempPoint;
                }
                
                
            }
            
        }
        
        return currentPoint;
            
    }
        

}
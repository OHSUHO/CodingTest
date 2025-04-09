using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int col = wallpaper[0].Length;
        int row = wallpaper.GetLength(0);
        int left=col;
        int right=0;
        int up=row;
        int down=0;
        for(int j=0; j<col;j++){
        for(int i = 0; i<row;i++){
            if(wallpaper[i][j]=='#'){
                if(right<j) right = j;
                if(down<i) down = i;
            }
        }
            }
        for(int j=0;j<col;j++){
        for(int i=0; i<row;i++){
            if(wallpaper[i][j]=='#'){
                if(left>j) left = j;
                if(up>i) up = i;
            }
        }   
        }
        
        int[] answer = new int[] {up,left,down+1,right+1};
        return answer;
    }
}
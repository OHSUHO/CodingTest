using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[] {};
        Dictionary<string,int> playerRank = new Dictionary<string,int>();
        int i = 0;
        foreach(string p in players)
        {
            playerRank.Add(p,i);
            i++;
        }
      
        foreach(string call in callings)
        {
            int currentRank = playerRank[call];
            playerRank[call] -= 1;
            playerRank[players[currentRank-1]] += 1;
            string temp = players[currentRank];
            players[currentRank] = players[currentRank-1];
            players[currentRank-1] = temp;

       
        }
        
        
        return players;
    }
}
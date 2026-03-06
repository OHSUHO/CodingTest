using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] answer = new int[] {};
        /*
        1. terms를 dic에 저장
        =================================================================
        2. privacies를 순차적으로 순회하면서 약관의 month부분과 비교하여 1차 필터링
        3. 만약, 달이 같으면 day를 비교하여 필터링
        =================================================================
        수정-
        2. privacies를 순차적으로 순회하면서 비교
         2-1. 어떻게? 
         울단, 고객이 가입한 날짜에 약관의 개인정보기간을 더한 후 치환. ex) 2022.03.04 에서 12달이면 2023.03.04
         2-2. 해당 날짜와 년, 달, 날 순으로 비교
        
        
        4. 파기해야할 개인정보면 answer에 담는다.
        5. 정렬? 필요없을듯. 어차피 순차탐색할거라.
        */

        // 1번 과정
        Dictionary<string,int> Dic_Terms;
        Dic_Terms = CachingTerms(terms);
        
        // 2번 과정전에 today를 구분할 수 있도록 형변환
        string[] temp;
        temp = today.Split('.');
        int today_Year =  int.Parse(temp[0]);
        int today_Month =  int.Parse(temp[1]);
        int today_Day =  int.Parse(temp[2]);
        
        // 2번 과정

        string[]privateInfo;
        List<int> destroyedList = new List<int>();
        for(int i=0; i<privacies.Length; i++)
        {  
            privateInfo = privacies[i].Split(' ');
            temp = privateInfo[0].Split('.');
            int year =  int.Parse(temp[0]);
            int month =  int.Parse(temp[1]);
            int day =  int.Parse(temp[2]);
            
            month += Dic_Terms[privateInfo[1]];
            // 2-1번 과정
            while(month > 12)
            {
                month -= 12;
                year += 1 ;
            }
            
             // 2-2번 과정
            if(year<today_Year)
            {
                //4번 과정
                destroyedList.Add(i+1);
                continue;
            }
            else if(year==today_Year)
            {
                if(month<today_Month)
                {
                    destroyedList.Add(i+1);
                    continue;
                }
                else if(month == today_Month)
                {
                    if(day<=today_Day)
                    {
                        destroyedList.Add(i+1);
                        continue;
                    }
                }
                else if(month > today_Month)
                {
                    continue;
                }
            }
            else if(year>today_Year)
            {
                continue;
            }

        }
        
        
        answer = destroyedList.ToArray();
        return answer;
    }
    
    
    //Temrs를 Dic에 저장하는 메서드
    public Dictionary<string,int> CachingTerms(string[] termsArray)
    {
        Dictionary<string,int> TermsInfo =  new Dictionary<string,int>();
        
        foreach(string str in termsArray)
        {
            string[] tempStr = str.Split(' ');
            TermsInfo.Add(tempStr[0],int.Parse(tempStr[1]));
            
        }
        
        
        
        return TermsInfo;
        
    }
    
    
    
    
    
    
    
}
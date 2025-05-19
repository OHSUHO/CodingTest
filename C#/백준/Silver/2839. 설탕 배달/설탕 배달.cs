using System;

public class Program
{

    static void Main()
    {
        int remainSugar = int.Parse(Console.ReadLine());
        int fiveSugar;
        int threeSugar; 
        int answer;
        fiveSugar = remainSugar / 5;
        remainSugar %= 5; 
        threeSugar = remainSugar / 3;
        remainSugar %= 3;
        if(remainSugar>0)
        {
            while(fiveSugar>0)
            {
                fiveSugar--;
                remainSugar+=5;
                threeSugar += (remainSugar /3) ;
                remainSugar %= 3;
                if(remainSugar>0)continue;
                else{break;}
            }
        }
        
        if(remainSugar>0)
        {
            answer = -1;
        }
        else
        {
            answer = fiveSugar+threeSugar;
        }
        
        Console.WriteLine(answer);
        

        
    }
    
    
}
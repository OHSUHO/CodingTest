import java.util.*;

class Solution {
    public int[] solution(int n, int m) {
        
        List<Integer> nDivisors = Divisor(n);
        List<Integer> mDivisors = Divisor(m);
        int max_Divisor=1;
        int min_multiplier=1;
        
        for(int i=0; i<nDivisors.size(); i++)
        {
            for(int j=0; j < mDivisors.size(); j++)
            {
                if((nDivisors.get(i)).intValue()==(mDivisors.get(j)).intValue())
                {
                    max_Divisor = Math.max(max_Divisor,nDivisors.get(i).intValue());
                }
                
                
            }
        }
        
        min_multiplier = n*m / max_Divisor;
        
        int[] answer = {max_Divisor,min_multiplier};    
        return answer;
    }
    
    public List<Integer> Divisor(int n)
    {
        List<Integer> divisors = new ArrayList<>();
        for(int i=1; i <= n; i++)
        {
            if( n % i == 0)
            {
                divisors.add(i);
               
            }
        }
        
        return divisors;
    }
}
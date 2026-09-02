import java.util.*;

class Solution {
    public String solution(String s) {
        String answer = "";
        //문자를 정수형 변수에 저장 후 출력 시 아스키 코드 값 출력
        //A = 65, a= 97 이 나온다.
        //모든 문자들을 변환 후 HashMap에 저장하고, 문자열 배열을 정수형 배열로 변환 한 뒤, decending order하면 될 듯?
        
        Map<Character,Integer> conversionInteger = new HashMap<>();
        for(int i='A'; i <= 'Z';i++)
        {
            conversionInteger.put((char)i,i);
        }
        
        for(int i='a'; i <= 'z';i++)
        {
            conversionInteger.put((char)i,i);
        }
        
        List<Integer> conversionList = new ArrayList<>();
        
        for(int i = 0; i < s.length(); i++)
        {
            conversionList.add(conversionInteger.get(s.charAt(i)));
        }
        
        conversionList.sort(Comparator.reverseOrder());
        
        for(Integer c : conversionList)
        {
            
            answer += String.valueOf((char)c.intValue());

        }
            
        return answer;
    }
}
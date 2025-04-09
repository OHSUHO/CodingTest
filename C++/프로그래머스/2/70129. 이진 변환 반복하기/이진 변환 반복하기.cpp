#include <string>
#include <vector>
#include <iostream>

using namespace std;

int RemoveZero(string *s){
    int i =0;
    int rmvZero=0;
    while(i<(*s).length()){
        if((*s)[i]=='0'){
            (*s).erase(i,1);
            rmvZero++;
        }else i++;
    }
    return rmvZero;
}

string ConvertBinary(string s){
    int n = s.length();
    int ptr = 0;
    string result;
    string result_reverse;
    string temp;
    while(n!=1){
        ptr = n%2;
        result.append(to_string(ptr));
        n = n/2;  
    }
    result.push_back('1');
    while(result.length()>0){
        temp = result[result.size()-1];
        result.erase(result.length()-1,1);
        result_reverse.append(temp);
    }
    return result_reverse;
}

vector<int> solution(string s) {
    vector<int> answer;
    int cvt=0;
    int rmvZero=0;
   while(s.length()!=1){
        rmvZero+=RemoveZero(&s);
        s = ConvertBinary(s);
        cvt++;
    }
    cout<<cvt<<'\n';
    cout<<rmvZero;
    answer.push_back(cvt);
    answer.push_back(rmvZero);
    
    return answer;
}
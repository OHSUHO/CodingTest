#include <string>
#include <vector>
#include <iostream>
#include<sstream>
#include<limits.h>

using namespace std;

string solution(string s) {
    istringstream iss(s);
    int min,max,temp;
    string buff;
    max=INT_MIN;
    min=INT_MAX;
    while(getline(iss,buff,' ')){
        temp = stoi(buff);
        if(min>temp)
            min=temp;
        if(max<temp)
            max=temp;
    }
    string max_s =to_string(max);
    string min_s =to_string(min);
    string answer = min_s+" "+max_s;
    return answer;
}
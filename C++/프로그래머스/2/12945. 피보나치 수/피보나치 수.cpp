#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    unsigned int fabo[100000]={0,};
    int i=2;
    fabo[0]=0;
    fabo[1]=1;
    while(i<=n){
        fabo[i]=fabo[i-1]%1234567+fabo[i-2]%1234567;
        i++;
    }
    
    unsigned int answer = fabo[n]%1234567;
    return answer;
}
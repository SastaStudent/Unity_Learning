#include<iostream>
using namespace std;
int size(string s){
    
    int i=0;
    while(s[i]!='\0'){
        i++;
    }
    return i;
}
bool RotationOrNot(string temp,string str2){
    int n1=size(temp);
    int n2=size(str2);
    bool ans=false;
    for(int i=0;i<n1-n2;i++){
        int j=0;
        int start=i;
        while(j<n2 && temp[start]==str2[j] && start<n1 ){
            j++;
            start++;
        }
        if(j==n2){
            return true;
        }

    }
    return false;
}
int main()
{
    string str,str2;
    cin>>str>>str2;
    string temp = str+str;

    bool ans=RotationOrNot(temp,str2);
    
    if(ans==true) cout<<"true"<<endl;
    else cout<<"false"<<endl;
}
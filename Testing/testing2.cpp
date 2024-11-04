#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;
const int MAX =1e5+5;

int size(string s){
    
    int i=0;
    while(s[i]!='\0'){
        i++;
    }
    return i;
}

void bubble(string *v,int size){

    for(int i=0;i<size;i++){
        for(int j=0;j<size-i-1;j++){
            if(v[j]>v[j+1]){
                string temp = v[j];
                v[j]=v[j+1];
                v[j+1]=temp;
            }
        }
    }
}

int main()
{
    string str;
    getline(cin,str);
    // vector<string>v;
    string v[MAX];
    string temp="";
    int index=0;
    int n=size(str);
    for(int i=0;i<=n;i++){
        if(str[i]==' ' || str[i]=='\0'){
            v[index]=temp;
            index++;
            temp="";
        }
        else{
            temp+=str[i];
        }
    }


    bubble(v,index);

    string ans[index];
    int idx2=0;
    for(int i=1;i<index;i++){
        if(v[i-1]!=v[i]){
             ans[idx2]=v[i-1];
             idx2++;
        }
    }
    for(int i=0;i<idx2;i++){
        cout<<ans[i]<<" ";
    }

    
    // cout<<str.size()<< " "<<str<<endl;
    
    
}
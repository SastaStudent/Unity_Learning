#include<bits/stdc++.h>
using namespace std;
int main(){
    string str;
    getline(cin,str);
    string temp="";
    map<char,int>mp;
    for(char a:str){
        if(mp[a]>0){
            temp+=a;
        }
        mp[a]++;
    }

    map<char,int>freq;
    string ans="";
    for(int i=0;i<temp.size();i++){
        if(freq[temp[i]]==0 && temp[i]!=' '){
            ans+=temp[i];
        }
        freq[temp[i]]++;
    }
    cout<<"Final ans: "<<ans<<endl;
}
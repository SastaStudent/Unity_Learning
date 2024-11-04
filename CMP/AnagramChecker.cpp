#include<iostream>
using namespace std;

bool areAnagram(string a,string b){
    int freq[26]={0};
    int freq2[26]={0};
    int freq3[26]={0};
    int freq4[26]={0};
    for(char ch:a){
        
        if(ch>='a' && ch<='z') freq[ch-'a']++;
        if(ch>='A' && ch<='Z') freq2[ch-'A']++;
    }
    for(char ch:b){
        if(ch>='a' && ch<='z') freq3[ch-'a']++;
        if(ch>='A' && ch<='Z') freq4[ch-'A']++;
    }
  
    for(int i=0;i<26;i++){
        int one = freq[i]+freq2[i];
        int two = freq3[i]+freq4[i];
        if(one!=two){
            return false;
        }

    }
    return true;
}
int main()
{
    string a,b;
    // cin>>a>>b;
    getline(cin,a);
    getline(cin,b);
    bool ans = areAnagram(a,b);
    if(ans==true) cout<<"true"<<endl;
    else cout<<"false"<<endl;
}
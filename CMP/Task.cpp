#include<iostream>
#include<unordered_map>
using namespace std;
int main(){

    string str;
    getline(cin,str);

    unordered_map<string,int>mp;
    string temp="";
    for(int i=0;i<=str.size();i++){

        if(str[i]==' ' || str[i]=='\0'){
            if(temp!="")
            {
                mp[temp]++;
            }
            temp="";
        }
        else{
            if(str[i]!=' ') {
                temp+=str[i];
            }
        }

    }
    for(auto it:mp){
        cout<<it.first<<" "<<it.second<<endl;
    }
}
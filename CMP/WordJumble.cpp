#include<iostream>
#include<vector>
using namespace std;

void bubble(vector<string>&v){

    for(int i=0;i<v.size();i++){
        for(int j=0;j<v.size()-i-1;j++){
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
    vector<string>v;
    string temp="";
    for(int i=0;i<=str.size();i++){
        if(str[i]==' ' || str[i]=='\0'){
            if(temp!="") v.push_back(temp);
            temp="";
        }
        else{
            
            if(str[i]!=' ')temp+=str[i];
        }
    }
    bubble(v);

    vector<string>ans;
    for(int i=1;i<=v.size();i++){
        if(v[i-1]!=v[i]){
            ans.push_back(v[i-1]);
        }
    }
    for(int i=0;i<ans.size();i++){
        cout<<ans[i]<<" ";
    }

    
    // cout<<str.size()<< " "<<str<<endl;
    
    
}
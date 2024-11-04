#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;

void merge(vector<string>&v,int low,int mid,int high){
    int size1=mid-low+1;
    int size2=high-mid;
    vector<string>v1(size1);
    vector<string>v2(size2);

    for(int i=0;i<size1;i++){
        v1[i]=v[low+i];
    }

    for(int i=0;i<size2;i++){
        v2[i]=v[mid+i];
    }

    int i=low;
    int j=0,k=0;
    while(j<size1 && k<size2){
        if(v1[j]>=v2[k]){
            v[i]=v2[k];
            i++;
            k++;
        }
        else{
            v[i]=v1[j];
            i++;
            j++;
        }
    }

    while(j<size1){
        v[i]=v1[j];
        i++;
        j++;
    }

    while(k<size2){
        v[i]=v2[k];
        i++;
        k++;
    }
}

void mergeSort(vector<string>&v,int start, int end){
    if(start>=end){
        return;
    }
    int mid = (start+end)/2;
    mergeSort(v,start,mid);
    mergeSort(v,mid+1,end);
    merge(v,start,mid,end);
}

int main()
{
    string str;
    getline(cin,str);
    vector<string>v;
    string temp="";
    for(int i=0;i<=str.size();i++){
        if(str[i]==' ' || str[i]=='\0'){
            if(temp!=" " || temp!="") v.push_back(temp);
            temp="";
        }
        else{
            temp+=str[i];
        }
    }
    // sort(v.begin(),v.end());
    mergeSort(v,0,v.size()-1);
    for(auto str:v){
        cout<<str<<" ";
    }
    cout<<endl;

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
using System;
namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] arr = new int[26];
    
            for(int i=0;i<str.Length;i++){
                if(str[i]>='a' && str[i]<='z'){
                    arr[str[i]-'a']++;
                }
                if(str[i]>='A' && str[i]<='Z')
                {
                    arr[str[i]-'A']++;
                }
            }
            string result="";
            for(int i=0;i<str.Length;i++)
            {
                 
                if((str[i]>='a' && str[i]<='z') && arr[str[i]-'a']>1){
                    result+=" ";
                    continue;
                }
                if((str[i]>='A' && str[i]<='Z') && arr[str[i]-'A']>1){
                    result+=" ";
                    continue;
                }
                result+=str[i];
                
                
            }
            Console.WriteLine(str);
            Console.WriteLine(result );
        }
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace Program
{
    // Declaration of delegates
    public delegate int Adding(int x,int y,int z);
    public delegate string Adding(string x,string y);
    public class HelloWorld
    {
        public int Add(int a,int b,int c){
            return a+b+c;
        }
        public string Add(string a,string b){
            return a+b;
        }
        public static void Main(string[] args)
        {
            // intantiating delegates
            Adding adding= new Adding(HelloWorld.Add());
            Adding StAdding = new Program.Adding()
            
             
        }
    }
}
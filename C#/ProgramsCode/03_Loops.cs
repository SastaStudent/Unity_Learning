// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // While loop
        Console.WriteLine("While Loop");
        int i=1;
        while(i<=5)
        {
            Console.Write(i);
            Console.Write(" ");
            i++;
        }
        Console.WriteLine("\nFor LOOP");
        // for loop
        for(int k=0;k<5;k++){
            Console.Write(k+" ");
        }
        
        
        Console.WriteLine("\nDo while");
        // int k;
        // do{
        //     Console.Write(k+" Do while ");
        //     k++;
        // }while(k<=5);
        
        int j=1;
        do{
            Console.Write(j + " Do while ");
            j++;
        }while(j<=5);
        
        
    }
}
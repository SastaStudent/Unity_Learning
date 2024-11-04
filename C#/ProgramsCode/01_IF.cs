// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //   Conditional
        int Num1= Convert.ToInt32(Console.ReadLine());
        int Num2= Convert.ToInt32(Console.ReadLine());
        
        if(Num1>Num2){
            Console.WriteLine("If body part is executed");
        }
        else{
            Console.WriteLine("Else body part is executed");
        }
    }
}
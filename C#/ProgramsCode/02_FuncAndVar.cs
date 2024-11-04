using System;
namespace Try
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            int Num1= Convert.ToInt32(Console.ReadLine());
            int Num2= Convert.ToInt32(Console.ReadLine());
            int res = Sum(Num1,Num2);
            Console.WriteLine("Sum is "+ res);
            
             res = Subtract(Num1,Num2);
            Console.WriteLine("Subtract is "+ res);
            
             res = Multiply(Num1,Num2);
            Console.WriteLine("Multiply is "+ res);
            
            float res1 = Divide(Num1,Num2);
            Console.WriteLine("Divide is "+ res);
           
        }
        static int Sum(int a,int b){
            return a+b;
        }
        static int Subtract(int a,int b){
            return a-b;
        }
        static int Multiply(int a,int b){
            return a*b;
        }
        static float Divide(int a,int b){
            return (float)a/b;
        }
    }
}
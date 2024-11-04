using System;
namespace Second
{
    public class SumThree
    {
        public static void Main(string[] args){
            Console.WriteLine("Enter size of Array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Element of Array");
            int[] arr = new int[n];
            for(int i = 0;i<n;i++){
                arr[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Target");
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int a=arr[i];
                for (int j = i+1; j < n; j++)
                {
                   
                    int b=arr[j];
                    for(int k=j+1; k<n;k++)
                    {
                        
                        int c= arr[k];

                        if((a+b+c)==target)
                        {
                            Console.WriteLine("Indexes are: "+ i+" "+ j+" "+ k);
                        }

                    }
                }
                
            }
             
        }
    }
}
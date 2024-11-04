using System;
namespace Third
{
    public class ThirdLargest
    {
        public static void Main(string[] args){
            Console.WriteLine("Enter size of Array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Element of Array");
            int[] arr = new int[n];
            for(int i = 0;i<n;i++){
                arr[i]= int.Parse(Console.ReadLine());
            }

            int firstLarge = -1;
            int secondLarge = -1;
            int thirdLarge = -1;

            foreach (int element in arr){
                if(element>= firstLarge){
                    thirdLarge = secondLarge;
                    secondLarge=firstLarge;
                    firstLarge=element;
                }
                else if(element>= secondLarge){
                    thirdLarge = secondLarge;
                    secondLarge = element;
                }
                else if(element > thirdLarge){
                    thirdLarge = element;
                }
            }

            // Console.WriteLine("First Larges: " + firstLarge + "\nSecond Large: " + secondLarge +"\nThird Large: " + thirdLarge);
            Console.WriteLine("Third Largest: " + thirdLarge);
             
        }
    }
}
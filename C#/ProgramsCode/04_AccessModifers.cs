// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public class Animals{
        public string name;
        private string color;
        protected int legs;
        protected int ears;
        internal string gender;
        
        // setter for private member
        public void SetColor(string color)
        {
            this.color=color;
        }
        // Getter for private member
        public void GetColor()
        {
            Console.WriteLine(color);
        }
        
    }
    // inherit
    public class Dogs : Animals{
        public string sound;
        // Protected member form base class
        public void SetLegs(int legs){
            this.legs=legs;
        }
        public void GetLegs(){
            Console.WriteLine(legs);
        }
    }
    public static void Main(string[] args)
    {
        Animals cow = new Animals();
        cow.name="Milky";
        cow.SetColor("White");
        // cow.legs=4;
        cow.gender="Female";
        
        Console.WriteLine(cow.name);
        cow.GetColor();
        Console.WriteLine(cow.gender);
        
        // more practice
        Dogs dog1 = new Dogs();
        dog1.name="Alberto";
        dog1.SetColor("Black-Brown");
        // dog1.legs=4;
        dog1.SetLegs(4);
        
        Console.WriteLine("\nDogs Properties");
        Console.WriteLine(dog1.name);
        dog1.GetColor();
        dog1.GetLegs();
        Console.WriteLine(dog1.sound);
         
    }
}
### Class
Class is a user define data type. which contains non-abstract methods( methods with body)
It can not contains abstract methods.

### Abstract Class
Abstract Class are also user define data type which contains abstract (methods without body ) or non-abstract methods

### Interface
0. We used interface keyword to declared a interface and use Start interface name from I ( this is not mandatory, but this is naming convention)
1. It is a user define data type
2. It contain only abstract methods
3. Using this we can achieve Multiple & Hybrid inheritance which is not supported in C#
4. In this we implement the abstract method not use the abstract methods, that's why
using this we can achieve multiple & hybrid inheritance.

```Csharp

using System;
interface IFirst{
    void print();
    void Hello();
    void Health();
}

interface ISecond{
    void print();
    void SayGoodBye();
}
public class TryInterface : IFirst,ISecond
{
    public void print(){
        Console.WriteLine("No ambiguity");
    }
    public void Hello(){
        Console.WriteLine("Hi, there I'm from interface one");
    }
    void IFirst.Health(){
        Console.WriteLine("My Health is Good");
    }
    public void SayGoodBye(){
        Console.WriteLine("Goodbye Coder");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        TryInterface obj = new TryInterface();
        obj.print();
        obj.Hello();
        // obj.Health(); this is not possible because of it declaration
        IFirst nowAllowed = obj;//reference of IFirst interface 
        nowAllowed.Health();
        obj.SayGoodBye();
    }
}

```

### 2. Extension Methods

Extension methods in Unity (and C# in general) allow you to add new functionality to existing types without modifying their source code. This can be particularly useful for enhancing Unity's built-in classes, like GameObject, Transform, or even custom classes. Here’s how you can create and use extension methods in Unity:

### 3. List & Dictionary

### 4. Co-routine

1. Coroutines are a way of performing an operation over time instead of instantly. They can be useful, but there are some important things you need to be aware of when you use them to avoid inefficiency in your game or application. 

#### How it works
Coroutines work by encapsulating methods which have a return type of IEnumerator. IEnumerator is an interface type from the System.Collections namespace which is used to support iteration. When IEnumerator is used for Coroutines, it will cause execution of your code to pause and resume at various points that you determine, iterating through them.

#### Why it use

Coroutines provide an excellent way of easily managing things that need to happen after a delay or over the course of time. They prevent Update methods from becoming bloated with timers and the other workings required to achieve the same outcome with a different approach.

#### Disadvantage
1. The major disadvantage of using Coroutines is the way that they use memory.
2. Storing and accessing memory on the heap is more complicated than memory on the stack, and can have a significant impact on the efficiency of your game or application.
3. Coroutines create temporary objects which are stored on the heap.

### 5. Delegates

```csharp

using System;

namespace Program
{
    // Declaration of delegates
    public delegate int AddingIntegers(int x, int y, int z);
    public delegate string AddingStrings(string x, string y);

    public class HelloWorld
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static string Add(string a, string b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            HelloWorld obj = new HelloWorld();

            // Instantiate delegates
            AddingIntegers intAdding = new AddingIntegers(obj.Add);
            AddingStrings strAdding = new AddingStrings(Add);
            // For non-static It is compulsory to pass through instance of the class
            // But for static no need of instance of class , we can directly call
            // Invoke the delegates
            int intResult = intAdding(1, 20, 3);
            string strResult = strAdding("Hello, New ", "World!");

            Console.WriteLine("Integer Addition Result: " + intResult);
            Console.WriteLine("String Concatenation Result: " + strResult);
        }
    }
}

```

### 6. 


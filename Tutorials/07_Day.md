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

1. This is a new feature added in C# 3.0
2. It is a mechanism to add new methods in a existing class or structure. Without modifying the source code of original type.
3. It is not require any permission of original type.
4. It does not require re-compilation of original type.
5. Extension methods define as Static but when it bound with other class or structure it turn into non-static methods.
6. If extension method is same as existing methods(name and signature), then existing method will be called and extension methods
will be ignore with no any error.
7. The first parameter of the extension method should be the name of type to which that method has to be bound with and this parameter 
is not taken into the consideration while calling the extension methods.
8. There is only one binding parameter which is written as first parameter in extension method
9. We can add parameter after the binding parameter and these parameters are taken into consideration.
###### How to bind Exntension methods to class/structure

1. Make another Static class
2. Create methods and pass class ( which is suppose to bound ) as a parameter using this keyword.

like
```csharp

public static class ExtensionExample{
    static ExtensionMethods(this ClassName objName){
        Console.Write("Extension Methods ");
    }
}

```

###### Why Extension Methods.

1. Using inheritance we can extends or add methods in derived class.
2. And we can't apply inheritance on a sealed class
3. Also we can't apply inheritance on structure

Extension methods in Unity (and C# in general) allow you to add new functionality to existing types without modifying their source code. This can be particularly useful for enhancing Unity's built-in classes, like GameObject, Transform, or even custom classes. Here’s how you can create and use extension methods in Unity:

### 3. List & Dictionary

### List in C#
1. A List is a collection that stores elements in an ordered sequence and allows duplicates. It is dynamic, meaning it can grow or shrink as items are added or removed.

2. Namespace: System.Collections.Generic
3. Declaration: List<T>, where T is the type of elements stored in the list.

##### Example
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        numbers.Add(6);
        int firstNumber = numbers[0]; 
        Console.WriteLine("First number is {0}",firstNumber);
        numbers[0]=99; 
        numbers.Remove(3);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
```
### Dictionay in C#
1. A Dictionary is a collection of key-value pairs. Each key must be unique, but values can be duplicated. It is useful when you need to look up values by a unique key.

2. Namespace: System.Collections.Generic
3. Declaration: Dictionary<TKey, TValue>, where TKey is the type of keys and TValue is the type of values.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 }
        };
        ages["Charlie"] = 35;//adding in dictionary
        ages.Add("Monu", 22);//adding in dictionary

        int aliceAge = ages["Alice"];  // Output: 25
        if (ages.ContainsKey("Bob"))
        {
            Console.WriteLine("Bob is in the dictionary.");
        }
        ages.Remove("Alice");//deletion from dictionary
        foreach (KeyValuePair<string, int> kvp in ages)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");//interpolation of string
        }
    }
}
```

### 4. Co-routine

1. Coroutines are a way of performing an operation over time instead of instantly. They can be useful, but there are some important things you need to be aware of when you use them to avoid inefficiency in your game or application. 
2. Corotines are the funtion which return type is IEnumerator and we can call co-routine only using StartCoroutine() method in which we are passing as a string or direct function call.
3. In corotine we can pass arguments also.
4. To stop coroutine we can use StopCoroutines() method in which we can pass coroutine as reference and other methods also present in Unity to stop coroutine.
5. Others methods to stop coroutine (StopAllCoroutines())

(i). MonoBehaviour.StartCoroutine returns a Coroutine. Instances of this class are only used to reference these coroutines, and do not hold any exposed properties or functions.

(ii). A coroutine is a function that can suspend its execution (yield) until the given YieldInstruction finishes.

```csharp
using System.Collections;
using UnityEngine;

public class CoRoutineTry : MonoBehaviour
{
    // Start is called before the first frame update
    Coroutine UpWardRef;
    void Start()
    {
        // 1st method to call
        // StartCoroutine(UpWard());

        // 2nd method to call
        UpWardRef = StartCoroutine("UpWard");//it returns Coroutine reference
        
    }

    IEnumerator UpWard(){
        Debug.Log("First Co routine");
        yield return new WaitForSeconds(3f);
        Debug.Log("After 3 second");
    }
}
```

#### How it works
Coroutines work by encapsulating methods which have a return type of IEnumerator. IEnumerator is an interface type from the System.Collections namespace which is used to support iteration. When IEnumerator is used for Coroutines, it will cause execution of your code to pause and resume at various points that you determine, iterating through them.

#### Why it use

Coroutines provide an excellent way of easily managing things that need to happen after a delay or over the course of time. They prevent Update methods from becoming bloated with timers and the other workings required to achieve the same outcome with a different approach.

#### Disadvantage
1. The major disadvantage of using Coroutines is the way that they use memory.
2. Storing and accessing memory on the heap is more complicated than memory on the stack, and can have a significant impact on the efficiency of your game or application.
3. Coroutines create temporary objects which are stored on the heap.

### 5. Delegates
1. Delegates in Unity (and C# in general) are a powerful feature that allows you to define a type that represents references to methods with a specific signature. 
2. They are often used for events and callbacks, enabling a flexible and decoupled way to handle functionality in your code.

```csharp
using System;

public class HelloWorld
{
    delegate void DelegateTry(int num);
    static void printNum(int num){
        Console.WriteLine("Number is {0}",num);
    }
    static void printDouble(int num)
    {
        Console.WriteLine("Original no. is {0} and double is {1}",num,num*2);
    }
    public static void Main(string[] args)
    {
        DelegateTry mydele = printNum;
        mydele(5);
        mydele = printDouble;
        mydele(5);
    }
}
```

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

### 6. Quaternions

1. Quaternions are used to represent rotations.

2. A quaternion is a four-tuple of real numbers {x,y,z,w}. A quaternion is a mathematically convenient alternative to the euler angle representation. You can interpolate a quaternion without experiencing gimbal lock. We can also use a quaternion to concatenate a series of rotations into a single representation.

3. Unity internally uses Quaternions to represent all rotations.

4. In most cases, you can use existing rotations from methods such as Transform.localRotation or Transform.rotation to construct new rotations. For example, use existing rotations to smoothly interpolate between two rotations. The most used Quaternion functions are as follows:
(i). Quaternion.LookRotation
(ii). Quaternion.Angle
(iii). Quaternion.Euler
(iv). Quaternion.Slerp
(v). Quaternion.FromToRotation
(vi). Quaternion.identity

5. We can use the Quaternion.operator * to rotate one rotation by another, or to rotate a vector by a rotation.
##### Example of Quaternions
```csharp
using UnityEngine;

public class QuaterNionsTry : MonoBehaviour
{
    public Vector3 currRotation;
    public Vector3 angleToRotate;
    void Start()
    {
        angleToRotate = new Vector3(angleToRotate.x%360f, angleToRotate.y%360f,angleToRotate.z%360f);
        currRotation = new Vector3(currRotation.x%360f, currRotation.y%360f,currRotation.z%360f);
        Quaternion rorateX = Quaternion.AngleAxis(currRotation.x,new Vector3(1f,0f,0f));
        Quaternion rorateY = Quaternion.AngleAxis(currRotation.y,new Vector3(0f,1f,0f));
        Quaternion rorateZ = Quaternion.AngleAxis(currRotation.z,new Vector3(0f,0f,1f));
        transform.rotation = rorateX * rorateY * rorateZ;       
    }
    void Update()
    {
        Quaternion rorateX = Quaternion.AngleAxis(angleToRotate.x * Time.deltaTime,new Vector3(1f,0f,0f));
        Quaternion rorateY = Quaternion.AngleAxis(angleToRotate.y * Time.deltaTime,new Vector3(0f,1f,0f));
        Quaternion rorateZ = Quaternion.AngleAxis(angleToRotate.z * Time.deltaTime,new Vector3(0f,0f,1f));
        angleToRotate = new Vector3(angleToRotate.x%360f, angleToRotate.y%360f,angleToRotate.z%360f);
        transform.rotation = transform.rotation* rorateX * rorateY * rorateZ;   
        
    }
}
```
### 7. Gimble Lock
1. Gimbal lock is a phenomenon that occurs in 3D graphics and robotics when using Euler angles for rotation. It happens when two of the three rotational axes become aligned, resulting in a loss of one degree of freedom in the rotation representation. This can make it difficult to achieve certain orientations and can lead to unexpected behavior.

##### How it occurs
1. In a typical gimbal system (a setup with three rings, each allowing rotation about a different axis), if you rotate one of the rings by 90 degrees, the other two rings can become locked in the same plane. As a result, you lose the ability to rotate around one of the axes because the two axes are now aligned.

### 8. Attributes
1. In Unity, attributes are special tags that you can use to modify the behavior of classes, methods, properties, and fields. 
2. They provide a way to add metadata and control how your scripts interact with the Unity Editor and the runtime environment.
3. We can also create custom Attributes using System.Attribute namespace.

##### Examples
1. [SerializeField] :- 
Makes a private field visible in the Unity Inspector, allowing you to set its value directly in the Editor.
```csharp
[SerializeField]
private int score;
```
2. [HideInInspector] :- 
Hides a public field from the Inspector, which is useful if you want to keep the field accessible in code but not editable in the Editor.
csharp
```Csharp
[HideInInspector]
public float health;
```
3. [Range(min, max)] :- 
Allows you to specify a range for a float or integer variable in the Inspector, making it easier to adjust values within a specified range.
```csharp
[Range(0, 100)]
public int health;
```
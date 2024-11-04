### 1. Properties

Properties are special methods (getters and setters) that provide a flexible mechanism to read, write, or compute the values of private fields.

```csharp

using System;

public class ProperTies{
    private int Level;
    public ProperTies(){
        this.Level=0;
    }
    public int CurrLevel{
        get{
            return Level;
        }
        set{
            Level=value;//here we have to use value keyword to update (set) level
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        ProperTies obj = new ProperTies();//to creat object
        
        int Level = obj.CurrLevel;//Acess private member using properties
        Console.WriteLine(Level);
        
        obj.CurrLevel = 60;//updating private member using properties
        Level = obj.CurrLevel;
        Console.WriteLine(Level);

    }
}

```

###### Short hand 
1. public int PropertiesName{set;get;};

### 2. Ternary Operator

The ternary operator is a shorthand for if-else statements and is used to evaluate a condition.

```csharp

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int num = int.Parse(Console.ReadLine());
         string result = (num%2==0)? "Even": "Odd";
         Console.WriteLine(result);
    }
}

```

### 3. Statics

Static members belong to the class itself rather than to any specific instance. They are shared across all instances of the class.

```csharp

```

### 4. Method Overloading

Method overloading allows multiple methods to have the same name with different parameters.

```csharp

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int numA = int.Parse(Console.ReadLine());  
       int numB = int.Parse(Console.ReadLine());
       Console.WriteLine("Result is: "+ Add(numA,numB));
       
         numA = int.Parse(Console.ReadLine());  
         numB = int.Parse(Console.ReadLine());
       int numC = int.Parse(Console.ReadLine());
       Console.WriteLine("Result is: "+ Add(numA,numB,numC));
       
       string strA =  Console.ReadLine();  
       string strB =  Console.ReadLine();
       Console.WriteLine("Result is: "+ Add(strA,strB));
       
       float num1 = float.Parse(Console.ReadLine());  
       float num2 = float.Parse(Console.ReadLine());
       Console.WriteLine("Result is: "+ Add(num1,num2));
    }
    static int Add(int a,int b){
        return a+b;
    }
    static int Add(int a,int b,int c){
        return a+b+c;
    }
    static string Add(string a,string b){
        return a+b;
    }
    static float Add(float a,float b){
        return a+b;
    }
}

```

### 5. Generic

Generics allow you to define a class or method with a placeholder for the data type.

```csharp

using System;

public class GenericExample<T>
{
    private T data;

    public GenericExample(T data)
    {
        this.data = data;
        // Console.WriteLine(this.data);
    }

    public T Access { 
        get{
            return this.data;
        }
        set{
            data =value;
        }
        
    }  
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
         
        GenericExample<int> obj = new GenericExample<int>(10);
        // obj.Access = 20;
        Console.WriteLine("Data: " + obj.Access);
        
        GenericExample<string> obj1 = new GenericExample<string>("Monu Chauhan");
        obj1.Access +=" A1"  ;
        Console.WriteLine("Data: " + obj1.Access);

        
    }
}

```

### 6. Inheritance

Inheritance allows a class to inherit the members (methods and properties) of another class.
( In this One class is called parent or base class which is main class and inherit class called as child or derived class)

```csharp

using System;
using System.Collections.Generic;

public class Human{
    private string name;
    // public Human(){ //only for check that first base class construor called
    //     Console.WriteLine("Human Class Construtor Called");
    // }
    public string PropName{
        get{
            return name;
        }
        set{
            name=value;
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter No. of Employees to Add");
        int n= int.Parse(Console.ReadLine());
        List<Employed> EmployeeList = new List<Employed>();
        for(int i=0;i<n;i++){
            Employed newEmp = new Employed();
            Console.WriteLine("Enter Name of Employee "+ (i+1));
            string name = Console.ReadLine();
            newEmp.PropName = name;
            
            Console.WriteLine("Enter Company Name");
            name = Console.ReadLine();
            newEmp.PropCompany = name;
            
            Console.WriteLine("Enter Designation");
            name = Console.ReadLine();
            newEmp.PropPost = name;
            
            EmployeeList.Add(newEmp);
        }
        Console.WriteLine("Printing Employee List");
        foreach ( var Employee in EmployeeList){
            Console.WriteLine("Name: "+ Employee.PropName);
            Console.WriteLine("Company: "+Employee.PropCompany);
            Console.WriteLine("Desigination: "+Employee.PropPost +'\n');
        }
        
        Console.WriteLine("Enter No. of Students to Add");
          n= int.Parse(Console.ReadLine());
        List<Student> StudentList = new List<Student>();
        for(int i=0;i<n;i++){
            Student newStu = new Student();
            Console.WriteLine("Enter Name of Student "+ (i+1));
            string name = Console.ReadLine();
            newStu.PropName = name;
            
            Console.WriteLine("Enter College Name");
            name = Console.ReadLine();
            newStu.PropCollege = name;
            
            Console.WriteLine("Enter fees in float or int");
            float fee = float.Parse(Console.ReadLine());
            newStu.PropFees = fee;
            
            StudentList.Add(newStu);
        }
        Console.WriteLine("Printing Student List");
        foreach ( var Stu in StudentList){
            Console.WriteLine("Name: "+ Stu.PropName);
            Console.WriteLine("College: "+Stu.PropCollege);
            Console.WriteLine("Fees: "+Stu.PropFees +'\n');
        }
        
         
    }
    public class Employed: Human{
        private string company;
        private string post;
        public string PropCompany{
            get{
                return company;
            }
            set{
                company = value;
            }
        }
        public string PropPost{
        get{
            return post;
        }
        set{
            post=value;
        }
    }
        
    }
    public class Student: Human{
        private string college;
        private float fees;
        public string PropCollege{
            get{
                return college;
            }
            set{
                college = value;
            }
        }
        public float PropFees{
            get{
                return fees;
            }
            set{
                fees=value;
            }
        }
        
    }
}

```

### 7. polymorphism

Polymorphism refers to different forms with same name.
Basically, it is a features of Inheritance
there are two types of polymorphism
1. Compile time ( method overloading )
2. Runtime ( method Overriding )

##### 8. Member Hiding

Member hiding occurs when a derived class declares a member with the same name as a member in the base class, using the new keyword.

```csharp

 
using System;

public class Birds{
    
    public void MainFeatures(){
        Console.WriteLine("All birds Can fly except some");
    }
    public void Feather(){
        Console.WriteLine("All birds have feathers");
    }
}
public class Sparrow : Birds{
    public new void Feather(){
        Console.WriteLine("Feather color is brown-grey-white");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
         Sparrow sp1 = new Sparrow();
         sp1.Feather();
    }
}

```

##### 9. Member Overriding

Overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class.

```csharp

 
using System;

public class Birds{
    
    public void MainFeatures(){
        Console.WriteLine("All birds Can fly except some");
    }
    public virtual void Feather(){
        Console.WriteLine("All birds have feathers");
    }
}
public class Sparrow : Birds{
    public override void Feather(){
        base.Feather();
        Console.WriteLine("Feather color is brown-grey-white");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
         Sparrow sp1 = new Sparrow();
         sp1.Feather();
    }
}

```

# Note
#### 1. Up-Casting
We can convert derived class obj to base class obj by upcasting
#### 2. Down-Casting
We can convert base class obj to derived class obj by downcasting

 
<h3>1.w.a.p to print first char from string string and 2nd char from 2nd string and so on using c#? </h3>
 

example 
| Input   | output    
| --------| ------- 
| abcd    | a ✔  
| abcd    | b ✔ 
| abcd    | c ✔  
| abcd    | d ✔    
Final output will be : | abcd
```
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      string res=string.Empty;
      string [] strarry ={"abcd","abcd","abcd","abcd"};
      for(int i=0; i<strarry.Length; i++)
      {
         char [] ch=strarry[i].ToCharArray();
          res +=ch[i];
      }
      Console.WriteLine("output is = {0} " ,res);
      Console.ReadLine();
    }
}

```

<h3>2. Write a C# program to determine if an array contains any duplicate number or not  using c#?</h3>

```
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] arr={1,2,3,4,5,4,5};
        bool isduplicate =false;
        for(int i=0; i<arr.Length; i++)
        {
            for(int j=i+1; j<arr.Length; j++)
            {
                if(arr[i]==arr[j])
                {
                    //Console.WriteLine(arr[i] +" :" +arr[j]);
                    isduplicate = true;
                }
            }
        }
        if(isduplicate)
        {
            Console.WriteLine("Array contain Duplicate value");
        }
        else
        {
        Console.WriteLine("Array Doesn't contain Duplicate value");
        }
        Console.ReadLine();
    }
}
```



<h3>2.1 Write a C# program to determine if an array contains any duplicate Character or not  using c#?</h3>

```
 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string duplicate =string.Empty;
        char [] arr={'A','B','C','D','A','B'};
        bool isduplicate =false;
        for(int i=0; i<arr.Length; i++)
        {
            for(int j=i+1; j<arr.Length; j++)
            {
                if(arr[i]==arr[j])
                {
                    duplicate +=arr[i] +",";
                    //Console.WriteLine(arr[i] +" :" +arr[j]);
                    isduplicate = true;
                }
            }
        }
        if(isduplicate)
        {
            Console.WriteLine("Array contain Duplicate value ={0}",duplicate);
        }
        else
        {
        Console.WriteLine("Array Doesn't contain Duplicate value");
        }
        Console.ReadLine();
    }
}
```

<h3>2.2 Write a C# program to determine if an array contains any duplicate string or not  using c#?</h3>

```
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string duplicate =string.Empty;
        string [] arr={"HI","Hello","HI"};
        bool isduplicate =false;
        for(int i=0; i<arr.Length; i++)
        {
            for(int j=i+1; j<arr.Length; j++)
            {
                if(arr[i]==arr[j])
                {
                    duplicate +=arr[i] +",";
                    //Console.WriteLine(arr[i] +" :" +arr[j]);
                    isduplicate = true;
                }
            }
        }
        if(isduplicate)
        {
            Console.WriteLine("Array contain Duplicate value ={0}",duplicate);
        }
        else
        {
        Console.WriteLine("Array Doesn't contain Duplicate value");
        }
        Console.ReadLine();
    }
}
```

<h3>3 Write a to swap two variable without using third varible and data can be any type it can be strin ,int etc,  using c#?</h3>


<h3>4. input is an int array(elements non-zero), output is a new int array</h3>
<h3>b. Example: if input array A = {2, 1, 5, 9}, then output array B would be {45, 90, 18, 10}</h3>
<h3>c. clue: B[0]=A[1]*A[2]*A[3], B[1]=A[0]*A[2]*A[3], B[2]=A[0]*A[1]*A[3], B[3]=A[0]*A[1]*A[2]</h3>

Answer
<p>To solve the problem, the function initializes an output array b of the same length as the input array a.
 For each index i in the input array, it calculates the product of all elements except the one at index i.
 This is achieved by iterating through the input array and multiplying all elements except the current one.
 The result is stored in the corresponding index of the output array b
 </p>
```

     int[] a = { 2, 1, 5, 9 };
            int[] b = Program.GetProductOfA(a);
            foreach(int val in b)
            {
                Console.Write(val + " ");
            }
 
 //method
        public static int[] GetProductOfA(int[] a)
        {
            int[] b= new int[a.Length];
            for(int i=0; i<a.Length;i++)
            {
                int product = 1;
                for(int j=0;j<a.Length; j++)
                {
                    if(i !=j)
                    {
                        product *= a[j];
                    }
                }
                b[i] = product;
            }
            return b;
        }
        
```


```

```

<!--

This File contain List of C# program.
https://www.sanfoundry.com/csharp-programming-examples/
1> W.a.p to get n number of y power.
 2> C# Program to Check Whether a Given Number is Even or Odd
 3>Singleton class ?
 4> difference betwwen interface & abstract class ?

 Implementing a Singleton Pattern
The Singleton is a design pattern that restricts the instantiation of a class to a single instance and provides a global point
of access to it. This question will test your understanding of object-oriented programming and design patterns in C#.

Task: Implement a thread-safe Singleton class in C#.

Constraints: The Singleton class should be designed in such a way that only a single instance of the class can exist in the
application, and this instance should be accessible globally.
Explanation:

The Singleton class is defined as sealed to prevent derivation, which could add instances.
A private, read-only padlock object is defined. This is used for thread synchronization to ensure that only one thread can enter the
lock code block at a time. This is important because, without thread safety, two threads could create two separate instances of the 
Singleton class.

The constructor of the Singleton class is defined as private to prevent instantiation from outside the class.

Inside the Instance property, if the Singleton instance is null, a new Singleton object is created and assigned to the instance variable. 
If the Singleton instance already exists, the existing instance is returned.

This question checks your understanding of object-oriented programming, specifically Singleton design pattern. Singleton is one of the 
Gang of Four design patterns and is categorized under creational design patterns as it deals with object creation mechanisms.
-->

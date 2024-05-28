This File contain List of C# program.
https://www.sanfoundry.com/csharp-programming-examples/
1> W.a.p to get n number of y power.
 2> C# Program to Check Whether a Given Number is Even or Odd
 3>Singleton class ?

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfProgram
{
    public class Listprogram
    {
        public static int GetPow(int number, int power)
        {
            int result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        public static double GetSquare(double number)
        {
            if(number < 0)
                return 0;
            double res = number / 2;
            double res1 = res/2;
            return res1;
        }
        public static double CalculateSqrt(double number, double tolerance = 1e-10)
        {
            if (number < 0)
                throw new ArgumentException("Cannot compute square root of a negative number.");

            double x = number;
            double root;
            int maxIterations = 1000;
            int iteration = 0;

            while (true)
            {
                root = 0.5 * (x + (number / x));

                if (Math.Abs(root - x) < tolerance)
                    break;

                x = root;

                if (++iteration >= maxIterations)
                    throw new Exception("Iteration limit exceeded. The method may not converge.");
            }

            return root;
        }
        //C# Program to Check Whether a Given Number is Even or Odd
        public static void IsOddOrEven(int number)
        {
            // Use ternary operator to determine if the number is even or odd
            string result =(number % 2==0) ? "Even" : "Odd";
            Console.WriteLine($"{number} is an {result} number.");

            //2nd way 
            if (number % 2 == 0)
                Console.WriteLine("{0}: is an even numbere", number);
            else
                Console.WriteLine("{0}: is an Odd Number",number);

        }
        //C# Program to Print Odd Numbers in a Given Range
        public static void GetOddInRange(int startno, int endno)
        {
            for(int i=startno; i <=endno; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}:- is Odd Number",i);
                } 
                else
                {
                    Console.WriteLine("{0}:- is and Even Number",i);
                }
            }
        }
        //C# Program to Check Whether a Number is Positive or Not
        public static void IsNoPositiveOrNot(int number)
        {
            string result = (number > 0) ?"Number is Positive" :
                (number ==0)? "Number is Zero" :"Number is Negative";
            Console.WriteLine("{0} : {1}",number,    result);
        }
        //C# Program to Find the Largest of Two Numbers
       public static int GetLargestNu(int[] numbers)
    {
        // Assuming the first number as the largest initially
        int largest = numbers[0];

        // Loop through the array to find the largest number
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        // Return the largest number
        return largest;
    }
        //c# program to reverse the string
        public static void ReverseString(string str)
        {
            char[] Mychars = str.ToCharArray();
            for(int i=0,j=str.Length -1; i<j; i++,j--)
            {
                Mychars[i] = str[j];
                Mychars[j] = str[i];
            }
            string reverse =new string(Mychars);
            foreach(var v in Mychars)
            {
                Console.Write(v);
            }
        }
        //C# Program to Swap Two Numbers
        public static void Swap(int a,int b)
        {
            Console.WriteLine(" before swap a:{0},b :{1}",a,b);
            a= a ^ b;//10-5//a=5
            b= a ^ b;//5+5//10
            a= a ^ b;//
            Console.WriteLine(" After swap a:{0},b :{1}",a, b);
        }
        public static void Swap1(int a, int b)
        {
            Console.WriteLine(" before swap a:{0},b :{1}", a, b);
            a = a + b;//10-5//a=5
            b = a - b;//5+5//10
            a = a - b;//
            Console.WriteLine(" After swap a:{0},b :{1}", a, b);
        }
        //w.a.p to get highest length of word in string 
        public static int GetMaxLenthWord(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            string[] words = str.Split(' ');

            int maxLength = 0;
            foreach(var word in words)
            {
                if(word.Length > maxLength) 
                    maxLength = word.Length;
            }
            return maxLength;
        }
        //

    }
}

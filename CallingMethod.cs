using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfProgram
{
    internal class CallingMethod
    {
        public static void GetCallAllListOfProgram()
        {
            double number = 32.0;
            double sqrt = Listprogram.CalculateSqrt(number);
            Console.WriteLine($"Square root of {number} is approximately {sqrt}");
            Listprogram.IsOddOrEven(2);
            Console.WriteLine("--------------");
            Listprogram.GetOddInRange(20, 40);
            Console.WriteLine("Start IsNoPositiveOrNot method ");
            Listprogram.IsNoPositiveOrNot(1);
            Listprogram.IsNoPositiveOrNot(2);
            Listprogram.IsNoPositiveOrNot(-15);
            Listprogram.IsNoPositiveOrNot(0);
            Console.WriteLine("End  IsNoPositiveOrNot method ");
            Console.WriteLine("---------------------");
            int[] myarr = { 12, 13, 56, 45, 67, 99, 98 };
            Console.WriteLine(Listprogram.GetLargestNu(myarr));
            Console.WriteLine("---------------------");
            Console.WriteLine("Reverse string start");
            Listprogram.ReverseString("Hello How are you");
            Console.WriteLine();
            Console.WriteLine("Reverse string end");
            Listprogram.Swap(10, 5);
            Listprogram.Swap1(10, 5);
            Console.WriteLine("---------------extension method start ");
            string text = "Hello, world! Welcome to the C# extension methods tutorial.";
            int len = text.MyExtention();
            Console.WriteLine(len);
            Console.WriteLine("---------------extensition methods end");
            Console.WriteLine("----find the word of maxlength form string ");
          int maxres=  Listprogram.GetMaxLenthWord("Hello prabhat how are you whatsapp");
            Console.WriteLine(maxres);
            Console.WriteLine("----find the word of maxlength form string ");
            //    double sqrtresult= Math.Sqrt(32);
            //   Console.WriteLine("Sqrt of pridefined function :{0}", sqrtresult);

            //   Console.WriteLine("sqrt of given nu:: {0}",Listprogram.GetSquare(32));

            //   Console.WriteLine("Try programiz.pro");
            //   string res = GetUniqueCharacter("hello there");
            //   Console.WriteLine("----------------");
            //   Listprogram lp =new Listprogram();
            //int resultofgetpow=   Listprogram.GetPow(3, 4);
            //   Console.WriteLine("Called to GetPow:{0}", resultofgetpow);

            //   Console.WriteLine("------------");
            //   Countcharacter(res);
            //   Console.WriteLine("------------");
            //   Countcharacter("hello there");
            var Getinstance = Singleton.Instance;
            Console.WriteLine("instance of Singleton :{0}",Getinstance);
        }
    }
}

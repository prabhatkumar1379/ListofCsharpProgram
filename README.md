This File contain List of C# program.
1> W.a.p to get n number of y power.


// this program will take two argument number and power and number will multiply with self for power time
//example 3^4 = 3*3*3*3 =81  result = number for(int i=1 ; i< power; i++)
//1*3 *3 * 3 * 3 = 81 if we assign result =1 and in for loop for(int i=1 ; j<=power; i++)
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
    }
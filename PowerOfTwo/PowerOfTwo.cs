using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public class PowerOfTwo
    {
        static void Main(string[] args)
        {
            int inputNumber;
            bool isPowerOfTwo;

            Console.WriteLine("Введите число:");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            isPowerOfTwo = CheckPowerOfTwo(inputNumber);
            if (isPowerOfTwo)
                Console.WriteLine($"число {inputNumber} это степень двойки");
            else
                Console.WriteLine($"число {inputNumber} это не степень двойки");
            Console.ReadKey();
        }
        public static bool CheckPowerOfTwo(int n)
        {
            return n != 0 && (n & (n - 1)) == 0;
        }

        public static bool CheckPowerOfTwoRecursive(int n)
        {
            if (n == 1)
                return true;
            if (n == 0 | n % 2 == 1 | n < 0)
                return false;
            else return CheckPowerOfTwoRecursive(n / 2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Tasks
{
    public class TasksSolution
    {
        static void Main(string[] args)
        {
            // Первое задание
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
        public static bool CheckPowerOfTwo(int n) //функция для первого задания
        {
            return n != 0 && (n & (n - 1)) == 0;
        }

        public static bool CheckPowerOfTwoRecursive(int n) //рекурсивная версия для второго задания
        {
            if (n == 1)
                return true;
            if (n == 0 | n % 2 == 1 | n < 0)
                return false;
            else return CheckPowerOfTwoRecursive(n / 2);
        }
        public static string StringTurnOver(string s) //четвертое задание
        {
            StringBuilder str = new StringBuilder(s);
            for (int i = 0; i < str.Length / 2; i++)
            {
                char a = str[str.Length - i - 1];
                str[str.Length - i - 1] = str[i];
                str[i] = a;
            }
            return str.ToString();
        }
             public static int FindPair(int[] arr) // Пятое задание
             {
                var pair = arr.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => y.Key).ToList();
                return Convert.ToInt32(pair[0]); 
             }
        


    }

}
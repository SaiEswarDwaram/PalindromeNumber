using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,rem,reverse = 0;
            int original;
            Console.WriteLine("Enter the number");
            num1 = Convert.ToInt32(Console.ReadLine());
            original = num1;

            while (num1 !=0)
            {
                rem = num1 % 10;
                reverse = reverse * 10 + rem;
                num1 = num1 / 10;

            }
            if (reverse == original)
                Console.WriteLine($"{original} is a palindrome");
            else
                Console.WriteLine($"{original} is not a palindrome");

        }
    }
}

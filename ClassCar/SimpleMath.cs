using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace carProject
{
    public class SimpleMath
    {
        public int LastResult { get; private set; }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Result of {a} - {b} = {LastResult}");
        }
        public void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }
            LastResult = a / b;
            Console.WriteLine($"Result of {a} / {b} = {LastResult}");
        }
    }
}

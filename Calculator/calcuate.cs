using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class calcuate
    {
        
        public int plus(int a,int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
        public int multiplication(int a, int b)
        {
            return a * b;
        }
        public float division(int a, int b)
        {
            //float c;
            //(float)number
            return (float)a / b;
        }
        public void Equals(int a,int b)
        {
            if (a == b)
                Console.WriteLine("这两个整数相等");
            else
                Console.WriteLine("这两个整数不相等");
        }
    }
}

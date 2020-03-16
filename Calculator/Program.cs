using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要进行运算的两个整数：");   
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            calcuate ca = new calcuate();
            if (a % 1 != 0 || b % 1 != 0)
            {
                Console.WriteLine("输入错误！ 请重新输入");
                int i = Convert.ToInt32(Console.ReadLine());
                int j = Convert.ToInt32(Console.ReadLine());
                a = i;
                b = j;
            }
            else
            if (a % 1 == 0 & b % 1 == 0)
            {
                Console.WriteLine("输入正确，请继续选择相应的操作");
                Console.WriteLine("*********选择加法请按1********");
                Console.WriteLine("*********选择减法请按2********");
                Console.WriteLine("*********选择乘法请按3********");
                Console.WriteLine("*********选择除法请按4********");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m == 1)
                {
                    Console.WriteLine(ca.plus(a, b));
                }
                //ca.Equals
                else
                    if (m == 2)
                {
                    
                    Console.WriteLine(ca.minus(a, b));
                }
                else
                    if (m == 3)
                {
                    Console.WriteLine(ca.multiplication(a, b));
                }
                
                else
                    if (m == 4)
                {
                    Console.WriteLine(ca.division(a, b));
                }
                else
                    Console.WriteLine("输入错误！");
            }
            ca.Equals(a, b);    

            
            
        }
    }
}

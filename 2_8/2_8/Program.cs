using System;

namespace _2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Yunsuan yunsuan = new Yunsuan();
            Console.WriteLine("请输入运算式");
            try
            {
                Console.Write("请输入第一个数字：");
                string x = Console.ReadLine();
                yunsuan.X = Convert.ToDouble(x);
                Console.Write("请输入要进行运算的运算符");
                string str = Console.ReadLine();
                Console.Write("请输入第二个数字：");
                string y = Console.ReadLine();
                yunsuan.Y = Convert.ToDouble(y);
                switch (str)
                {
                    case "+":
                        yunsuan.JiaFa();
                        break;
                    case "-":
                        yunsuan.JiaFa();
                        break;
                    case "*":
                        yunsuan.ChenFa();
                        break;
                    case "/":
                        yunsuan.ChuFa();
                        break;
                    default:
                        Console.WriteLine("请输入+ - * /四个运算其中的一个");
                        break;
                }
                yunsuan.Equals();
            }
            catch
            {
                Console.WriteLine("运算式获取错误");
            }
            Yunsuan2 yunsuan2 = new Yunsuan2();
            Console.WriteLine("请输入运算式");
            try
            {
                Console.Write("请输入第一个字符：");
                yunsuan2.X = Console.ReadLine();
                Console.Write("请输入要进行运算的运算符");
                string str = Console.ReadLine();
                Console.Write("请输入第二个字符：");
                yunsuan2.Y = Console.ReadLine();
                switch (str)
                {
                    case "+":
                        yunsuan2.JiaFa();
                        break;
                    case "-":
                        yunsuan2.JianFa();
                        break;
                    default:
                        Console.WriteLine("请输入+ - 两个运算其中的一个");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("运算式获取错误");
            }
        }
    }
}

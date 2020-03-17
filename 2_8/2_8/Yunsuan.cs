using System;
using System.Collections.Generic;
using System.Text;

namespace _2_8
{
    class Yunsuan
    {
        double x;
        double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public void JiaFa()
        {
            try
            {
                Console.WriteLine(x + "+" + y + "=" + (x + y));
            }
            catch
            {
                Console.WriteLine("不能进行运算!!!");
            }
        }
        public void JianFa()
        {
            try
            {
                Console.WriteLine(x + "-" + y + "=" + (x - y));
            }
            catch
            {
                Console.WriteLine("不能进行运算!!!");
            }
        }
        public void ChenFa()
        {
            try
            {
                Console.WriteLine(x + "*" + y + "=" + (x * y));
            }
            catch
            {
                Console.WriteLine("不能进行运算!!!");
            }
        }
        public void ChuFa()
        {
            try
            {
                if (y == 0)
                    Console.WriteLine("除数不能为0");
                else
                    Console.WriteLine(x + "/" + y + "=" + (x / y));
            }
            catch
            {
                Console.WriteLine("不能进行运算!!!");
            }
        }
        public void Equals()
        {
            int x1 = (int)x;
            int y1 = (int)y;
            if (x1 == y1)
                Console.WriteLine(x1 + "和" + y1 + "这两个整数相等");
            else
                Console.WriteLine(x1 + "和" + y1 + "这两个整数不相等");
        }
    }
}

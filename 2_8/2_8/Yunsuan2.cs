using System;
using System.Collections.Generic;
using System.Text;

namespace _2_8
{
    class Yunsuan2
    {
        string x;
        string y;

        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
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
            string str=x;
            try
            {
                foreach (char i in str)
                {
                    foreach (char j in y)
                        if (j == i)
                        {
                            str = str.Replace(j,' ');
                        }
                }
                Console.WriteLine(x + "-" + y + "="+str);
            }
            catch
            {
                Console.WriteLine("不能进行运算!!!");
            }
        }
    }
}

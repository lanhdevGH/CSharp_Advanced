using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class LearnDelegate
    {
        // Minh họa Func
        public Func<int, int, int> myFunc;  // myFunc lúc này là thuộc tính.
        //public delegate int MyFunc(int num1, int num2); // ---> MyFunc là một kiểu dữ liệu

        public int CalSumTwoNumber(int num1, int num2)
        {
            Console.WriteLine(num1 + "+" + num2);
            return num1 + num2;
        }

        public int CalSubTwoNumber(int num1, int num2)
        {
            Console.WriteLine(num1 + "-" + num2);
            return num1 - num2;
        }

        public void Calculation(int type, int a, int b) // type: 1-Cộng  2-Trừ
        {
            Dictionary<int, Func<int, int, int>> listFunc = new Dictionary<int, Func<int, int, int>>
            {
                { 1, CalSumTwoNumber },
                { 2, CalSubTwoNumber },
            };
            myFunc = listFunc[type];
            Console.WriteLine("Kết quả: " + myFunc(a,b));
        }
    }
}

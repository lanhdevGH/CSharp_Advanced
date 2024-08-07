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
        // Minh họa Action -- tương tự như ví dụ Delegate nhưng lần này chúng ta sẽ dùng Action<string>
        public Action<string> ShowLog; // Show log lúc này là một properties
        // Tương đương với việc khai báo:
        //public delegate void ShowLog(string message);   // --> ShowLog lúc này là một kiểu dữ liệu

        public void ShowLog_Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------Info message------");
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void ShowLog_Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------Warning message------");
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void ShowLog_Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------Error message------");
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void ShowMessageWithType(int type, string message)
        {
            Dictionary<int, Action<string>> actionCollect = new Dictionary<int, Action<string>>
            {
                { 1, ShowLog_Info },
                { 2, ShowLog_Warning },
                { 3, ShowLog_Error},
            };

            ShowLog = actionCollect[type];  // Không cần khởi tạo một instance mới
            ShowLog?.Invoke(message);
        }
    }
}

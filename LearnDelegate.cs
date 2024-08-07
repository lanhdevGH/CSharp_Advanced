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
        public delegate void ShowLog(string message); // Khai báo delegate dùng để show dữ liệu với kiểu trả về là void và nhận vào một chuỗi string

        public void ShowLog_Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info: " + message);
            Console.ResetColor();
        }

        public void ShowLog_Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warning: " + message);
            Console.ResetColor();
        }

        public void ShowLog_Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
            Console.ResetColor();
        }

        // Excuse
        public void ShowLogWithType(int type, string myMessage) // 0: Cả ba   1: Info   2: Warning  3: Error
        {
            ShowLog showLog;
            Dictionary<int, ShowLog> functionMap = new Dictionary<int, ShowLog>()
            {
                { 1, ShowLog_Info },
                { 2, ShowLog_Warning },
                { 3, ShowLog_Error },
            };
            if (type == 0)
            {
                showLog = ShowLog_Info;
                showLog += ShowLog_Warning;
                showLog += ShowLog_Error;
            }
            else
            {
                showLog = functionMap[type];
            }
            showLog.Invoke(myMessage);
        }
    }
}

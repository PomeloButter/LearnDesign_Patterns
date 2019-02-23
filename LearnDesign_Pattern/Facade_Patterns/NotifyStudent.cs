using System;

namespace LearnDesign_Pattern.Facade_Patterns
{
    public class NotifyStudent
    {
        public bool Notify(string studentName)
        {
            Console.WriteLine("正在向{0}发生通知", studentName);
            return true;
        }
    }
}
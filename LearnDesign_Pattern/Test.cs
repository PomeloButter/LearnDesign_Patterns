using System;
using System.Collections.Generic;
using System.Text;
using LearnDesigin_Pattern.SimpleFactory;
using LearnDesigin_Pattern.Singleton_Patterns;

namespace LearnDesigin_Pattern
{
    class Test
    {
        public static void Main(string[] args)
        {
            //单例模式
            Console.WriteLine("---------Singleton----------");
            Singleton s1 = Singleton.GetSingleton();
            Singleton s2 = Singleton.GetSingleton();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
           
            Console.WriteLine("---------SimpleFactory----------");
            Food f1 = SimpleFoodFactory.CreateFood("A");
            f1.Print();
            Food f2 = SimpleFoodFactory.CreateFood("B");
            f2.Print();
            Console.ReadLine();
        }
    }
}

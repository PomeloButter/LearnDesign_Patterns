using System;
using LearnDesigin_Pattern.SimpleFactory;
using LearnDesigin_Pattern.Singleton_Patterns;
using LearnDesign_Pattern.Factory;
using Food = LearnDesign_Pattern.Factory.Food;

namespace LearnDesign_Pattern
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
           
            //简单工厂模式
            Console.WriteLine("---------SimpleFactory----------");
            LearnDesigin_Pattern.SimpleFactory.Food f1 = SimpleFoodFactory.CreateFood("A");
            f1.Print();
            LearnDesigin_Pattern.SimpleFactory.Food f2 = SimpleFoodFactory.CreateFood("B");
            f2.Print();
           
            //工厂模式
            Console.WriteLine("---------Factory----------");
            Creator shreddedPorkWithPotatoesFactory=new ShreddedPorkWithPotatoesFactory();
            Creator tomatoScrambledEggsFactory=new TomatoScrambledEggsFactory();
            Creator minceMeatEggplantFactor=new MincedMeatEggplantFactory();
            Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();

            Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();

            Food minceMeatEggplant = minceMeatEggplantFactor.CreateFoodFactory();
            minceMeatEggplant.Print();
            
            Console.ReadLine();
        }
    }
}

using System;
using LearnDesigin_Pattern.Singleton_Patterns;
using LearnDesign_Pattern.Factory;
using LearnDesign_Pattern.SimpleFactory;
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
            SimpleFactory.Food f1 = SimpleFoodFactory.CreateFood("TomaoScrambledEggs");
            f1.Print();
            SimpleFactory.Food f2 = SimpleFoodFactory.CreateFood("ShreddedPorkWithPotatoes");
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

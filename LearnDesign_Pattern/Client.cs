using System;
using LearnDesigin_Pattern.Singleton_Patterns;
using LearnDesign_Pattern.AbstractFactory;
using LearnDesign_Pattern.Builder_Patterns;
using LearnDesign_Pattern.Factory;
using LearnDesign_Pattern.Prototype_Patterns;
using LearnDesign_Pattern.SimpleFactory;
using Food = LearnDesign_Pattern.Factory.Food;

namespace LearnDesign_Pattern
{
    public class Client
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

            //抽象工厂模式
            Console.WriteLine("---------AbstractFactory----------");
            AbstractFactory.AbstractFactory nanChangFactory=new NanChangFactory();

            nanChangFactory.CreateYaBo().Print();
            nanChangFactory.CreateYaJia().Print();

            AbstractFactory.AbstractFactory shangHaiFactory=new ShangHaiFactory();

            shangHaiFactory.CreateYaBo().Print();
            shangHaiFactory.CreateYaJia().Print();

            AbstractFactory.AbstractFactory huNanFactory=new HuNanFactory();
            huNanFactory.CreateYaBo().Print();
            huNanFactory.CreateYaJia().Print();
           

            //建造者模式
            Console.WriteLine("---------Builder_Patterns----------");
            Director director=new Director();
            Builder b1=new BuildFirst();
            Builder b2=new BuildSecond();

            director.Construct(b1);
            Computer c1 = b1.GetComputer();
            c1.Show();

            director.Construct(b2);
            Computer c2 = b2.GetComputer();
            c2.Show();
         

            //原型模式
            Console.WriteLine("---------Prototype_Patterns----------");

            MonkeyKingPrototype prototype=new ConcretePrototype("pipixiong");

            MonkeyKingPrototype cloneMonkeyKingPrototype = prototype.Clone() as ConcretePrototype;
            Console.WriteLine("1:"+cloneMonkeyKingPrototype?.Id);

            MonkeyKingPrototype clonePrototype = prototype.Clone() as ConcretePrototype;
            Console.WriteLine("2:" + cloneMonkeyKingPrototype?.Id);

            Console.ReadLine();
        }
    }
}

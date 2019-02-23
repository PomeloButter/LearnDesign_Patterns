using System;
using LearnDesign_Pattern.AbstractFactory_Patterns;
using LearnDesign_Pattern.Adapter_Patterns;
using LearnDesign_Pattern.Bridge_Patterns;
using LearnDesign_Pattern.Builder_Patterns;
using LearnDesign_Pattern.Decorator_Patterns;
using LearnDesign_Pattern.Factory_Patterns;
using LearnDesign_Pattern.Prototype_Patterns;
using LearnDesign_Pattern.SimpleFactory_Patterns;
using LearnDesign_Pattern.Singleton_Patterns;

namespace LearnDesign_Pattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            //单例模式
            Console.WriteLine("---------Singleton----------");
            var s1 = Singleton.GetSingleton();
            var s2 = Singleton.GetSingleton();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            //简单工厂模式
            Console.WriteLine("---------SimpleFactory----------");
            var f1 = SimpleFoodFactory.CreateFood("TomaoScrambledEggs");
            f1.Print();
            var f2 = SimpleFoodFactory.CreateFood("ShreddedPorkWithPotatoes");
            f2.Print();

            //工厂模式
            Console.WriteLine("---------Factory----------");
            Creator shreddedPorkWithPotatoesFactory = new ShreddedPorkWithPotatoesFactory();
            Creator tomatoScrambledEggsFactory = new TomatoScrambledEggsFactory();
            Creator minceMeatEggplantFactor = new MincedMeatEggplantFactory();
            var tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();

            var shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();

            var minceMeatEggplant = minceMeatEggplantFactor.CreateFoodFactory();
            minceMeatEggplant.Print();

            //抽象工厂模式
            Console.WriteLine("---------AbstractFactory----------");
            AbstractFactory nanChangFactory = new NanChangFactory();

            nanChangFactory.CreateYaBo().Print();
            nanChangFactory.CreateYaJia().Print();

            AbstractFactory shangHaiFactory = new ShangHaiFactory();

            shangHaiFactory.CreateYaBo().Print();
            shangHaiFactory.CreateYaJia().Print();

            AbstractFactory huNanFactory = new HuNanFactory();
            huNanFactory.CreateYaBo().Print();
            huNanFactory.CreateYaJia().Print();


            //建造者模式
            Console.WriteLine("---------Builder_Patterns----------");
            var director = new Director();
            Builder b1 = new BuildFirst();
            Builder b2 = new BuildSecond();

            director.Construct(b1);
            var c1 = b1.GetComputer();
            c1.Show();

            director.Construct(b2);
            var c2 = b2.GetComputer();
            c2.Show();


            //原型模式
            Console.WriteLine("---------Prototype_Patterns----------");

            MonkeyKingPrototype prototype = new ConcretePrototype("pipixiong");

            MonkeyKingPrototype cloneMonkeyKingPrototype = prototype.Clone() as ConcretePrototype;
            Console.WriteLine("1:" + cloneMonkeyKingPrototype?.Id);

            MonkeyKingPrototype clonePrototype = prototype.Clone() as ConcretePrototype;
            Console.WriteLine("2:" + cloneMonkeyKingPrototype?.Id);

            //适配器模式
            Console.WriteLine("---------Adapter_Patterns----------");
            ThreeHole threeHole = new PowerAdapter();
            threeHole.Request();

            //桥接模式
            Console.WriteLine("---------Bridge_Patterns----------");
            RemoteControl remoteControl = new ConcreteRemote();
            remoteControl.Implementor = new XiaoMi();
            remoteControl.On();
            remoteControl.Off();
            remoteControl.SetChannel();

            remoteControl.Implementor = new Samsung();
            remoteControl.On();
            remoteControl.Off();
            remoteControl.SetChannel();


            //装饰者模式
            Console.WriteLine("---------Decorator_Patterns----------");
            Phone phone = new ApplePhone();
            Decorator stickerDecorator = new Sticker(phone);
            stickerDecorator.Print();

            Console.WriteLine("---------");
            Decorator accessoriesDecorator = new Accessories(phone);
            accessoriesDecorator.Print();

            Console.WriteLine("---------");
            var sticker = new Sticker(phone);
            var accessories = new Accessories(sticker);
            accessories.Print();

            Console.ReadLine();
        }
    }
}
﻿using System;
using LearnDesign_Pattern.AbstractFactory_Patterns;
using LearnDesign_Pattern.Adapter_Patterns;
using LearnDesign_Pattern.Bridge_Patterns;
using LearnDesign_Pattern.Builder_Patterns;
using LearnDesign_Pattern.Command_Patterns;
using LearnDesign_Pattern.Composite_Patterns;
using LearnDesign_Pattern.Decorator_Patterns;
using LearnDesign_Pattern.Facade_Patterns;
using LearnDesign_Pattern.Factory_Patterns;
using LearnDesign_Pattern.Flyweight_Patterns;
using LearnDesign_Pattern.Prototype_Patterns;
using LearnDesign_Pattern.Proxy_Patterns;
using LearnDesign_Pattern.SimpleFactory_Patterns;
using LearnDesign_Pattern.Singleton_Patterns;
using LearnDesign_Pattern.Template_Patterns;

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

            //组合模式
            Console.WriteLine("---------Composite_Patterns----------");
            var complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            complexGraphics.Add(new Line("线A"));
            var complexGraphicsCG = new ComplexGraphics("一个圆和一条线组成的复杂图形");
            complexGraphicsCG.Add(new Circle("圆"));
            complexGraphicsCG.Add(new Line("线B"));
            complexGraphics.Add(complexGraphicsCG);
            var line = new Line("线C");
            complexGraphics.Add(line);

            Console.WriteLine("复杂图形的绘制如下：");
            Console.WriteLine("---------------------");
            complexGraphics.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("---------------------");

            complexGraphics.Remove(line);
            Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
            Console.WriteLine("---------------------");
            complexGraphics.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("---------------------");

            //外观模式
            Console.WriteLine("---------Facade_Patterns----------");
            var facade = new RegistrationFacade();
            if (facade.RegisterCourse("设计模式", "pomelo"))
                Console.WriteLine("选课成功");
            else
                Console.WriteLine("选课失败");

            //享元模式
            Console.WriteLine("---------Flyweight_Patterns----------");

            var externalstate = 10;
            var factory = new FlyweightFactory();
            var flyweightA = factory.GetfFlyweight("A");
            flyweightA?.Operation(externalstate);

            var flyweightB = factory.GetfFlyweight("B");
            flyweightB?.Operation(externalstate);
            var flyweightC = factory.GetfFlyweight("C");
            flyweightC?.Operation(externalstate);

            var flyweightD = factory.GetfFlyweight("D");
            if (flyweightD != null)
            {
                flyweightD.Operation(externalstate);
            }
            else
            {
                Console.WriteLine("驻留池中不存在字符串D");
                // 这时候就需要创建一个对象并放入驻留池中
                var d = new ConcreteFlyweight("D");
                factory.Flyweights.Add("D", d);
            }
            //代理模式
            Console.WriteLine("---------Proxy_Patterns----------");
            Person proxy=new Friend();
            proxy.BuyProduct();

            //模板方法
            Console.WriteLine("---------Template_Patterns----------");
            Spinach spinach=new Spinach();
            spinach.cookVegetable();
            
            

            //命令模式
            Console.WriteLine("---------Command_Patterns----------");
            Receiver receiver=new Receiver();
            Command command=new ConcreteCommand(receiver);
            Invoke invoke=new Invoke(command);
            invoke.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
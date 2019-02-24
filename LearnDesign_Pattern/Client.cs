using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
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
using LearnDesign_Pattern.Iterator_Patterns;
using LearnDesign_Pattern.Mediator_Patterns;
using LearnDesign_Pattern.Memento_Patterns;
using LearnDesign_Pattern.Observer_Patterns;
using LearnDesign_Pattern.Prototype_Patterns;
using LearnDesign_Pattern.Proxy_Patterns;
using LearnDesign_Pattern.Responsibility_Patterns;
using LearnDesign_Pattern.SimpleFactory_Patterns;
using LearnDesign_Pattern.Singleton_Patterns;
using LearnDesign_Pattern.State_Patterns;
using LearnDesign_Pattern.Stragety_Patterns;
using LearnDesign_Pattern.Template_Patterns;
using LearnDesign_Pattern.Vistor_Patterns;

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
            Person proxy = new Friend();
            proxy.BuyProduct();

            //模板方法
            Console.WriteLine("---------Template_Patterns----------");
            var spinach = new Spinach();
            spinach.cookVegetable();


            //命令模式
            Console.WriteLine("---------Command_Patterns----------");
            var receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            var invoke = new Invoke(command);
            invoke.ExecuteCommand();

            //迭代器模式
            Console.WriteLine("---------Iterator_Patterns----------");
            IListCollection list = new ConcreteList();
            var terator = list.GetITerator();
            while (terator.MoveNext())
            {
                var i = (int) terator.GetCurrent();
                Console.WriteLine(i.ToString());
                terator.Next();
            }

            //观察者模式
            Console.WriteLine("---------Observer_Patterns----------");
            TenXun tenXun = new TenXunGame("LOL", "游戏需要更新");
            tenXun.AddObserver(new Subscriber("pomelo"));
            tenXun.AddObserver(new Subscriber("yuuko"));
            tenXun.Update();
            //中介者模式
            Console.WriteLine("---------Mediator_Patterns----------");
            AbstractCardPartner a = new ParterA();
            AbstractCardPartner b = new ParterB();
            a.MoneyCount = 20;
            b.MoneyCount = 20;
            AbstractMediator mediator = new MediatorPater(a, b);
            a.ChangCount(5, mediator);
            Console.WriteLine("A现在的钱是：{0}", a.MoneyCount);
            Console.WriteLine("B现在的钱是：{0}", b.MoneyCount);

            b.ChangCount(10, mediator);
            Console.WriteLine("A现在的钱是：{0}", a.MoneyCount);
            Console.WriteLine("B现在的钱是：{0}", b.MoneyCount);

            //状态者模式
            Console.WriteLine("---------state_Patterns----------");
            var account = new Account("pomelo");
            account.Deposit(1000);
            account.Deposit(200);
            account.Deposit(600);
            account.PayInterest();
            account.Withdraw(2000);
            account.Withdraw(500);
            //策略者模式
            Console.WriteLine("---------stragety_Patterns----------");
            var operation = new InterestOperation(new PersonalTaxStrategy());
            Console.WriteLine("个人支付的税为：{0}", operation.GetTax(5000.00));

            operation = new InterestOperation(new EnterpriseTaxStrategy());
            Console.WriteLine("企业支付的税为：{0}", operation.GetTax(50000.00));
            //责任链模式
            Console.WriteLine("---------Responsibility_Patterns----------");
            var purchaseRequest = new PurchaseRequest(4000, "phone");
            var softPurchaseRequest = new PurchaseRequest(10000, "vs");
            var computeRequest = new PurchaseRequest(40000, "computer");


            Approver manager = new Manager("pomelo");
            Approver vp = new VicePresident("yuuko");
            Approver pre = new President("jesse");

            manager.NextApprover = vp;
            vp.NextApprover = pre;

            manager.ProcessRequest(purchaseRequest);
            manager.ProcessRequest(softPurchaseRequest);
            manager.ProcessRequest(computeRequest);

            //访问者模式
            Console.WriteLine("---------Vistor_Patterns----------");
            var objectStructure = new ObjectStructure();
            foreach (Element e in objectStructure.Elements) e.Accept(new ConcreteVistor());

            //备忘录模式
            Console.WriteLine("---------Memento_Patterns----------");

            var persons = new List<ContactPerson>
            {
                new ContactPerson {Name = "Pomelo", MobileNum = "123445"},
                new ContactPerson {Name = "Yuuko", MobileNum = "234565"},
                new ContactPerson {Name = "Jeese ", MobileNum = "231455"}
            };
            var mobileOwner = new MobileOwner(persons);
            mobileOwner.Show();

            var caretaker = new Caretaker();
            caretaker.ContactMementoDic.Add(DateTime.Now.ToString(CultureInfo.InvariantCulture),
                mobileOwner.CreateContactMemento());

            Console.WriteLine("----移除最后一个联系人--------");
            mobileOwner.ContactPersons.RemoveAt(2);
            mobileOwner.Show();
            Thread.Sleep(1000);
            caretaker.ContactMementoDic.Add(DateTime.Now.ToString(CultureInfo.InvariantCulture),
                mobileOwner.CreateContactMemento());

            Console.WriteLine("-------恢复联系人列表,请从以下列表选择恢复的日期------");
            var keyCollection = caretaker.ContactMementoDic.Keys;
            foreach (var k in keyCollection) Console.WriteLine("Key = {0}", k);
            while (true)
            {
                Console.Write("请输入数字,按窗口的关闭键退出:");

                var index = -1;
                try
                {
                    index = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入的格式错误");
                    continue;
                }

                if (index < keyCollection.Count &&
                    caretaker.ContactMementoDic.TryGetValue(keyCollection.ElementAt(index), out var contactMentor))
                {
                    mobileOwner.RestoreMemento(contactMentor);
                    mobileOwner.Show();
                }
                else
                {
                    Console.WriteLine("输入的索引大于集合长度！");
                }
            }
        }
    }
}
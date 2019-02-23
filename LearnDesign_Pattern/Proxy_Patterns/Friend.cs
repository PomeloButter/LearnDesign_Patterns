using System;

namespace LearnDesign_Pattern.Proxy_Patterns
{
    public class Friend:Person
    {
        private RealBuyPerson _realBuyPerson;
        public override void BuyProduct()
        {
            Console.WriteLine("通过代理类访问真实实体对象的方法");
            if (_realBuyPerson==null)
            {
                _realBuyPerson = new RealBuyPerson();
            }
            this.PreBuyProduct();
            _realBuyPerson.BuyProduct();
            this.PostBuyProduct();
        }

        public void PreBuyProduct()
        {
            // 可能不知一个朋友叫这位朋友带东西，首先这位出国的朋友要对每一位朋友要带的东西列一个清单等
            Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带Iphone...........");
        }
        public void PostBuyProduct()
        {
            Console.WriteLine("终于买完了，现在要对东西分一下，相机是张三的；Iphone是李四的..........");
        }
    }
}
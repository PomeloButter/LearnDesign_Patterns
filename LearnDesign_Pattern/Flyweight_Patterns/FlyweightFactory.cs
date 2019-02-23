using System;
using System.Collections.Generic;

namespace LearnDesign_Pattern.Flyweight_Patterns
{
    public class FlyweightFactory
    {
        public Dictionary<string, Flyweight> Flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            Flyweights.Add("A", new ConcreteFlyweight("A"));
            Flyweights.Add("B", new ConcreteFlyweight("B"));
            Flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetfFlyweight(string key)
        {
            Flyweight flyweight;
            try
            {
                flyweight = Flyweights[key];
            }
            catch (Exception)
            {
                Console.WriteLine("驻留池中不存在字符串" + key);
                flyweight = new ConcreteFlyweight(key);
            }

            return flyweight;
        }
    }
}
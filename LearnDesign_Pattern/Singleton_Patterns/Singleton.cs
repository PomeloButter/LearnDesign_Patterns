namespace LearnDesigin_Pattern.Singleton_Patterns
{
    /// <summary>
    /// 单例模式也就是保证一个类只有一个实例的一种实现方法
    /// 确保一个类只有一个实例,并提供一个全局访问点。
    /// </summary>
    class Singleton
    {       
        private static Singleton _singleton;
             

        private Singleton()
        {
        }
        //获取单例
        public static Singleton GetSingleton()
        {
            return _singleton ?? (_singleton = new Singleton());
        }

    }
}
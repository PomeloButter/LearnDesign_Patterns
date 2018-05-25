namespace LearnDesigin_Pattern.Singleton_Patterns
{
    /// <summary>
    /// 多线程下的单例
    /// </summary>
    class ThreadSingleton
    {
        private static ThreadSingleton _threadSingleton;
        // 定义一个标识来确保线程同步
        private static readonly object Locker = new object();
        private ThreadSingleton()
        {
        }
        public ThreadSingleton GetThreadSingleton()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            if (_threadSingleton != null) return _threadSingleton;
            lock (Locker)
            {
                if (_threadSingleton == null)
                {
                    // ReSharper disable once PossibleMultipleWriteAccessInDoubleCheckLocking
                    _threadSingleton = new ThreadSingleton();
                }
            }
            return _threadSingleton;
        }
    }
}
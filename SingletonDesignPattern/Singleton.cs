using System;
namespace Singleton
{
    class Pragrom 
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetSingleton;
            Console.ReadKey();
        }
    }
    public class Singleton
    {
        private readonly static Singleton instance = null;

        private Singleton()
        {

        }
        public static Singleton GetSingleton
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
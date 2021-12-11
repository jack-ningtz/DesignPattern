using System;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            Singleton a = Singleton.GetInstance;
            a.PrintDetails("from a");
        }
        private static void PrintStudentdetails()
        {
            Singleton b = Singleton.GetInstance;
            b.PrintDetails("from b");
        }
    }
    public sealed class Singleton
    {

        private static int counter = 0;
        private static  Singleton instance = null;
        private readonly static object locker = new Object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static Singleton GetInstance
        {
            get
            {
                // Double-checked locking mechanism.
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
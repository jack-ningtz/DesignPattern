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
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        
        private static readonly Lazy<Singleton> Instancelock =
                    new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
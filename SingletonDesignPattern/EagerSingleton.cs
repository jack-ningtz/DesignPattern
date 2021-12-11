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
        /// <summary>
        ///  Non-Lazy or Eager loading
        /// </summary>
        /// <returns></returns>
        private static readonly Singleton singleInstance = new Singleton(); 
        
        public static Singleton GetInstance
        {
            get
            {
                return singleInstance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
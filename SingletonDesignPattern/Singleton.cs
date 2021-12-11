using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Pragrom
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
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
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
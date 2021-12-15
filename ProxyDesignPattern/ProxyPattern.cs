using System;

namespace ProxyPattern
{
    class Program 
    {
        static void Main(String[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.ReadKey();
        }
    }
    public interface ISubject 
    {
        void Request();
    }
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("真是主题");
        }
    }
    public class Proxy : ISubject
    {
        private ISubject subject;

        // public Proxy()
        // {
        //     if(subject == null)
        //     {
        //         subject = new RealSubject();
        //     }
        // }
        public void Request() 
        {
            if(subject == null)
            {
                subject = new RealSubject();
            }
            PreRequest();
            subject.Request();
            PostRequest();
        }
        public void PreRequest()
        {
            Console.WriteLine("调用主题之前");
        }
        public void PostRequest() 
        {
            Console.WriteLine("调用主题之后");
        }
    }
}
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace PynamicProxy
{
    class Program
    {
        static void Main(String[] args)
        {
            Proxy<ISubject> proxy = new Proxy<ISubject>(new RealSubject());
            ISubject subject = (ISubject)proxy.GetTransparentProxy();
            int arg = 0;
            subject.Request(out arg);
            Console.WriteLine(arg);
            Console.ReadKey();
        }
    }

    public class Proxy<T> : RealProxy where T : class
    {
        MarshalByRefObject marshalByRefObject;
        public Proxy(MarshalByRefObject realT) : base(typeof(T))
        {
            marshalByRefObject = realT;
        }
        public override IMessage Invoke(IMessage myMessage)
        {
            IMethodCallMessage myCallMessage = (IMethodCallMessage)myMessage;
            Console.WriteLine("动态代理方法中：执行前");
            IMethodReturnMessage myIMethodReturnMessage = RemotingServices.ExecuteMessage(marshalByRefObject, myCallMessage);
            Console.WriteLine("动态代理方法中：执行后");
            return myIMethodReturnMessage;
        }
    }

    public interface ISubject
    {
        void Request(out int arg);
    }
    public class RealSubject : MarshalByRefObject, ISubject
    {
        public void Request(out int arg)
        {
            arg = 1;
            Console.WriteLine("真是主题");
        }
    }
}
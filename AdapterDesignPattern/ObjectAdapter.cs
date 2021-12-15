using System;

namespace ObjectAdapterDesignPattern
{
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new ObjectAdapter(adaptee);
            target.Service();
            Console.ReadKey();
        }
    }
    /// <summary>
    ///  Target
    ///  It is an interface and this interface needs to be implemented by 
    ///  the Adapter and the client can see only this interface.
    /// </summary>
    public interface ITarget 
    {
        void Service();
    }
    /// <summary>
    ///  Adaptee
    ///  This class contains the functionality which the client requires 
    ///  but it’s not compatible with the existing client code.
    /// </summary>
    public class Adaptee 
    {
        public void AService()
        {
            //适配者业务
            Console.WriteLine("The business code in the Adaptee is invoked");
        }
    }
    /// <summary>
    ///  Object adapter
    ///  This is a class that makes two incompatible systems work together
    /// </summary>
    public class ObjectAdapter : ITarget
    {
        private Adaptee adaptee;
        public ObjectAdapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Service()
        {
            adaptee.AService();
        }
    }
}
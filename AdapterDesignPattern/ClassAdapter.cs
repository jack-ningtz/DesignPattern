using System;

namespace ClassAdapterDesignPattern
{
    // Client
    class Pragrom
    {
        static void Main(string[] args)
        {
            ITarget target = new ClassAdapter();
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
    ///  class adapter
    ///  This is a class that makes two incompatible systems work together
    /// </summary>
    public class ClassAdapter :  Adaptee, ITarget
    {
        public void Service()
        {
            AService();
        }
    }
}
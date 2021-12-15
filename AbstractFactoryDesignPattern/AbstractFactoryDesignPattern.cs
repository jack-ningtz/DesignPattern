using System;
namespace AbstractFactoryDesignPattern
{
    //Test AbstractFactoryDesignPattern
    class Program
    {
        static void Main(string[] args)
        {
            IMessageFactory messageFactory = IMessageFactory.CreateMessageFactory("QQ");
            Message qq = messageFactory.CreateMessage();
            qq.SendMessage();
            Console.ReadKey();
        }
    }

    //Abstatct Product
    public abstract class Message
    {
        public abstract void SendMessage();
    }

    public class WeChat : Message
    {
        public override void SendMessage()
        {
            Console.WriteLine("WeChat Send Message!");
        }
    }
    public class QQ : Message
    {
        public override void SendMessage()
        {
            Console.WriteLine("QQ Send Message!");
        }
    }
    public abstract class IMessageFactory
    {
        public abstract Message CreateMessage();
        public static IMessageFactory CreateMessageFactory(string factoryType)
        {
            if (factoryType.Equals("QQ"))
            {
                return new QQFactory();
            }
            else if (factoryType.Equals("WeChat"))
            {
                return new WeChatFactory();
            }
            return null;
        }
    }
    public class QQFactory : IMessageFactory
    {
        public override Message CreateMessage()
        {
            return new QQ();
        }
    }
    public class WeChatFactory : IMessageFactory
    {
        public override Message CreateMessage()
        {
            return new WeChat();
        }
    }
}
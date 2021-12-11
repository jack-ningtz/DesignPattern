using System;
namespace  AbstractFactoryDesignPattern
{
    //Test AbstractFactoryDesignPattern
    class Pragrom
    {
        static void Main(string[] args)
        {
            IMessageFactory messageFactory = IMessageFactory.CreateMessageFactory("QQ");
            QQ  qq = messageFactory.CreateMessage();
            qq.SendMessage();
            Console.ReadKey();
        }
    }

    //Abstatct Product
    public interface Message
    {
        public void SendMessage();
    }

    public class WebChat : Message
    {
        public override void SendMessage()
        {
            Console.WriteLine("WebChat Send Message!");
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
        public Message CreateMessage();
        public static IMessageFactory CreateMessageFactory(string factoryType)
        {
            if(factoryType.Equals("QQ"))
            {
                return new QQFactory();
            }
            else if(factoryType.Equals("WebChat"))
            {
                return new WebChatFactory();
            }
            
        }
    }
    public class QQFactory : IMessageFactory
    {
        public override Message CreateMessage()
        {
            return new QQ();
        }
    }
    public class WebChatFactory : IMessageFactory
    {
        public override Message CreateMessge()
        {
            return new WebChat();
        }
    }
}
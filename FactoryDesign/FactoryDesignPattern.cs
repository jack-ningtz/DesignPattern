using System;
namespace FactoryDesignPattern
{
    // Test FactoryDesign
    class Program
    {
        static void Main(String[] args)
        {
             MessageFactory messageFactory = new MessageFactory();
             Message message = messageFactory.getMessageTool("webchat");
             message.SendInfo();
             Console.ReadLine();
        }
    }

    /// <summary>
    ///  abstract class
    /// </summary>
    public abstract class Message 
    {
        public abstract void SendInfo();
    }
    /// <summary>
    ///  class WebChat
    /// </summary>
    public class WebChat : Message
    {
        public override void SendInfo()
        {
            Console.WriteLine("WebChat Send Info");
        }
    }
    /// <summary>
    ///  class QQ
    /// </summary>
    public class QQ : Message
    {
        public override void SendInfo()
        {
            Console.WriteLine("QQ Send Info");
        }
    }
    public class MessageFactory
    {
        public Message getMessageTool(string toolname)
        {
            if(toolname.Equals("webchat"))
            {
                return new WebChat();
            }
            else if (toolname.Equals("QQ"))
            {
                return new QQ();
            }
            return null;
        }
    }
}
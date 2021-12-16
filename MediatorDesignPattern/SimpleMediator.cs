using System;
using System.Collections.Generic;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteUser Tom = new ConcreteUser("Tom");
            ConcreteUser Jack = new ConcreteUser("Jack");
            Tom.Send("Hello,Jack");
            Console.WriteLine("-------");
            Jack.Send("Hi,Tom");
            Console.ReadKey();
        }
    }
    //中介者
    public class ChatRoomMediator
    {
        public static ChatRoomMediator chatRoomMediator = new ChatRoomMediator();
        private ChatRoomMediator()
        {

        }
        public static ChatRoomMediator InstanceChatRoomMediator()
        {
            return chatRoomMediator;
        }
        private List<User> usersList = new List<User>();
        public void SendMessage(User user, string message)
        {
            foreach (var u in usersList)
            {
                // 发送者不接受
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }
    }
    public abstract class User
    {
        protected string Name;
        public User(string Name)
        {
            this.Name = Name;
            ChatRoomMediator chatRoomMediator = ChatRoomMediator.InstanceChatRoomMediator();
            chatRoomMediator.RegisterUser(this);
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    public class ConcreteUser : User
    {
        public ConcreteUser(string Name) : base(Name)
        {

        }
        public override void Send(string message)
        {
            ChatRoomMediator mediator = ChatRoomMediator.InstanceChatRoomMediator();
            Console.WriteLine(this.Name + ": 发送 " + message);
            mediator.SendMessage(this, message);

        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": 接收 " + message);
        }
    }
}
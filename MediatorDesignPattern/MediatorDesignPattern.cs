using System;
using System.Collections.Generic;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoomMediator chatRoomMediator = new ChatRoomMediator();
            ConcreteUser Tom = new ConcreteUser(chatRoomMediator, "Tom");
            ConcreteUser Jack = new ConcreteUser(chatRoomMediator, "Jack");
            chatRoomMediator.RegisterUser(Tom);
            chatRoomMediator.RegisterUser(Jack);

            Tom.Send("Hello,Jack");
            Console.WriteLine("-------");
            Jack.Send("Hi,Tom");
            Console.ReadKey();
        }
    }
    //中介者接口
    public interface IChatRoomMediator
    {
        void SendMessage(User user, string message);
        void RegisterUser(User user);
    }
    public class ChatRoomMediator : IChatRoomMediator
    {
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
        protected ChatRoomMediator mediator;
        public User(ChatRoomMediator mediator, string Name)
        {
            this.mediator = mediator;
            this.Name = Name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    public class ConcreteUser : User
    {
        public ConcreteUser(ChatRoomMediator mediator, string Name) : base(mediator, Name)
        {

        }
        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": 发送 " + message);
            mediator.SendMessage(this,message);

        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": 接收 " + message);
        }
    }
}
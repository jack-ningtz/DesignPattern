using System;
using System.Collections.Generic;
namespace ObserverDesignPattern
{
    class Program 
    {
        static void Main(string[] args) 
        {
            IObserver observerOne = new ConcreteObserverOne();
            IObserver observerTwo = new ConcreteObserverTwo();
            
            Subject subject = new ConcreteSubject();
            subject.Add(observerOne);
            subject.Add(observerTwo);
            subject.NotifyObserver();

            Console.ReadKey();
        }
    }
    public interface IObserver 
    {
        void Response();
    }
    public class ConcreteObserverOne : IObserver 
    {
        public void Response()
        {
            Console.WriteLine("具体观察者1回复");
        }
    } 
    public class ConcreteObserverTwo : IObserver 
    {
        public void Response()
        {
            Console.WriteLine("具体观察者2回复");
        }
    }
    public abstract class Subject 
    {
        protected List<IObserver> observersList = new List<IObserver>();
        public void Add(IObserver observer)
        {
            observersList.Add(observer);
        }
        public void Remove(IObserver observer) 
        {
            observersList.Remove(observer);
        }
        // 通知观察者
        public abstract void NotifyObserver();
    }
    public class ConcreteSubject : Subject
    {
        public override void NotifyObserver()
        {
            Console.WriteLine("状态发生改变-");
            foreach (var item in observersList)
            {
                item.Response();
            }
        }
    }

}
using System;
namespace MementoDesignPattern
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Originator or = new Originator();
            Caretaker cr = new Caretaker();
            or.SetState("State 1");
            Console.WriteLine("初始状态:" + or.GetState());
            cr.SetMemento(or.CreateMemento()); //保存状态      
            or.SetState("State 2");        
            Console.WriteLine("新的状态:" + or.GetState());
            or.RestoreMemento(cr.GetMemento()); //恢复状态
            Console.WriteLine("恢复状态:" + or.GetState()); 
            Console.ReadKey();
        }
    }
    public class Originator 
    {
        private string state;
        public void SetState(string state) 
        {
            this.state = state;
        }
        public string GetState()
        {
            return state;
        }
        public Memento CreateMemento() 
        {
            return new Memento(state);
        }
        public void RestoreMemento(Memento memento)
        {
            this.SetState(memento.GetState());

        }
    }
    public class Memento 
    {
        private string state;
        public Memento(string state) 
        {
            this.state = state;
        }
        public void SetState(string state) 
        {
            this.state = state;
        }
        public string GetState() 
        {
            return state;
        }
    }
    public class Caretaker 
    {
        private Memento memento;
        public void SetMemento(Memento memento) 
        {
            this.memento = memento;
        }
        public Memento GetMemento() 
        {
            return memento;
        }
    }
}
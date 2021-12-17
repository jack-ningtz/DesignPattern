using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ConcreteStateOne stateone = new ConcreteStateOne();
            ConcreteStateTwo statetwo = new ConcreteStateTwo();
            stateone.DoAction(context);
            Console.WriteLine(context.GetState().StateMessage());
            statetwo.DoAction(context);
            Console.WriteLine(context.GetState().StateMessage());
            Console.ReadKey();
        }
    }
    public interface State
    {
        void DoAction(Context context);
        string StateMessage();
    }
    public class ConcreteStateOne : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("调用状态一");
            context.SetState(this);
        }
        public string StateMessage()
        {
            return "当前状态一";
        }
    }
    public class ConcreteStateTwo : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("调用状态二");
            context.SetState(this);
        }
        public string StateMessage()
        {
            return "当前状态二";
        }
    }
    public class Context
    {
        public State state;
        public void SetState(State state)
        {
            this.state = state;
        }
        public State GetState()
        {
            return state;
        }
    }
}
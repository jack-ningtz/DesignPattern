using System;

namespace DecoratorDesignPattern
{
    class Program 
    {
        static void Main(string[] args) 
        {
            IComponent component  = new ConcreteComponent();
            component.Info();

            IComponent decorator = new ConcreteDecorator(component);
            decorator.Info();
            Console.ReadKey();
        }
    }
    // Component
    public interface IComponent 
    {
        void Info();
    }
    // ConcreteComponent
    public class  ConcreteComponent : IComponent 
    {
        public void Info() 
        {
            Console.WriteLine("This is Concrete Component");
        }
    }
    // Decorator
    public abstract class Decorator : IComponent
    {
        private IComponent component;
        public Decorator(IComponent component)
        {
            this.component = component;
        }
        public virtual void Info() 
        {
            component.Info();
        }
    }
    // ConcreteDecorator
    public class ConcreteDecorator : Decorator 
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
            
        }
        public override void Info()
        {
            base.Info();
            this.DecoratorInfo();
        }
        // 为ConcreteDecorator增加装饰功能
        public void DecoratorInfo()
        {
            Console.WriteLine("This is Decorator Mothed");
        }
    }
}
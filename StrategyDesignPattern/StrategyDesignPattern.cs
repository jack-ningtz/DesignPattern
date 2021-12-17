using System;

namespace StrategyDesignPattern
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Context context = new Context();
            IStrategy strategyA = new ConcreteStrategyA();
            context.SetStrategy(strategyA);
            context.StrategyMethod();
            IStrategy strategyB = new ConcreteStrategyB();
            context.SetStrategy(strategyB);
            context.StrategyMethod();
            Console.ReadKey();
        }
    }
    public interface IStrategy 
    {
        void StrategyMethod();
    }
    public class ConcreteStrategyA : IStrategy 
    {
        public void StrategyMethod() 
        {
            Console.WriteLine("This is Strategy A.");
        }
    }
    public class ConcreteStrategyB : IStrategy 
    {
        public void StrategyMethod() 
        {
            Console.WriteLine("This is Strategy B.");
        }
    }
    public class Context 
    {
        private IStrategy strategy;
        public IStrategy GetStrategy() 
        {
            return strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void StrategyMethod() 
        {
            strategy.StrategyMethod();
        }
    }
}
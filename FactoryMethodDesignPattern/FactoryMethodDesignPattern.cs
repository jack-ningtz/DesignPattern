using System;

namespace  FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new ConcreteFactory1().CreateProduct();
            product1.ShowInfo();
            Product product2 = new ConcreteFactory2().CreateProduct();
            product2.ShowInfo();        
            Console.ReadKey();
        }
    }
    public abstract class Product
    {
        public abstract void ShowInfo();
    }

    public class ConcreteProduct1 : Product
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Product1");
        }
    }

    public class ConcreteProduct2 : Product
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Product2");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract Product CreateProduct();
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProduct1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProduct2();
        }
    }
}
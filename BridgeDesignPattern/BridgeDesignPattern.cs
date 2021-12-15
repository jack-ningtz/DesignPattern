using System;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WoManCloths woManCloths = new WoManCloths(new WoMan());
            woManCloths.WearBy();
            ManCloths manCloths = new ManCloths(new Man());
            manCloths.WearBy();
            Console.ReadKey();
        }
    }
    // Implementor
    public interface Person
    {
        void Clothing();
    }
    // Concrete Implementor
    public class Man : Person
    {
        public void Clothing()
        {
            Console.WriteLine("I wear a shirt");
        }
    }
    // Concrete Implementor
    public class WoMan :Person
    {
        public void Clothing()
        {
            Console.WriteLine("I wear a dress");
        }
    }
    // Abstraction
    public abstract class AbstractClothes
    {
        protected Person person;
        protected AbstractClothes(Person person)
        {
            this.person = person;
        }
        public abstract void WearBy();
    }
    // Refined Abstraction
    public class ManCloths : AbstractClothes
    {
        public ManCloths(Person person) : base(person)
        {

        }
        public override void WearBy()
        {
            person.Clothing();
        }

    }
    // Refined Abstraction
    public class WoManCloths : AbstractClothes
    {
        public WoManCloths(Person person) : base(person)
        {

        }
        public override void WearBy()
        {
            person.Clothing();
        }
    }
}
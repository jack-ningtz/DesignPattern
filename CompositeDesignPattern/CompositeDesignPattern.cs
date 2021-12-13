using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite computer = new Composite("Computer");
            Composite Cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");

            IComponent mouse = new Leaf("Mouse");
            IComponent keyboard = new Leaf("Keyboard");
            IComponent ram = new Leaf("RAM");
            IComponent cpu = new Leaf("CPU");

            computer.AddComponent(Cabinet);
            computer.AddComponent(peripherals);

            Cabinet.AddComponent(ram);
            Cabinet.AddComponent(cpu);
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            computer.Info();
            Console.ReadKey();

        }
    }
    public interface IComponent
    {
        void Info();
    }
    public class Leaf : IComponent
    {
        public string Name { get; set; }

        public Leaf(string name)
        {
            this.Name = name;
        }
        public void Info()
        {
            Console.WriteLine(Name);
        }
    }
    public class Composite : IComponent
    {
        public string Name { get; set; }
        public Composite(string name)
        {
            this.Name = name;
        }
        List<IComponent> components = new List<IComponent>();
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DeleteComponent(IComponent component)
        {
            // TODO
        }
        public void UpdateComponent(IComponent component)
        {
            // TODO
        }
        public void Info()
        {
            Console.WriteLine(Name + " : ");
            foreach (var item in components)
            {
                item.Info();
            }
        }
    }
}
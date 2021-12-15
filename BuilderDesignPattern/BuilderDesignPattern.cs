using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
              Builder builder = new ConcreteBuilder();
              Director director = new Director();
              Computer computer = director.MakeComputer(builder);
              Console.WriteLine(computer.ToString());
              Console.ReadKey();
        }
    }
    //  Produst
    public class Computer
    {
        private LED led;
        private Keyboard keyboard;
        private Mouse mouse;
        private Cpu cpu;
        public void SetLED(LED led)
        {
            this.led  = led;
        }
        public void SetKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }
        public void SetMouse(Mouse mouse)
        {
            this.mouse = mouse;
        }
        public void SetCpu(Cpu cpu)
        {
            this.cpu = cpu;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class LED
    {
        public LED()
        {
            Console.WriteLine("Led has been made");
        }
    }
    public class Keyboard
    {
        public Keyboard()
        {
            Console.WriteLine("Keyboard has been made");
        }
    }
    public class Mouse
    {
        public Mouse()
        {
            Console.WriteLine("Mouse has been made");
        }
    }
    public class Cpu
    {
        public Cpu()
        {
            Console.WriteLine("Cpu has been made");
        }
    }
    // Builder
    public abstract class Builder 
    {
        //protected Computer computer = new Computer();
        protected Computer computer;
        public void CreateComputer()
        {
            computer = new Computer();
        }
        public abstract void BuilderLED();
        public abstract void BuilderKeyboard();
        public abstract void BuilderMouse();
        public abstract void BuilderCpu();

        public Computer GetComputer()
        {
            return computer;
        }
    }
    // ConcreteBuilder
    public class ConcreteBuilder : Builder
    {
        public override void BuilderLED()
        {
            computer.SetLED(new LED());
        }
        public override void BuilderKeyboard()
        {
            computer.SetKeyboard(new Keyboard());
        }
        public override void BuilderMouse()
        {
            computer.SetMouse(new Mouse());
        }
        public override void BuilderCpu()
        {
            computer.SetCpu(new Cpu());
        }
    }
    //Director
    public class Director
    {
        public Computer MakeComputer(Builder builder)
        {
            builder.CreateComputer();
            builder.BuilderLED();
            builder.BuilderKeyboard();
            builder.BuilderMouse();
            builder.BuilderCpu();
            return builder.GetComputer();
        }
    }
}

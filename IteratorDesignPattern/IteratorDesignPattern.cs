using System;
using System.Collections.Generic;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.Add(new Iterm(1, "TEST"));
            collection.Add(new Iterm(2, "TEST"));
            ItermIterator iterator = collection.CreateIterator();

            //for (Iterm iterm = iterator.First(); !iterator.HasNext(); iterm = iterator.Next())
            //{
            //    Console.WriteLine($"ID : {iterm.Id} & Name : {iterm.Name}");
            //}
            while (iterator.HasNext())
            {
                Iterm it = iterator.Next();
                Console.WriteLine($"Id ; {it.Id}  Name: {it.Name}");
            }
            Console.ReadKey();
        }
    }
    public class Iterm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Iterm(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
    public interface IIterator
    {
        Iterm First();
        Iterm Next();
        bool HasNext();
    }
    public class ItermIterator : IIterator
    {
        private ConcreteCollection collection;
        private int index = 0;
        public ItermIterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        public Iterm First()
        {
            return collection.Get(0);
        }
        public Iterm Next()
        {
            if (HasNext())
            {
                return collection.Get(index++);
            }
            else
            {
                return null;
            }            
        }
        public bool HasNext()
        {
            return index < collection.Count() ;
        }
    }
    public interface ICollection
    {
        ItermIterator CreateIterator();
    }
    public class ConcreteCollection : ICollection
    {
        List<Iterm> iterms = new List<Iterm>();
        public ItermIterator CreateIterator()
        {
            return new ItermIterator(this);
        }
        public int Count()
        {
            return iterms.Count;
        }
        public void Add(Iterm iterm)
        {
            iterms.Add(iterm);
        }
        public Iterm Get(int index)
        {
            return iterms[index];
        }
    }
}
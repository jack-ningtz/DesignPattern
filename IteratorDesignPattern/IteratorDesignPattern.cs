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
    /// <summary>
    /// 迭代器接口
    /// 定义访问和遍历聚合元素的接口，通常包含 HasNext()、First()、Next() 等方法
    /// </summary>
    public interface IIterator
    {
        Iterm First();
        Iterm Next();
        bool HasNext();
    }
    /// <summary>
    /// 实现抽象迭代器接口中所定义的方法，完成对聚合对象的遍历，记录遍历的当前位置
    /// </summary>
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
    /// <summary>
    ///  聚会容器接口
    /// </summary>
    public interface ICollection
    {
        ItermIterator CreateIterator();
    }
    /// <summary>
    ///  聚会容器, 
    ///  定义存储、添加、删除聚合对象以及创建迭代器对象的
    ///  实现抽象聚合类，返回一个具体迭代器的实例
    /// </summary>
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
using System;
using System.Collections.Generic;
namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(String[] args)
        {
            Company company = new Company();

            Boss boss = new Boss("Jack");
            company.PerformAction(boss);
            Landlady landlady = new Landlady("Shirley");
            company.PerformAction(landlady);
            Console.ReadKey();
        }
    }
    // 抽象元素（Element）角色
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
    //抽象访问者（Visitor）
    public interface IVisitor
    {
        void Visit(IElement element);
    }
    public class Employee : IElement
    {
        public string Name { get; set; }
        public Employee(string Name)
        {
            this.Name = Name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Boss : IVisitor
    {
        public string Name { get; set; }
        public Boss(string Name)
        {
            this.Name = Name;
        }
        public void Visit(IElement element)
        {
            Employee employee = (Employee)element;
            Console.WriteLine("老板" + this.Name + " 给员工：" + employee.Name + "发福利");
        }
    }
    public class Landlady : IVisitor
    {
        public string Name { get; set; }
        public Landlady(string Name)
        {
            this.Name = Name;
        }
        public void Visit(IElement element)
        {
            Employee employee = (Employee)element;
            Console.WriteLine("老板娘"+ this.Name + " 给员工：" + employee.Name + "发福利");
        }
    }
    //对象结构（Object Structure)
    public class Company
    {
        public List<IElement> elements = new List<IElement>();
        public Company()
        {
            elements.Add(new Employee("Tom"));
            elements.Add(new Employee("Job"));
            elements.Add(new Employee("Blus"));
        }
        public void PerformAction(IVisitor visitor)
        {
            foreach (var e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
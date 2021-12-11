using System;

namespace PrototypePattern
{
    class Pragrom
    {
        static void Main(string[] args)
        {
            PrototypeObject o = new PrototypeObject();
            o.Id = 1;
            o.Name = "Jack";
            o.Department = "IT";
            PrototypeObject o2 = o.GetClone();
            //PrototypeObject o2 = o;
            o2.Id = 2;
            o2.Name = "Bob";
            Console.WriteLine("PrototypeObject 1: ");
            Console.WriteLine("Name: " + o.Name + ", Department: " + o.Department);
            Console.WriteLine("PrototypeObject 2: ");
            Console.WriteLine("Name: " + o2.Name + ", Department: " + o2.Department);
            Console.ReadKey();
        }
    }

    public class PrototypeObject // : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        //public Object Clone()
        //{
        //    return new PrototypeObject(Id);
        //}

        public PrototypeObject GetClone()
        {
            return (PrototypeObject)this.MemberwiseClone();
        }
    }
}
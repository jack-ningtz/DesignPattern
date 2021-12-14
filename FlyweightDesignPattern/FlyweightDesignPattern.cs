using System;
using System.Collections.Generic;

namespace FlyweightDesignPattern
{
    class Pragrom
    {
        private static readonly string[] colors = { "Red", "Green", "Blue", "White", "Black" };
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle", getRandomColor());
                circle.Draw();
            }

            Console.ReadKey();
        }
        private static String getRandomColor()
        {
            return colors[(int)(new Random().Next(0,4))];
        }
    }
    // 享元接口
    public interface Shape
    {
        void Draw();
    }
    // 享元实现类
    public class Circle : Shape
    {
        public string Color { set; get; }
        public Circle(String Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + "]");
        }
    }
    //非享元类
    public class UnFlyweigh
    {

    }
    // 享元工厂
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> shapeMap =
            new Dictionary<string, Shape>();
        public static Shape GetShape(string shapekey, string color)
        {
            Shape shape = null;
            if (shapekey.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue("circle", out shape))
                {

                }
                else
                {
                    shape = new Circle(color);
                    shapeMap.Add("circle", shape);
                    Console.WriteLine("Creating circle of color : " + color);
                }
            }
            return shape;
        }
    }
}
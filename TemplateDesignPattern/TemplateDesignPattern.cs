using System;

namespace TemplateDesignPattern
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Game cs =  new CSGame();
            cs.Play();
            Game pubg = new PUBGGame();
            pubg.Play();
            Console.ReadKey();
        }
    }

    public abstract class Game 
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void StopPlay();

        public void Play() 
        {
            Initialize();
            StartPlay();
            StopPlay();
        }
    }
    public class CSGame : Game 
    {
        public override void Initialize()
        {
            Console.WriteLine("CS 初始化完成！ 开始游戏。");
        }
        public override void StartPlay()
        {
             Console.WriteLine("CS 游戏开始，祝你玩的开心。");
        }
        public override void StopPlay()
        {
            Console.WriteLine("CS 游戏结束，欢迎下次再来。");
        }
    }
    public class PUBGGame : Game 
    {
        public override void Initialize()
        {
            Console.WriteLine("PUBG 初始化完成！ 开始游戏。");
        }
        public override void StartPlay()
        {
             Console.WriteLine("PUBG 游戏开始，祝你玩的开心。");
        }
        public override void StopPlay()
        {
            Console.WriteLine("PUBG 游戏结束，欢迎下次再来。");
        }
    }
}
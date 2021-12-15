using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(String[] args)
        {
            Handler receiver1 = new Receiver1();
            Handler receiver2 = new Receiver2();
            Handler receiver3 = new Receiver3();

            receiver1.NextHander(receiver2);
            receiver2.NextHander(receiver3);
            //receiver3.NextHander(receiver1);


            receiver1.Response("Receiver3");
            Console.ReadKey();
        }
    }
    public abstract class Handler
    {
        private Handler handler;
        public void NextHander(Handler handler)
        {
            this.handler = handler;
        }
        public Handler GetNextHander()
        {
            return handler;
        }
        public abstract void Response(string request);
    }
    public class Receiver1 : Handler
    {
        public override void Response(string request)
        {
            if (request.Equals("Receiver1"))
            {
                //Todo
                Console.WriteLine("This is Receiver1");
            }
            else
            {
               GetNextHander().Response(request);
            }
        }
    }

    public class Receiver2 : Handler
    {
        public override void Response(string request)
        {
            if (request.Equals("Receiver2"))
            {
                //Todo
                Console.WriteLine("This is Receiver2");
            }
            else
            {
                GetNextHander().Response(request);
            }
        }
    }

    public class Receiver3 : Handler
    {
        public override void Response(string request)
        {
            if (request.Equals("Receiver3"))
            {
                //Todo
                Console.WriteLine("This is Receiver3");
            }
            else
            {
                GetNextHander().Response(request);
            }
        }
    }
}
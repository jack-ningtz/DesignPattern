using System;

namespace FacadeDesignPattern
{
    class Program 
    {
        static void Main(String[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.ReadKey();
        }
    }
    //subsystem
    public class Good
    {
        public void GetGoodDetails()
        {
            Console.WriteLine("选择商品");
        }
    }
    //subsystem
    public class Payment 
    {
        public void MakePayment()
        {
            Console.WriteLine("付款完成"); 
        }
    }
    //subsystem
    public class Invoice 
    {
        public void SendInvoice()
        {
            Console.WriteLine("发送发票");
        }
    }
    // Facade
    public class Order 
    {
        Good good = new Good();
        Payment payment = new Payment();
        Invoice invoice = new Invoice();
        public void PlaceOrder() 
        {
            Console.WriteLine("开始下单");
            good.GetGoodDetails();
            payment.MakePayment();
            invoice.SendInvoice();
            Console.WriteLine("完成订单");

        }
    }
}
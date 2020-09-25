using System;

namespace PingPong
{
   class Ping1
   {
       public delegate void Ping(string message);
       public event Ping Notify;
   
       public void GetMessage(string mess)
       {
           Notify?.Invoke("Ping is sent.");
       }
       public void Receiving(string mess)
       {
           Notify?.Invoke("Ping received to Pong.");
       }
   }
   class Pong1
   {
       public delegate void Pong(string message);
       public event Pong Notify;
   
       public void GetMessage(string mess)
       {
           Notify?.Invoke("Pong is sent.");
       }
       public void Receiving(string mess)
       {
           Notify?.Invoke("Pong is received to Ping.");
       }
   }
   class Program
   {
   
       static void Main(string[] args)
       {
           bool IsIt = false;
           do
           {
               Console.WriteLine("Ping or Pong. For exit: bye");
               string st = Console.ReadLine();
               Ping1 p1 = new Ping1();
               Pong1 p2 = new Pong1();
   
               if (st == "Ping")
               {
                   p1.Notify += Message;
                   p1.GetMessage(st);
                   p1.Receiving(st);
                   IsIt = false;
               }
               else if (st == "Pong")
               {
                   p2.Notify += Message;
                   p2.GetMessage(st);
                   p2.Receiving(st);
                   IsIt = false;
               }
               else if (st == "bye")
               {
                   IsIt = true;
   
               }
               else
               {
                   Console.WriteLine("Wrong input.");
                   IsIt = false;
               }
   
           } while (IsIt == false);
       }
       private static void Message(string message)
       {
           Console.WriteLine(message);
       }
   }
}
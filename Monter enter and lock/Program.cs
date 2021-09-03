using System;
using System.Threading;

namespace Monter_enter_and_lock
{
    class FileAccess
    {
        public void WriteData(string s)
        {
            //Monitor.Enter(this);
            lock(this)
            {
                Console.Write(s);
                Console.WriteLine("a,b,c,d,e,f,g");
                //Montor.Exit(this);
            }
        }
    }
    class Program
    {
        static FileAccess obj = new FileAccess();
        public static void  ChildThread1()
        {
            Console.WriteLine("Child1 started writing data");
            obj.WriteData("child1 ----- my data is ");
        }
        public static void ChildThread2()
        {
            Console.WriteLine("Child2 started entering data");
            obj.WriteData("child2 --- my data is");
        }
        static void Main(string[]args)
        {
            ThreadStart ts1 = new ThreadStart(ChildThread1);
            ThreadStart ts2 = new ThreadStart(ChildThread2);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);


            t1.Start();
            t2.Start();
        }
    }
}

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantTopics
{
    public class MultiThreadingExample
    {
        public MultiThreadingExample()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Test Thread";
            //Console.WriteLine(Thread.CurrentThread.Name);
        }

        public static void Run1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " This is first Method");
            }
        }
        public static void Run2()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i == 25)
                {
                    Console.WriteLine("Thread Stoped");
                    Thread.Sleep(8000);
                }


                Console.WriteLine(i + " This is Second Method");
            }
        }
        public static void Run3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + " This is Third Method");
            }
        }

    }
}

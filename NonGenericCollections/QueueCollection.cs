using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class QueueCollection
    {
        public QueueCollection()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("Arbab");
            myQueue.Enqueue(24);
            myQueue.Enqueue(5.2);
            myQueue.Enqueue(true);
            foreach (object item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("-------");
            Console.WriteLine("-------");
            Console.WriteLine("After Dequeue");
            foreach (object item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine("-------");
            Console.WriteLine(myQueue.Contains("24"));
            myQueue.Clear();
        }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    class StackCollection
    {
        public StackCollection() {
        Stack mystack = new Stack();
            mystack.Push("Arbab");
            mystack.Push(24);
            mystack.Push(5.2);
            mystack.Push(false);
            foreach (object item in mystack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine(mystack.Contains("Arbab"));
            Console.WriteLine(mystack.Count);
            Console.WriteLine(mystack.Peek());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine("------------");
            foreach (object item in mystack)
            {
                Console.WriteLine(item);
            }
            mystack.Clear(); // clears the stack
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantTopics
{
    
   public struct StructExample//struct can implement interface but cannot implement a class
    {
        public void Example() {
            Console.WriteLine("Struct Example Method");
        }
    }

    public class StructExample2
    {
        StructExample2()
        {
            StructExample s;
            s.Example();
            
        }
    }
}

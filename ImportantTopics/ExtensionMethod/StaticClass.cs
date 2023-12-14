using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImportantTopics
{   
    public static class StaticClass
    {
        /// <summary>
        /// This is an Extension Method
        /// </summary>
        /// <param name="e">Binding Parameter for ExtensionMethod Class</param>
        public static void ExtensionMethod(this ExtensionMethod e)
        {
            Console.WriteLine("This is Extension Method");
        }
        /// <summary>
        /// This is an Extension Method with int parameter
        /// </summary>
        /// <param name="e">Binding Parameter for ExtensionMethod Class</param>
        /// <param name="a">Takes Int value to test the method</param>
        public static void ExtensionMethod2(this ExtensionMethod e, int a)
        {
            Console.WriteLine("Parameter is {0}",a);
            Console.WriteLine("This is 2nd Extension Method");
        }

    }
    public class TestExtensionMethod
    {
        public static void Test()
        {
            ExtensionMethod a = new ExtensionMethod();
            a.Function1();
            a.Function2();
            a.ExtensionMethod();
            a.ExtensionMethod2(24);
        }
    }
}

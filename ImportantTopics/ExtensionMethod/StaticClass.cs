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
        /// <param name="e">ExtensionMethod Class parameter</param>
        public static void ExtensionMethod(this ExtensionMethod e)
        {
            Console.WriteLine("This is Extension Method");
        }
    }
}

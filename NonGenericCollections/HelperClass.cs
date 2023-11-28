using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    public static class HelperClass
    {
        #region Methods
        /// <summary>
        /// This will print whatever you pass as an argument
        /// </summary>
        /// <returns>
        /// Null
        /// </returns>
        /// <param name="name">Pass your name as an argument</param>
        public static void GetReceipt(string name = null)
        {
            Console.WriteLine(name);
        }
        #endregion
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    public class HashTableCollection
    {
        public HashTableCollection() {
            Hashtable a = new Hashtable();
            a.Add('a',23);
            a.Add('b',12);
            a.Add('c',34);
            a.Add('d',14);
            a.Add('e',53);
            a.Add('f',76);
            a.Add('g',99);
            Console.WriteLine("The value on index a is: " + a['a']);
            Hashtable a2 = new Hashtable()
            {
                { 'a',2}
                , { 'b',3 }
                , { 'c', 4 }
                , { 'v',1 }
            };
            Console.Write(a2['a']);

        }
    }
}

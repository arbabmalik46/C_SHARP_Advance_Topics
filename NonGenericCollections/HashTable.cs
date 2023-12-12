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
        Hashtable b = new Hashtable() {
            {'s',34 },
            {'r',90}
        };
        
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
            foreach (object item in a2.Keys)
            {
                Console.WriteLine(item +":"+ a2[item]);
            }
            a2.Remove('a'); //it will remove the value on key
            Console.WriteLine(a2.ContainsKey('b'));
            Console.WriteLine(a2.ContainsValue(4));
            Console.WriteLine(a2.GetHashCode());
            Console.WriteLine(a2.Contains('b'));
            Console.WriteLine(a2.Count);
            Console.WriteLine(a2.Keys);
            Console.WriteLine(a2.Values);
            Console.WriteLine("a".GetHashCode());
            a2.Clear(); // clears the HashTable
            foreach (object item in a2.Keys)
            {
                Console.WriteLine(item + ":" + a2[item]);
            }
        }
    }
}

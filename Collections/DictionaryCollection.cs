using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionaryCollection
    {
        public DictionaryCollection() 
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("name","Arbab Malik");
            myDict.Add("class","BSSE");
            myDict.Add("age","24");
            Console.WriteLine("Only Keys");
            foreach (string item in myDict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Only Values");
            foreach (string item in myDict.Values)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<string,string> item in myDict)
            {
                Console.WriteLine(item.Key + ":" +item.Value);
            }
        }
    }
}

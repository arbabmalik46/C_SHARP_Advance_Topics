using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{

	
	class Program
	{
		
		static void Main(string[] args)
		{



			#region ArrayList
			//ArrayList arrayList = new ArrayList();
			//arrayList.Add(10); //To add the element
			//arrayList.Add("hello world");
			//arrayList.Add('c');
			//arrayList.Add(2.34);
			//E e = new E();
			//arrayList.Add(e);
			//Console.WriteLine(arrayList.Capacity);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//Console.WriteLine(arrayList.Capacity);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//arrayList.Add(2.34);
			//Console.WriteLine(arrayList.Capacity);
			//foreach (var item in arrayList)
			//{
			//    Console.Write(item + " ");
			//}
			//arrayList.Insert(1, 34); // to insert data at index -> input: index, value
			//arrayList.Remove(2); // to delete a value in arrayList -> input: value
			//arrayList.RemoveAt(3); // to delete a value at index in arratlist -> input: index

			#endregion

			#region HashTable
			//         HashTableCollection collection = new HashTableCollection();
			//         Hashtable hashtable = new Hashtable()
			//{
			//	{"Hello","Hello" },
			//	{"World","World"},
			//	{ 3,5}
			//};
			//Console.WriteLine(hashtable[3]);
			//hashtable.Add(2,"Ja way");
			//Console.WriteLine(hashtable["World"]);
			//Console.WriteLine(hashtable[2]);
			//hashtable.Add("ID",3473);
			//hashtable.Add("Name","Arbab");
			//hashtable.Add("Salary","50000");
			//hashtable.Add("Height",5.3);
			//hashtable.Add(4,53);
			//Console.WriteLine(hashtable[4]);
			//Console.WriteLine(hashtable["Salary"]);

			#endregion

			#region Stack
			//StackCollection a = new StackCollection();
			#endregion

			#region Queue
			QueueCollection queueCollection = new QueueCollection();
			#endregion
		}
	}
}

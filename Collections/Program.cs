using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NonGenericCollections;

namespace Collections
{
    #region Quiz Class
    //class Quiz
    //{
    //    private int _indexnumber;

    //    public int IndexNumber
    //    {
    //        get { return _indexnumber; }
    //        set { _indexnumber = value; }
    //    }

    //    private string _question;

    //    public string Question
    //    {
    //        get { return _question; }
    //        set { _question = value; }
    //    }
    //}
    #endregion

    #region Generic Class
    public class ET<T>
    {
        public ET() { }
        public ET(T t)
        {
            Console.Write(t);
            Console.WriteLine("Your Value is the type of " + t.GetType());
        }
        public ET(T t1, T t2) { Console.WriteLine(t1); Console.WriteLine(t2); Console.WriteLine("Your First Value is the type of " + t1.GetType() + "and Second Value is the type of " + t2.GetType()); }

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region List
            //List<ListGeneric> listGenerics = new List<ListGeneric>();
            //ListGeneric listGeneric = new ListGeneric()
            //{
            //    Name = "Arbab",
            //    Age = 24,
            //    Class = "BSSE",
            //    ID = 1
            //};
            //ListGeneric listGeneric1 = new ListGeneric()
            //{
            //    Name = "Ammar",
            //    Age = 22,
            //    Class = "BCOM",
            //    ID = 2
            //};
            //ListGeneric listGeneric2 = new ListGeneric()
            //{
            //    Name = "Muaz",
            //    Age = 20,
            //    Class = "BSCS",
            //    ID = 3
            //};
            //listGenerics.Add(listGeneric);
            //listGenerics.Add(listGeneric1);
            //listGenerics.Add(listGeneric2);
            //foreach (var item in listGenerics)
            //{
            //    Console.WriteLine("Name: " + item.Name);
            //    Console.WriteLine("Age: " + item.Age);
            //    Console.WriteLine("ID: " + item.ID);
            //    Console.WriteLine("Class: " + item.Class);
            //    Console.WriteLine("------------------");
            //}
            //ListGeneric listGeneric3 = new ListGeneric()
            //{
            //    Name="Sunny",
            //    Age = 29,
            //    Class = "BSIT",
            //    ID = 4
            //};
            //listGenerics.Insert(1,listGeneric3);
            //listGenerics.Remove(listGeneric3);
            //listGenerics.RemoveAt(1);
            //listGenerics.RemoveRange(1,2);
            //Console.WriteLine("After AddRangew");
            //listGenerics.AddRange(listGenerics);
            //foreach (var item in listGenerics)
            //{
            //    Console.WriteLine("Name: " + item.Name);
            //    Console.WriteLine("Age: " + item.Age);
            //    Console.WriteLine("ID: " + item.ID);
            //    Console.WriteLine("Class: " + item.Class);
            //    Console.WriteLine("------------------");
            //}
            #endregion

            #region Dictionary
            DictionaryCollection mm = new DictionaryCollection();
            #endregion

            #region Generic Class Expample

            //ET<string> eT = new ET<string>("Ja","Ja");
            #endregion

            #region Refereing Class and Enum Example
            //HelperClass.GetReceipt(Ref.One.ToString());

            #endregion

            #region Collection Example Commented
            //var c = new List<Quiz>();
            //Quiz v = new Quiz();
            //v.IndexNumber = 1;
            //v.Question = "What is Your name?";
            //c.Add(v);
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item.Question);
            //    Console.WriteLine(item.IndexNumber);
            //}
            #endregion

            #region Array Example
            //int[] arr = new int[5];
            //arr[0]= 1;
            //arr[1]= 2;
            //arr[2]= 3;
            //arr[3]= 4;
            //arr[4]= 5;
            //Array.Resize(ref arr, 6);
            //arr[5]= 6;
            //Console.WriteLine(arr[5]);
            #endregion


        }
    }
}

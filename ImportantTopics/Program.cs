﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using ImportantTopics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices;

namespace ImportantTopics
{
    class Program
    {
        #region Async/Awiat
        public async static void Task1()
        {
           await Task.Run(() => {
                Console.WriteLine("Task 1 started");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 Completed");
            }
            );
            
        }
        public async static void Task2()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 2 started");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 Completed");
            }
            );
        }
        public async static void Task3()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 3 started");
                Thread.Sleep(5000);
                Console.WriteLine("Task 3 Completed");
            }
            );
        }
        public async static void Task4()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 4 started");
                Thread.Sleep(1000);
                Console.WriteLine("Task 4 Completed");
            }
            );
        }
        #endregion
        #region Params Keyword method

        /// <summary>
        /// This method applies the param keyword and it will show every parameter you enter
        /// </summary>
        /// <param name="args">strings array</param>
        public void PrintEveryParameter(params string[] args)
        {
            foreach (var item in args)
            {
                Console.Write(item);
            }
        }
        #endregion
        public static void Main(string[] args)
        {
            #region MultiThreading
            //Thread t1 = new Thread(MultiThreadingExample.Run1);
            //Thread t2 = new Thread(MultiThreadingExample.Run2);
            //Thread t3 = new Thread(MultiThreadingExample.Run3);
            //t1.Start();
            //Console.WriteLine(Thread.CurrentThread);
            //t2.Start();
            //t3.Start();
            //MultiThreadingExample threadingExample = new MultiThreadingExample();
            //MultiThreadingExample.Run1();
            //MultiThreadingExample.Run2();
            //MultiThreadingExample.Run3();

            #endregion

            #region Param Keyword
            //Program a = new Program();
            //a.PrintEveryParameter("A","B","C");
            #endregion

            #region PartialClass
            //CollegeDetails details = new CollegeDetails();
            //details.GetDetails();   
            #endregion

            #region String Builder
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello");//It will add the text
            //stringBuilder.AppendLine("World");//It will add the text and add a new line
            //stringBuilder.AppendFormat("{0:C}",25);//it will set a format for text entered as second parameter
            //stringBuilder.Insert(1,"C#");//It will add the text at specified index number
            //stringBuilder.Remove(2,4);//it will remove the string at specified index and specified length
            //stringBuilder.Replace("Hello","World");//it will replace the string from new value to old value
            //stringBuilder.ToString();//This method will return the string from stringBuilder

            //Console.WriteLine(stringBuilder);
            #endregion

            #region ExtensionMethods
            //TestExtensionMethod.Test();
            #endregion

            #region Boxing/Unboxing
            //Boxing -> stored in heap
            //int num = 4; //value type 
            //object boj = num; //implicitly converting to reference type
            //Unboxing -> stored in stack
            //int numb = 4; //value type 
            //object obj = numb; //implicitly converting to reference type 
            //int numb2 = (int)obj; //explicitly converting to value type

            #endregion

            #region GUID
            //Guid g = Guid.NewGuid();
            //Console.WriteLine(g.ToString().Replace("-",string.Empty).Substring(0,5));
            #endregion

            #region IS/AS Keyword
            //summary of IS Keyword
            // IS keyword is used to check the data type of an object
            //object obj = "Arbab";
            //if(obj is int)
            //{
            //    Console.WriteLine("It is String");
            //}
            //else
            //{
            //    Console.WriteLine("It is false");
            //}
            //AS Keyword
            //object aas = 456;
            //string name = aas as string;
            //Console.WriteLine(name);

            #endregion

            #region Null Collesce Operator
            //object name = 123;
            //string result = name as string;
            //result = result ?? "Arbab";
            //Console.WriteLine(result);

            //string apple = null;
            //string banana = "Banana";
            //string cherry = "Cherry";
            //string result = apple ?? banana ?? cherry;
            //Console.WriteLine(result);

            #endregion

            #region Serialization/Deserialization
            //Serialization
            //SerializationExample serializationExample = new SerializationExample();
            //DeSerializationExample
            //DeSerializationExample deSerializationExample = new DeSerializationExample();
            #endregion

            #region Concrete Class
            ///Concrete class is a class that has an implementation of all of its methods. It can also extends an abstract class or implements an interface as long as it implements all theri methids. A class which is not abstract is a concrete class.
            #endregion

            #region Async/Await
            Task1();
            Task2();
            Task3();
            Task4();

            #endregion


            //HelperClass a = new HelperClass();
        }
    }
    #region Helper Classes

    public class HelperClass
        //:CollegeDetails
    {
       public HelperClass() {
            //GetDetails();
            //HelperClass2 we = new HelperClass2();
            //we.Method();
        }

    }

   public class HelperClass2
    {
        public void Method()
        {
            unsafe
            {
                int x = 10;
                int y = 20;
                int* ptr1 = &x;
                int* ptr2 = &y;
                Console.WriteLine((int)ptr1);
                Console.WriteLine((int)ptr2);
                Console.WriteLine(*ptr1);
                Console.WriteLine(*ptr2);
            }
        }

    }
    #endregion
}
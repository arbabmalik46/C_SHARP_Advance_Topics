using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ImportantTopics
{

    public class SerializationExample
    {
        public SerializationExample()
        {
            Employee employee = new Employee(1,"Arbab");
            string path = @"D:\Coding Practice\C#\arbabmalik46\C_SHARP_Advance_Topics\ImportantTopics\SerializationAndDeserialization\FilePath\Sample.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(fileStream,employee);
            //fileStream.Close();
            Console.WriteLine("File Create at {0}",path);


        }

    }
    public class DeSerializationExample
    {
        public DeSerializationExample()
        {
            string path = @"D:\Coding Practice\C#\arbabmalik46\C_SHARP_Advance_Topics\ImportantTopics\SerializationAndDeserialization\FilePath\Sample.txt";
            FileStream file = new FileStream(path,FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //Employee employee =(Employee)  formatter.Deserialize(file);
            file.Close();
        }
    }

}

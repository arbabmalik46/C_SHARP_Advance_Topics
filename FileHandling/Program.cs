using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices;
using System.IO;

namespace FileHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region File Class
            //string path = "D:\\Coding Practice\\C#\\arbabmalik46\\C_SHARP_Advance_Topics\\FileHandling\\file.txt";
            //string path2 = @"D:\Coding Practice\C#\arbabmalik46\C_SHARP_Advance_Topics\FileHandling\file1.txt"; //@:verbatim Litteral
            //string path3 = @"D:\Coding Practice\C#\arbabmalik46\C_SHARP_Advance_Topics\FileHandling\logs\file.txt"; //@:verbatim Litteral
            //if (File.Exists(path)) //check file is present at path or not
            //{
            //    string data= File.ReadAllText(path); //read all text from file
            //    File.Copy(path,path2); //Create a copy of file
            //    File.Copy(path, path2,true); //Create a copy of file but also asks to overwrite the file
            //    if (File.Exists(path2))
            //    {
            //        File.Create(path3);
            //        Console.WriteLine("File Created");
            //    }
            //    Console.WriteLine(data);

            //}
            //else
            //{
            //    Console.WriteLine("File not available");
            //}
            #endregion

            #region DirectoryInfo Class
            //string path = @"D:\MyDirectory";
            //DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //if (!directoryInfo.Exists)
            //{
            //    directoryInfo.Create(); //create a new folder
            //    if (directoryInfo.Exists) //check if folder exists or not
            //    {
            //        Console.WriteLine("File Created");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Directory Already Available");
            //}
            //directoryInfo.CreateSubdirectory("Error"); //create folder inside the directory
            //string path2 = @"D:\MyDirectory2";
            //directoryInfo.MoveTo(path2); //move a directory to another
            //directoryInfo.Delete(); //Delete an empty directory
            //directoryInfo.Delete(true); //Delete a directory whethere there is data or not
            //DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            //foreach (var item in directoryInfos)
            //{
            //    Console.WriteLine(item.FullName);//print full path of the directory
            //    Console.WriteLine(item.Parent);//print Parent directory name
            //    Console.WriteLine(item.Root);//print Root directory name
            //    FileInfo[] files = item.GetFiles(); //returns an array of files in a folder
            //    foreach (var file in files)
            //    {
            //        Console.WriteLine(file.FullName);//print full path of the file
            //        Console.WriteLine(file.Name);//print the name of file
            //        Console.WriteLine(file.Attributes);//gets the attribute like it is a file or a directory

            //    }
            //}
            //directoryInfo.GetDirectories();//returns an array of directories


            #endregion

            #region FileStream
            /* FileStream class is used to read from, write to, open and close files on a file system*/
            string filePath = @"D:\myFile.txt";
            //if(!File.Exists(filePath))
            //{
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open,FileAccess.ReadWrite))
            {
                using (StreamWriter s = new StreamWriter(fileStream))
                {

                    Console.WriteLine("File Created");
                    try
                    {
                        int a = 1;
                        int b = 0;
                        int c = a / b;
                    }
                    catch (Exception ex)
                    {
                        s.WriteLine(ex.Message);
                        s.WriteLine(ex.StackTrace);
                        s.WriteLine(ex.InnerException);
                        //byte[] bytes = Encoding.UTF8.GetBytes(ex.ToString());
                        //fileStream.Write(bytes,0,bytes.Length);
                        //fileStream.WriteByte(Convert.ToByte(ex.ToString()));
                    }
                }
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string lines = "";
                    while ((lines = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(lines);
                    }
                    lines = sr.ReadToEnd();

                    var boolp = sr.Peek();
                    
                }
                //fileStream.WriteByte(66);
                //fileStream.WriteByte(68);
                //fileStream.WriteByte(69);
                //fileStream.WriteByte(73);
                //try
                //{
                //    int a = 1;
                //    int b = 0;
                //    int c = a/b;
                //}
                //catch (Exception ex)
                //{
                //    fileStream.WriteByte(Convert.ToByte(ex.ToString()));
                //}
            }

            //}

                #endregion
        }

    }
    }
    
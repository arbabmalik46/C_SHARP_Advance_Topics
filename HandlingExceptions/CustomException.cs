using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    #region CsutomExceptionDefinition

    
    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }
    #endregion
    public static class OurCustomException
    {
        /// <summary>
        /// This block includes Default throw and Default Catch and this will throw exception on runtime
        /// </summary>
        public static void DefaultThrowDefaultCatch()
        {
            string name = null;
            Console.WriteLine(name.Count());
        }
        /// <summary>
        /// This block includes Default throw and Our Catch
        /// </summary>
        public static void DefaultThrowOurCatch()
        {
            try
            {
                string name = null;
                Console.WriteLine(name.Count());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }
        /// <summary>
        /// This block includes our custom throw and Default Catch
        /// </summary>
        public static void OurThrowDefaultCatch()
        {
            string name = null;
            if(name!=null)
            {
                Console.WriteLine(name.Count());
            }
            else
            {
                throw new Exception("Name Cannot be null");
            }
        }

        /// <summary>
        /// This block includes our custom throw and our Catch
        /// </summary>
        public static void OurThrowOurCatch() 
        {
            try
            {
                string name = null;
                if (name != null)
                {
                    Console.WriteLine(name.Count());
                }
                else
                {
                    throw new Exception("Name Cannot be null");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void OurSimpleCustomException()
        {
            try
            {
                string name = null;
                if (name != null)
                {
                    Console.WriteLine(name.Count());
                }
                else
                {
                    throw new InvalidStudentNameException();
                }
            }
            catch (InvalidStudentNameException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}

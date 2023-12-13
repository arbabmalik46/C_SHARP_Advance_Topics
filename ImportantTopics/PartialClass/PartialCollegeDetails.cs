using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ImportantTopics
{
    public partial class CollegeDetails
    {
        public void GetDetails()
        {
            Console.WriteLine("Hi, Our College name is {0} and it is registered under this ID: {1}." + "We are the best {4} in the country" +
                " We have Different departments." +
                " Total number of departments is {2} \n and we are located at {3}",Name,ID,NumberOfDepartments,Location,Type);
        }
        public CollegeDetails()
        {
            Console.Write("Please Enter College Name: ");
            Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Enter ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please Enter Your Type: ");
            Type = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Enter Number of Departments: ");
            NumberOfDepartments = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please Enter Your Location: ");
            Location = Console.ReadLine();
            Console.Clear();
        }
    }
}

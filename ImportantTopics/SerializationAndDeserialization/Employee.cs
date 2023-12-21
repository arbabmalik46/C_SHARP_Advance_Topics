using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantTopics
{
    [Serializable]
    class Employee
    {
        public int ID;
        public string Name;

        public Employee(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Account
    {
        //public IAccount account { get; set; }//Property Injection
        //public Account(IAccount iaccount) //Parameterized Constructor(Constructor Injection)
        //{
        //    this.account = iaccount;
        //}
        //public void PrintDetails()
        //{
        //    account.PrintDetails(); 
        //}
        public void PrintDetails(IAccount account) //Method Injection
        {
            account.PrintDetails();
        }
    }
}

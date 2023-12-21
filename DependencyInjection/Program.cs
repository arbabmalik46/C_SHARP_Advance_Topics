using System;
using System.IO.Enumeration;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace DependencyInjection
{
    
    class Program
    {
        public static void Main(string[] args)
        {

            #region Constructor Injection
            //IAccount ca = new CurrentAccount();
            //Account account = new Account(ca);
            //account.PrintDetails();
            //IAccount sa = new SavingAccount();
            //Account account1 = new Account(sa);
            //account.PrintDetails();
            #endregion

            #region Property Injection
            //Account a = new Account();
            //a.account = new SavingAccount();
            //a.PrintDetails();

            //Account a1 = new Account();
            //a1.account = new CurrentAccount(); ;
            //a1.PrintDetails();
            #endregion

            #region Method Injection
            Account account = new Account();
            account.PrintDetails(new CurrentAccount());
            account.PrintDetails(new SavingAccount());
            #endregion

        }
    }
}


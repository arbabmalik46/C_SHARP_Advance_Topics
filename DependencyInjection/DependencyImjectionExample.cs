//using System;
//using System.IO.Enumeration;
//using System.Collections;
//using System.Collections.Generic;
//using System.Reflection.Metadata;

//namespace DependencyInjection
//{
//    class CurrentAccount
//    {
//        public void PrintDetails()
//        {
//            Console.WriteLine("Details of Current Account");
//        }
//    }
//    class SavingAccount
//    {
//        public void PrintDetails()
//        {
//            Console.WriteLine("Details of Saving Account");
//        }
//    }
//    class Account
//    {
//        CurrentAccount ca = new CurrentAccount();
//        SavingAccount sa = new SavingAccount();
//        public void PrintAccounts()
//        {
//            ca.PrintDetails();
//            sa.PrintDetails();
//        }
//    }
//    class MainProgram
//    {
//        public static void MainStart(string[] args)
//        {
//            Account a = new Account();
//            a.PrintAccounts();
//        }
//    }
//}

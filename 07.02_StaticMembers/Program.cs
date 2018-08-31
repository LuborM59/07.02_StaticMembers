using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02_StaticMembers
{
    class Program
    {
        class myclass
        {
            public int instMemember;
            public static int staticmember;

            public int getstaticvalue()
            {
                return myclass.staticmember;
            }
        }
        static void Main(string[] args)
        {
            myclass mc1 = new myclass();
            myclass mc2 = new myclass();

            mc1.instMemember = 1;
            mc1.instMemember = 1;
            myclass.staticmember = 100;
            

            Console.WriteLine("mc1: instmember = {0}, stat mem: = {1}", mc1.instMemember, mc1.getstaticvalue());
            Console.WriteLine();
            Console.WriteLine("mc2: instmember = {0}, stat mem: = {1}", mc2.instMemember, mc2.getstaticvalue());

            myclass.staticmember = 500;

            Console.WriteLine("mc1: instmember = {0}, stat mem: = {1}", mc1.instMemember, mc1.getstaticvalue());
            Console.WriteLine();
            Console.WriteLine("mc2: instmember = {0}, stat mem: = {1}", mc2.instMemember, mc2.getstaticvalue());
        }
    }
}


// lektor - bank account
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _08_BankAccount
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount.InterestRate = 2;

//            BankAccount ba1 = new BankAccount();
//            BankAccount ba2 = new BankAccount();

//            ba1.Amount = 10000;
//            ba2.Amount = 20000;

//            Console.WriteLine(ba1.GetInfo());
//            Console.WriteLine(ba2.GetInfo());

//            ba2.AddInterest();

//            Console.WriteLine(ba1.GetInfo());
//            Console.WriteLine(ba2.GetInfo());
//        }
//    }

//    class BankAccount
//    {
//        public decimal Amount;
//        public static decimal InterestRate;

//        public void AddInterest()
//        {
//            this.Amount = this.Amount
//                + this.Amount * BankAccount.InterestRate / 100;
//        }

//        public string GetInfo()
//        {
//            //return string.Format("Amout: {0}, InterestRate: {1}",
//            //    this.Amount, BankAccount.InterestRate);
//            return $"Amout: {this.Amount}, InterestRate: {BankAccount.InterestRate}";

//        }
//    }
//}

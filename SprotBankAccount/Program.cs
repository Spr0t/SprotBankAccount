using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotBankAccount
{

    

    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.RegisterHandler(account.Print);
            account.Add(50);
            account.Take(200);
            account.Take(150);
            Console.ReadLine();
        }
       
    }
}

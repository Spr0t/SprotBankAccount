using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotBankAccount
{
    public delegate void AccountHandler(string message);

    public class Account
    {
        public int Sum { get; set; }

        AccountHandler taken;

        public Account (int sum)=> Sum = sum;

        public void RegisterHandler(AccountHandler del)
        {
            taken = del;
        }

        public void Add(int sum) => Sum += sum;

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                taken?.Invoke($"Со счета списано {sum} у.е.");

            }
            else
            {
                taken?.Invoke($"Недостаточно средств. Баланс {Sum} у.е.");
            }
        }

        public void Print(string message) => Console.WriteLine(message);
    }
}

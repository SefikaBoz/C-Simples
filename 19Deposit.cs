# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMsdn
{

    class Deposit
    {
        public virtual void WithdrawMoney()
        {
            Console.WriteLine("WithdrawMoney options");
        }
    }
    class Transfer : Deposit
    {
        public override void WithdrawMoney()
        {
            Console.WriteLine("WithdrawMoney options with tranfer..");
        }
    }
    class EFT : Deposit
    {
        //public override void WithdrawMoney()
        //{
        //    Console.WriteLine("WithdrawMoney options with EFT..");
        //}
    }
        
}

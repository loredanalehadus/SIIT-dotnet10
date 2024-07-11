using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    public class BankAccount 
    {
        //public BankAccount(decimal initialBalance)
        //{
            
        //}
    }

    public class SavingsAccount : BankAccount, ISavingsAccount
    {

    }


    public class CurrentAccount : BankAccount, ICurrentAccount
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    public class ModerateCustomer
    {
        private BankAccount savingsAccount;

        public ModerateCustomer() // hidden dependency
        {
            this.savingsAccount = new BankAccount();
        }

        //
    }
}

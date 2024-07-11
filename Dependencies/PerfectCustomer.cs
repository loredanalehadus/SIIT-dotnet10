namespace Dependencies
{
    public class PerfectCustomer
    {
        private ISavingsAccount savingsAccount;
        private ICurrentAccount currentAccount;

        public PerfectCustomer(ISavingsAccount savingsAccount, ICurrentAccount current) //loose coupling dependency
        {
            this.savingsAccount = savingsAccount;
            this.currentAccount = current;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    [Serializable]
    public class BankAccount
    {
        public int accountId { get; set; }
        public string partyName { get; set; }
        public double balance { get; set; }
        public List<BankAccount> bankAccountsList = new List<BankAccount>();

        public BankAccount()
        {
            accountId = 0;
            partyName = "Empty";
            balance = 0;
        }
        public BankAccount(int accountID, string pName, double bal, List<BankAccount> bList)
        {
            this.accountId = accountID;
            this.partyName = pName;
            this.balance = bal;
            this.bankAccountsList = bList;
        }

        public void addBankAccount()
        {
           // bankAccountsList.Add();
        }

        public override string ToString()
        {
            return "Account ID: " + accountId + " \nParty Name: " + 
                partyName + "\nBalance: " + balance;

        }

    }
}

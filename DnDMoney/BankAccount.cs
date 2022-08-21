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
        public double balance { get; set; }
        public string partyName { get; set; }
      
        public List<BankAccount> bankAccountsList = new List<BankAccount>();

        public BankAccount()
        {
            accountId = 0;
            balance = 0;
            partyName = "Empty";
        }
        public BankAccount(int accountID, double bal, string pName)
        {
            this.accountId = accountID;
            this.partyName = pName;
            this.balance = bal;
        }

        public void addBankAccount(int id, double bal, string name)
        {
            bankAccountsList.Add(new BankAccount(id, bal, name));
        }

        public void printAccountList()
        {
            foreach(var acc in bankAccountsList)
            {
                Console.WriteLine("Account ID: " + acc.accountId + " \nParty Name: " +
                acc.partyName + "\nBalance: " + acc.balance);
            }
        }

        public override string ToString()
        {
            return "Account ID: " + accountId + " \nParty Name: " + 
                partyName + "\nBalance: " + balance;

        }

    }
}

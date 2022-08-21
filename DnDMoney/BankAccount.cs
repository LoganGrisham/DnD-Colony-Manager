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

        public BankAccount()
        {
            accountId = 0;
            partyName = "Empty";
            balance = 0;
        }
       

    }
}

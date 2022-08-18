using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Utility
    {
        public void Kms()
        {
            int go = 1;
            string ui = "nbasdjkh";
            Random r = new Random();

            int kms = r.Next(2);
            if (kms == 1)
            {
                Console.WriteLine("uh huh\n");
            }
            else
            {
                Console.WriteLine("nah g.\n");
            }
        }
    }
}

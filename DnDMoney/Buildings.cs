using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Buildings
    {
        public int[] results = new int[2];
        public int diceRolls;
        public Merchants merchants;
        public Dice d;
        public TextFormatting f;
        public Utility u = new Utility();
        public BankAccount bankAccount;
        

        

        public Buildings()
        {
            this.merchants = new Merchants("Deafualt");
            this.d = new Dice();
            this.f = new TextFormatting();
            this.bankAccount = new BankAccount();
            this.u = new Utility();
        }


        /**
        * Docks, Water Building.
        * This function calculates income and merchants for the docks.
        */
        public void docksWater()
        {
            //25gp times 2d10 every 30 days
            //2 merchants every 7 days

            var rand = new Random();
            int total = 0;
            int temp = 0;
            diceRolls = 2;

            results = d.rollD10(diceRolls);
            Console.WriteLine(" " + diceRolls + f.rollAmount(10));

            for (int i =0; i< diceRolls; i++)
            {
                if (results[i] == 0)
                {
                    temp = results[i];
                    temp += 1;
                    results[i] = temp;
                }
                total += results[i];
                Console.WriteLine("  - Roll " + (i+1) + ": " + results[i]);
            }

            Console.WriteLine("---Merchant---");

            results = d.rollD100(1);
            int holder = results[0];
            Console.WriteLine(" " + 1 + f.rollAmount(100));

            results = null;
            results = d.rollD12(1);
            int holder2 = results[0];
            Console.WriteLine(" " + 1 + f.rollAmount(12));

            results = null;
            results = d.rollD12(1);
            int holderLeg = results[0];
            Console.WriteLine(" " + 1 + f.rollAmount(12));

            merchants.merchantsRoll(holder, holderLeg);
            merchants.QualityRoll(holder2);
            Console.WriteLine("---------------");

            Console.WriteLine(" Totals: ");
            Console.WriteLine("  -- Roll Total: " + total);
            Console.WriteLine("  -- Docks Total: " + (total * 25));

        }

        /**
        * Market Stalls Building
        * This function calculates markets stall income.
        */
        public void MarketStalls()
        {
            //3 merchants from merchant section
            //30gp times 2d6 every 30 days

            var rand = new Random();
            int total = 0;
            int temp = 0;
            diceRolls = 2;

            results = d.rollD6(diceRolls);
            Console.WriteLine(" " + diceRolls + f.rollAmount(6));
            for (int i = 0; i < diceRolls; i++)
            {
                if (results[i] == 0)
                {
                    temp = results[i];
                    temp += 1;
                    results[i] = temp;
                }
                total += results[i];
                Console.WriteLine("  - Roll " + (i + 1) + ": " + results[i]);
            }
            Console.WriteLine(" Totals: ");
            Console.WriteLine("  -- Roll Total: " + total);
            Console.WriteLine("  -- Market Stalls Total: " + (total * 30));
        }

       

        /**
        * Tavern Building
        * This calculates Keg and room income, as well as rumors.
        */
        public void Tavern()
        {
            //1d4-1 rumors every 7 days
            //2d10 kegs times 10 gp
               //Kegs could be 5gp with unskilled staffers
            //Room income 10gp * 1d10 every 30 days
            
            var rand = new Random();
            int totalKegs = 0;
            int totalRooms = 0;
            int totalRumors = 0;
            int temp = 0;
            diceRolls = 2;

            //Kegs
            results = d.rollD10(diceRolls);
            Console.WriteLine(" " + diceRolls + f.rollAmount(10));
            for (int i = 0; i < diceRolls; i++)
            {
                if (results[i] == 0)
                {
                    temp = results[i];
                    temp += 1;
                    results[i] = temp;
                }
                totalKegs += results[i];
                Console.WriteLine("  - Roll " + (i + 1) + ": " + results[i]);
            }

            //Rooms
            diceRolls = 1;
            results = d.rollD10(diceRolls);
            Console.WriteLine(" " + diceRolls + f.rollAmount(10));
            for (int i = 0; i < 1; i++)
            {
                if (results[i] == 0)
                {
                    temp = results[i];
                    temp += 1;
                    results[i] = temp;
                }
                totalRooms += results[i];
                Console.WriteLine("  - Roll " + (i + 1) + ": " + results[i]);
            }

            //Rumors
            diceRolls = 1;
            results = d.rollD4(diceRolls);
            Console.WriteLine(" " + diceRolls + f.rollAmount(4));
            for (int i = 0; i < 1; i++)
            {
                if (results[i] == 0)
                {
                    temp = results[i];
                    temp += 1;
                    results[i] = temp;
                }
                totalRumors += results[i];
                Console.WriteLine("  - Roll " + (i + 1) + ": " + results[i]);
            }
            Console.WriteLine(" Totals: ");

            Console.WriteLine("  -- Roll Total Kegs: " + totalKegs);
            Console.WriteLine("  -- Tavern Kegs Total: " + (totalKegs * 10));

            Console.WriteLine("  -- Roll Total Rooms: " + totalRooms);
            Console.WriteLine("  -- Tavern Rooms Total: " + (totalRooms * 10));

            Console.WriteLine("  -- Roll Total Rumors: " + totalRumors);
            Console.WriteLine("  -- Tavern Rumors Total: " + ((totalRumors)-1));

            // TOTAL OVERALL
            Console.WriteLine("\n  -- Tavern Total Income: " + ((totalKegs * 10)+ (totalRooms * 10)));
            Console.WriteLine("  -- Tavern Total Rumors: " + ((totalRumors) - 1));
        }

        /**
        * Bank Building 
        * This calculates intrest on stored income.
        */
        public void bank()
        {
            int response = 0;
            double money = 0;
            double result = 0;
            string createUName;
            string createUBal;
            string newName;
            double newBal = 0;

            f.BankMenu();
            response = Convert.ToInt32(Console.ReadLine());
            if(response == 1)
            {
                //account
                f.bankMenuAccount();
                response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1: //see account
                        Console.WriteLine("Current Account information: \n" + 
                            bankAccount.ToString());
                        break;
                    case 2: //change bal
                        Console.WriteLine("Current Balance: " + bankAccount.balance);
                        Console.WriteLine("Please enter the new balance: ");
                        newBal = Convert.ToDouble(Console.ReadLine());
                        bankAccount.balance = newBal;
                        Console.WriteLine("New Balance is: " + bankAccount.balance);
                        break;
                    case 3: //change name
                        Console.WriteLine("Current Name: " + bankAccount.partyName);
                        Console.WriteLine("Please enter the new Account Name: ");
                        newName = Console.ReadLine();
                        bankAccount.partyName = newName;
                        Console.WriteLine("New name is: " + bankAccount.partyName);
                        break;
                }
            }
            else if (response == 2)
            {
                f.bankMenuMoney();
                response = Convert.ToInt32(Console.ReadLine());

                if (response == 1)
                {
                    Console.WriteLine("Please enter the amount of money in your bank.");
                    money = Convert.ToInt32(Console.ReadLine());

                    result = money + (money * 0.05);
                    Console.WriteLine("Old amount: {0:C2}", money);
                    Console.WriteLine("New amount: {0:C2}", result);
                }
                else
                {
                    u.loadBankInfo(bankAccount);
                    Console.WriteLine(bankAccount.balance);
                }
            }
            else
            {
                Console.WriteLine("Please Enter an account name: ");
                createUName = Console.ReadLine();
                bankAccount.partyName = createUName;
                Console.WriteLine("Please Enter an account balance");
                newBal = Convert.ToDouble(Console.ReadLine());
                bankAccount.balance = newBal;
                Console.WriteLine("New name is: " + bankAccount.partyName);
                Console.WriteLine("New Balance is: " + bankAccount.balance);

            }

           
            //STORE ACCOUNTS IN BACKACCOUNT LIST
            //RETRIEVE BY ID ?
            //SET SERIALIZED DATA TO CURRENT BANK ACCOUNT
            
          

            f.bankSaveDataMenu();
            response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {
                u.saveBankInfo(bankAccount);
            }
            else
            {
                Console.WriteLine("");
            }
        }
        public void buildingTool()
        {
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("What building would you like to calculate?");
                f.buildingMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 6)
                {
                    Console.WriteLine("Wrong Choice! Try again.");
                }
                switch (choice)
                {
                    case 1: // docks water
                        docksWater();
                        Console.WriteLine("");
                        break;
                    case 2: //market stalls
                        MarketStalls();
                        Console.WriteLine("");
                        break;
                    case 3: //tavern
                        MarketStalls();
                        Console.WriteLine("");
                        break;
                    case 4: //bank
                        bank();
                        Console.WriteLine("");
                        break;
                    case 5:
                        docksWater();
                        MarketStalls();
                        Tavern();
                        //bank();
                        Console.WriteLine("");
                        break;
                    case 6:
                        break;
                }
            }
        }
    }

}   
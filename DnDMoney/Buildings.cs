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
        public Formatting f;

        public Buildings()
        {
            this.merchants = new Merchants("Deafualt");
            this.d = new Dice();
            this.f = new Formatting();
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
            //Add serialization for file to store money

            //stored money * 5%
            double money = 0;
            double result = 0;

            Console.WriteLine("Please enter the amount of money in your bank.");
            money = Convert.ToInt32(Console.ReadLine());

            result = money + (money * 0.05);
            Console.WriteLine("Old amount: {0:C2}", money);
            Console.WriteLine("New amount: {0:C2}", result);

        }
        
    }
}   
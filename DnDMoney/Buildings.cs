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
        public DiceRoller d;

        public Buildings()
        {
            this.merchants = new Merchants("Deafualt");
            this.d = new DiceRoller();
        }


        /**
        * 
        * 
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

            for (int i =0; i<results.Length; i++)
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

            results = d.rollD12(1);
            int holder2 = results[0];

            results = d.rollD12(1);
            int holderLeg = results[0];


            merchants.merchantsRoll(holder, holderLeg);
            merchants.QualityRoll(holder2);
            Console.WriteLine("---------------");

            Console.WriteLine(" Totals: ");
            Console.WriteLine("  -- Roll Total: " + total);
            Console.WriteLine("  -- Docks Total: " + (total * 25));

        }

        /**
        * 
        * 
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
            for (int i = 0; i < results.Length; i++)
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
        * 
        * 
        */
        public void Tavern()
        {
            //1d4-1 rumors every 7 days
            //2d10 kegs times 10 gp
            //Room income 10gp * 1d10 every 30 days

            var rand = new Random();
            int totalKegs = 0;
            int totalRooms = 0;
            int totalRumors = 0;
            int temp = 0;
            diceRolls = 2;

            //Kegs
            results = d.rollD10(diceRolls);
            for (int i = 0; i < results.Length; i++)
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
            results = d.rollD10(diceRolls);
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
        }

        /**
        * 
        * 
        */
        /*public void bank()
        {

            //stored money * 5%
            double money = 0;
            double result = 0;

            money = Convert.ToInt32(Console.ReadLine());

        }*/
        
    }
}   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class Merchants
    {
        public int diceOutcome, rollsAmount;
        public Buildings diceRoll;
        string merchantName;
        
        public Merchants(string mName) 
        {
            this.merchantName = mName;
        }



        public void merchantsRoll(int dRoll, int legOption)
        {
           
            Console.WriteLine(" Type: ");
            switch (dRoll)
            {
                case int num when (num >= 1 && num <= 6):
                    Console.WriteLine("   Alcohol and Refreshment");
                    break;
                case int num when (num >= 7 && num <= 10):
                    Console.WriteLine("   Animals (Mundane mounts and pets)");
                    break;
                case int num when (num >= 11 && num <= 15):
                    Console.WriteLine("   Books and Maps(Mundane)");
                    break;
                case int num when (num >= 16 && num <= 19):
                    Console.WriteLine("   Flowers and Seeds");
                    break;
                case int num when (num >= 20 && num <= 25):
                    Console.WriteLine("   Food and Animal Parts");
                    break;
                case int num when (num >= 26 && num <= 29):
                    Console.WriteLine("   Furnniture and Interior Decor");
                    break;
                case int num when (num >= 30 && num <= 34):
                    Console.WriteLine("   High Fashion");
                    break;
                case int num when (num >= 35 && num <= 38):
                    Console.WriteLine("   Jewelry and Gems");
                    break;
                case int num when (num >= 39 && num <= 43):
                    Console.WriteLine("   Knick-Knacks");
                    break;
                case int num when (num >= 44 && num <= 48):
                    Console.WriteLine("   Leatherworking");
                    break;
                case int num when (num >= 49 && num <= 52):
                    Console.WriteLine("   Mechanical Contraptions");
                    break;
                case int num when (num >= 53 && num <= 57):
                    Console.WriteLine("   Medium and Heavy armor (and Shields)");
                    break;
                case int num when (num >= 58 && num <= 61):
                    Console.WriteLine("   Potions, Poisons, and Herbs");
                    break;
                case int num when (num >= 62 && num <= 66):
                    Console.WriteLine("   Religious Idols and Blessings");
                    break;
                case int num when (num >= 67 && num <= 71):
                    Console.WriteLine("   Songs and Instruments");
                    break;
                case int num when (num >= 72 && num <= 75):
                    Console.WriteLine("   Spell tomes and Scrolls");
                    break;
                case int num when (num >= 76 && num <= 80):
                    Console.WriteLine("   Thieving supplies");
                    break;
                case int num when (num >= 81 && num <= 86):
                    Console.WriteLine("   Tools");
                    break;
                case int num when (num >= 87 && num <= 91):
                    Console.WriteLine("   Vehicles and Transportation");
                    break;
                case int num when (num >= 92 && num <= 96):
                    Console.WriteLine("   Weapons");
                    break;
                case int num when (num >= 97 && num <= 100):
                    Console.WriteLine("   Legendary Merchant!!!");
                    LegendaryMerchantRoll(legOption);
                    break;

            }
        }

        public void LegendaryMerchantRoll(int dRoll)
        {
            switch (dRoll)
            {
                case 1:
                    Console.WriteLine("Astral Traveler (Multiversal Wares)");
                    break;
                case int num when (num >= 2 && num <= 3):
                    Console.WriteLine("Enchantments (added to existing items)");
                    break;
                case 4:
                    Console.WriteLine("Fey Bargains (fey goods exhanged for 'favors'");
                    break;
                case int num when (num >= 5 && num <= 6):
                    Console.WriteLine("Magic Items");
                    break;
                case int num when (num >= 7 && num <= 8):
                    Console.WriteLine("Magical Creatures");
                    break;
                case int num when (num >= 9 && num <= 10):
                    Console.WriteLine("Necromancy");
                    break;
                case 11:
                    Console.WriteLine("Needful Thngs (fiendish wares, temps buyers)");
                    break;
                case 12:
                    Console.WriteLine("Time-Lost (Goods from a future time)");
                    break;
            }
        }

        public void QualityRoll(int droll)
        {

            switch (droll)
            {
                case 1:
                    Console.WriteLine(" Quality: \n   Atrocious -- Currency: 1d10x20gp");
                    break;
                case int num when (num >= 2 && num <= 4):
                    Console.WriteLine(" Quality: \n   Poor -- Currency: 1d10x50gp");
                    break;
                case int num when (num >= 5 && num <= 7):
                    Console.WriteLine(" Quality: \n   Medium -- Currency: 1d10x100gp");
                    break;
                case int num when (num >= 8 && num <= 10):
                    Console.WriteLine(" Quality: \n   Good -- Currency: 1d10x250gp");
                    break;
                case int num when (num >= 11 && num <= 12):
                    Console.WriteLine(" Quality: \n   Excellent -- Currency: 1d10x500gp");
                    break;
            }

        }

    }
}

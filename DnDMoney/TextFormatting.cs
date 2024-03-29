﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMoney
{
    public class TextFormatting
    {

        public void introText()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---Knot Pirate Colony Manager!----");
            Console.WriteLine("---------------------------------- \n");
        }

        public void spacerLines() {

            Console.WriteLine("\n ----------------------------- \n");
        }
        public void docksWaterHeaderText()
        {
            Console.WriteLine("~~Knot pirate Docks Monthly Income~~");
            Console.WriteLine(" ::25gp times 2d10 every 30 days:: \n");
        }

        public void marketStallsHeaderText()
        {
            Console.WriteLine("~~Knot pirate Market Stalls Monthly Income~~");
            Console.WriteLine(" ::30gp times 2d6 every 30 days:: \n");
        }

        public void tavernHeaderText()
        {
            Console.WriteLine("~~Knot pirate Tavern Monthly Income~~");
            Console.WriteLine(" ::This section lists the total income from kegs,");
            Console.WriteLine("   rumors, and rooms::");
            Console.WriteLine(" ::Kegs - 2d10 * 10 gp (30 days)::");
            Console.WriteLine(" ::Rooms - 1d10 * 10gp (30 days)::");
            Console.WriteLine(" ::Rumors - 1d4-1 (7 days)      :: \n");
        }
        
        public string rollAmount(int num)
        {
            return (" Random numbers between 1 and " + num);
        }

        public void diceMenu()
        {
            Console.WriteLine("Please Select a dice to roll: ");
            Console.WriteLine("1. - D100 ");
            Console.WriteLine("2. - D20 ");
            Console.WriteLine("3. - D12 ");
            Console.WriteLine("4. - D10 ");
            Console.WriteLine("5. - D6 ");
            Console.WriteLine("6. - D4 \n");
        }

        public void buildingMenu()
        {
            Console.WriteLine("Please Select a building: ");
            Console.WriteLine("1. Docks - Water");
            Console.WriteLine("2. Market Stalls");
            Console.WriteLine("3. Tavern");
            Console.WriteLine("4. Bank");
            Console.WriteLine("5. --ALL CURRENT STRUCTURES--");
            Console.WriteLine("6. Exit back to main menu\n");
        }
        public void BankMenu()
        {
            Console.WriteLine("What would you like to Access?");
            Console.WriteLine("1 - Access Account Information");
            Console.WriteLine("2 - Access Money");
            Console.WriteLine("3 - Create Account");

        }
        public void bankMenuAccount()
        {
            Console.WriteLine("What would you like to change?");
            Console.WriteLine("1 - See account information");
            Console.WriteLine("2 - Change balance");
            Console.WriteLine("3 - Change name");
        }
        public void bankMenuMoney()
        {
            Console.WriteLine("Would you like to Enter the data manually, or load the saved data?");
            Console.WriteLine("1 - Manual Entry");
            Console.WriteLine("2 - Load file");
        }

        public void bankSaveDataMenu()
        {
            Console.WriteLine("Would you like to save this data?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
        }
        
    }
}
